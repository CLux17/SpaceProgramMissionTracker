import apiActions from './api/api-action';
import Home from './components/home';

import Missions from './components/missions';
import StellarBodies from './components/stellarBodies';
import Agencies from './components/agencies';

import SingleMission from './components/singleMission';
import SingleStellarBody from './components/singleStellarBody';
import SingleAgency from './components/singleAgency';

//import AddStellarBodyModal from './components/add-stellarbody-modal';


pageBuild();

function pageBuild(){
    home();
    missions();
    stellarBodies();
    agencies();
    // singleMission();
    //singleStellarBody();
    // singleAgency();
    //stellarBodyModal();
    //myFunction();
}

function home(){
    const home = document.getElementById('nav_home');

    home.addEventListener('click', function(){
        apiActions.getRequest(
            'https://localhost:44388/api/stellarbody',
            stellarbody => {
                document.querySelector('#root').innerHTML = Home(stellarbody);

            })
    });
};

function stellarBodies(){
    const stellarBody = document.getElementById('nav_stellarBody');

    stellarBody.addEventListener('click', function(){
        apiActions.getRequest(
            'https://localhost:44388/api/stellarbody',
            stellarbody => {
                document.querySelector('#root').innerHTML = StellarBodies(stellarbody);
            })
    });

    document.getElementById('root').addEventListener('click', function(){
        if(event.target.classList.contains('add-stellarBody_submit')){
            const newBodyName = event.target.parentElement.querySelector('.add-stellarBody_name').value;
            const newBodyClass = event.target.parentElement.querySelector('.add-stellarBody_class').value;
            const newBodyDescrip = event.target.parentElement.querySelector('.add-stellarBody_descrip').value;
            const newBodyImage = event.target.parentElement.querySelector('.add-stellarBody_img').value;
            const data = {
                StellarBodyId: 0,
                Name: newBodyName,
                Classification: newBodyClass,
                Description: newBodyDescrip,
                ImageUrl: newBodyImage
            };

            apiActions.postRequest('https://localhost:44388/api/stellarbody',
            data,
            stellar => {
                document.querySelector('#root').innerHTML = StellarBodies(stellar);
            })
        }
    });
        
    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('stellar_img')){
            const stellarBodyId = event.target.parentElement.querySelector('.stellar-body_id').value
            console.log(stellarBodyId)
            apiActions.getRequest('https://localhost:44388/api/stellarbody/' + stellarBodyId, 
            stellarBody => {
                document.querySelector('#root').innerHTML = SingleStellarBody(stellarBody)
            })
        }
    })

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('delete-stellarBody')){
            const removestellarBody_id = event.target.parentElement.querySelector('.stellarBody_id').value;
    
            const data = {
                StellarBodyId: removestellarBody_id,
            };
    
            apiActions.deleteRequest('https://localhost:44388/api/stellarbody', data, stellarBodies => {
                    document.querySelector('#root').innerHTML = StellarBodies(stellarBodies);
                }
            );
        }
    });

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('edit-stellarBody')){
            const editbox = event.target.parentElement.querySelector('.edit-box')
            editbox.style.display = 'block'
        }
        
        if (event.target.classList.contains('edit-stellarBody_submit')){
            const editstellarBody_id = event.target.parentElement.querySelector('.stellarBody_id').value;
            const editstellarBody_name = event.target.parentElement.querySelector('.stellarBody_name').value;
            const editstellarBody_classification = event.target.parentElement.querySelector('.stellarBody_classification').value;
            const editstellarBody_description = event.target.parentElement.querySelector('.stellarBody_description').value;
            const editstellarBody_imageUrl = event.target.parentElement.querySelector('.stellarBody_imageUrl').value;
            
            const data = {
                StellarBodyId: editstellarBody_id,
                Name: editstellarBody_name,
                ImageUrl: editstellarBody_imageUrl,
                Classification: editstellarBody_classification,
                Description: editstellarBody_description
            };
            console.log("just a test")           
            apiActions.putRequest('https://localhost:44388/api/stellarbody', data, stellarBodies => {
                console.log("just a test2")    
            document.querySelector('#root').innerHTML = "";
                boxbg.style.display = 'none';
                document.querySelector('#root').innerHTML = StellarBodies(stellarBodies);
                }
            );
        }
    });
}

// function myFunction() {
//     document.getElementById("myDropdown").classList.toggle("show");
//   }
  
//   function filterFunction() {
//     var input, filter, ul, li, a, i;
//     input = document.getElementById("myInput");
//     filter = input.value.toUpperCase();
//     div = document.getElementById("myDropdown");
//     a = div.getElementsByTagName("a");
//     for (i = 0; i < a.length; i++) {
//       txtValue = a[i].textContent || a[i].innerText;
//       if (txtValue.toUpperCase().indexOf(filter) > -1) {
//         a[i].style.display = "";
//       } else {
//         a[i].style.display = "none";
//       }
//     }
//   }

function missions(){
    const mission = document.getElementById('nav_mission');

    mission.addEventListener('click', function(){
        apiActions.getRequest(
            'https://localhost:44388/api/mission',
            missions => {
                document.querySelector('#root').innerHTML = Missions(missions);
            })
    });

    document.getElementById('root').addEventListener('click', function(){
        if(event.target.classList.contains('add-mission_submit')){
            const newMissionName = event.target.parentElement.querySelector('.add-mission_name').value;
             const newMissionDescrip = event.target.parentElement.querySelector('.add-mission_descrip').value;
             const newMissionImg = event.target.parentElement.querySelector('.add-mission_img').value;
            
             const data = {
                MissionId: 0,
                Name: newMissionName,
                Description: newMissionDescrip,
                ImageURL: newMissionImg,
                AgencyId: 1,
                StellarBodyId: 1,

            };

            apiActions.postRequest('https://localhost:44388/api/mission',
            data,
            missions => {
                document.querySelector('#root').innerHTML = Missions(missions);
            })
        }
    });

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('mission_img')){
            const missionId = event.target.parentElement.querySelector('.mission_id').value
            apiActions.getRequest('https://localhost:44388/api/mission/' + missionId,
            mission => {
                document.querySelector('#root').innerHTML = SingleMission(mission)
            })
        }
    });

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('delete-mission')){
            const removemission_id = event.target.parentElement.querySelector('.mission_id').value;
    
            const data = {
                missionId: removemission_id,
            };
    
            apiActions.deleteRequest('https://localhost:44388/api/mission', data, 
            missions => {
                    document.querySelector('#root').innerHTML = Missions(missions);
                }
            );
        }
    });

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('edit-mission')){
            const editbox = event.target.parentElement.querySelector('.edit-box')
            editbox.style.display = 'block'
        }
        
        if (event.target.classList.contains('edit-mission_submit')){
            const editmission_id = event.target.parentElement.querySelector('.mission_id').value;
            const editmission_name = event.target.parentElement.querySelector('.mission_name').value;
            const editmission_description = event.target.parentElement.querySelector('.mission_description').value;
            const editmission_imageUrl = event.target.parentElement.querySelector('.mission_imageUrl').value;
            const editmissionagency_id = event.target.parentElement.querySelector('.agency_id').value;
            const editmissionstellarbody_id = event.target.parentElement.querySelector('.stellarbody_id').value;

            const data = {
                MissionId: editmission_id,
                Name: editmission_name,
                ImageUrl: editmission_imageUrl,
                Description: editmission_description,
                AgencyId: editmissionagency_id,
                StellarBodyId: editmissionstellarbody_id
            };
            console.log(editmissionagency_id)
            console.log(editmissionstellarbody_id)
            apiActions.putRequest('https://localhost:44388/api/mission', data, mission => {
            document.querySelector('#root').innerHTML = "";
                boxbg.style.display = 'none';
                document.querySelector('#root').innerHTML = Missions(mission);
                }
            );
        }
    });

}

function agencies(){
    const agency = document.getElementById('nav_agency');

    agency.addEventListener('click', function(){
        apiActions.getRequest(
            'https://localhost:44388/api/agency',
            agencies => {
                document.querySelector('#root').innerHTML = Agencies(agencies);
            })
    });

    document.getElementById('root').addEventListener('click', function(){
        if(event.target.classList.contains('add-agency_submit')){
            const newAgencyName = event.target.parentElement.querySelector('.add-agency_name').value;
            const newAgencyDescrip = event.target.parentElement.querySelector('.add-agency_descrip').value;
            const newAgencyImage = event.target.parentElement.querySelector('.add-agency_img').value;
            
            const data = {
                AgencyId: 0,
                Name: newAgencyName,
                Description:newAgencyDescrip,
                ImageUrl: newAgencyImage
            };

            apiActions.postRequest('https://localhost:44388/api/agency',
            data,
            agencies => {
                document.querySelector('#root').innerHTML = Agencies(agencies);
            })
        }
    });

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('agency_img')){
            const agencyId = event.target.parentElement.querySelector('.agency_id').value
            console.log(agencyId)
            apiActions.getRequest('https://localhost:44388/api/agency/' + agencyId, 
            agency => {
                document.querySelector('#root').innerHTML = SingleAgency(agency)
            })
        }
    })

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('delete-agency')){
            const removeagency_id = event.target.parentElement.querySelector('.agency_id').value;
    
            const data = {
                AgencyId: removeagency_id,
            };
    
            apiActions.deleteRequest('https://localhost:44388/api/agency', data, agencies => {
                    document.querySelector('#root').innerHTML = Agencies(agencies);
                }
            );
        }
    });

    document.getElementById('root').addEventListener('click', function(){
        if (event.target.classList.contains('edit-agency')){
            const editbox = event.target.parentElement.querySelector('.edit-box')
            editbox.style.display = 'block'
        }
        
        if (event.target.classList.contains('agency_submit')){
            const editagency_id = event.target.parentElement.querySelector('.agency_id').value;
            const editagency_name = event.target.parentElement.querySelector('.agency_name').value;
            const editagency_description = event.target.parentElement.querySelector('.agency_description').value;
            const editagency_imageUrl = event.target.parentElement.querySelector('.agency_imageUrl').value;
            
            const data = {
                agencyId: editagency_id,
                Name: editagency_name,
                ImageUrl: editagency_imageUrl,
                Description: editagency_description
            };
                       
            apiActions.putRequest('https://localhost:44388/api/agency', data, agencies => {
                document.querySelector('#root').innerHTML = Agencies(agencies);
                }
            );
        }
    });
}

// function stellarBodyModal(){
//     document.getElementById('root').addEventListener('click', function() {
//         if(event.target.classList.contains('add-stellarBody-modal')){
//             const modal = document.getElementById('boxbg')
//             const modalbox = document.getElementById('box')

//             modalbox.innerHTML = AddStellarBodyModal()
//             modal.style.display = 'block'
//         };
//     })

//     document.getElementById('root').addEventListener('click', function(){
//         if(event.target.classList.contains('add-stellarBody_submit')){
//             const newBody = event.target.parentElement.querySelector('.add-stellarBody_name').value;
//             const data = {
//                 id: 0,
//                 name: newBody
//             };

//             apiActions.postRequest('https://localhost:44388/api/stellarbody',
//             data,
//             stellar => {
//                 document.querySelector('#root').innerHTML = StellarBodies(stellar);
//             })
//         }
//     });
// }
