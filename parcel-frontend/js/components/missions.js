import apiActions from '../api/api-action';

export default function Missions(){
    setPage();
    loadMissions();
    loadAgencies();
    loadStellarBodies();

    function setPage(){
        let page =
        `<ul class='list' id='mission-list'></ul>
        <input class='add-mission_name' type='text' placeholder='Add Mission name...'>
        <input class='add-mission_img' type='text' placeholder='Add Image...'>
        <input class='add-mission_descrip' type='text' placeholder='Add Description...'>
        <div>
            <select id="agency-select">
                </select>
        </div>
        <div>
            <select id="stellar-bodies-select">
            </select>
        </div>
        <button class="add-mission_submit multibutton">Add Mission</button>;
        `
        document.querySelector('#root').innerHTML = page;
    }

    function loadMissions(){
        apiActions.getRequest('https://localhost:44388/api/mission', setMissions);
    }

    function setMissions(missions) {
        let missionHtml = '';
        for (const mission of missions){
            missionHtml += `
            <li>
                <h2 class='mission_name' >${mission.missionName}</h2>
                <input class='mission_id' type='hidden' value='${mission.missionId}'>
                <img class='mission_img' src='${mission.imageURL}' alt='${mission.missionName} image'/>
                <h4 class='mission_description' >${mission.description}</h4>
            </li>`
        }

        document.querySelector('#mission-list').innerHTML = missionHtml;
    }
    console.log("mission page line 46")

    function loadAgencies(){
        apiActions.getRequest('https://localhost:44388/api/agency', setAgencies);
    }

    function setAgencies(agencies){
        let agencyHtml = '';
        for(const agency of agencies){
            agencyHtml += `<option id='agencyId-value' value="${agency.agencyId}">${agency.agencyName}</option>`
        }
        console.log(agencyHtml)
        console.log(document.querySelector('#agency-select'))
        document.querySelector('#agency-select').innerHTML = agencyHtml;
    }

    function loadStellarBodies(){
        apiActions.getRequest('https://localhost:44388/api/stellarBody', setStellarBodies);
    }

    function setStellarBodies(bodies){
        let stellarHtml = '';
        for (const stellar of bodies){
            stellarHtml += `<option id='stellar-value' value="${stellar.stellarBodyId}">${stellar.stellarBodyName}</option>`
        }
        console.log(stellarHtml)
        document.querySelector('#stellar-bodies-select').innerHTML = stellarHtml;
    }

}


