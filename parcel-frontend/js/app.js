import apiActions from './api/api-action';
import Home from './components/home';

import Missions from './components/missions';
//import StellarBodies from './components/stellarBodies';
// import Agencies from './components/agencies';

// import SingleMission from './components/singleMission';
// import SingleStellarBody from './components/singleStellarBody';
// import SingleAgency from './components/singleAgency';


pageBuild();

function pageBuild(){
    home();
    missions();
    //stellarBodies();
    // agencies();
    // singleMission();
    // singleStellarBody();
    // singleAgency();
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

function missions(){
    const body = document.getElementById('root');
    const mission = document.getElementById('nav_mission');

    mission.addEventListener('click', function(){
        body.innerHTML = Missions();
    });
};

// function stellarBodies(){
//     const stellarBody = document.getElementById('nav_stellarBody');

//     stellarBody.addEventListener('click', function(){
//         apiActions.getRequest(
//             'https://localhost:44388/api/stellarbody',
//             stellarbody => {
//                 document.querySelector('#root').innerHTML = Home(stellarbody);
//             })
//     });
// }