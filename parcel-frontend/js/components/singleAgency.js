export default function SingleAgency(singleAgency){
    return `
    <img src='${agency.imageURL}' id='main-image' alt='Agency image'></img>
    
    <div id='agency-name'><h3>${agency.name}</h3>
    <div id='button-box'>
        <button class='edit-agency'>Edit Agency</button>
        <button class='delete-agency'>Delete Agency</button>
        <section class='edit-box'>
            <input class='agency_id' type='hidden' value='${agency.agencyId}'>
            <input class='edit-agency_imageUrl' type='text' value='${agency.imageURL}'>
            <input class='edit-agency_name' type='text' value='${agency.name}'>
            <textarea class='edit-agency_description'>${agency.description}</textarea>
            <button class='edit-agency_submit'>Submit</button>
        </section>
    </div>
    
    </div>
    <div id='main-children'>
    <h3>Missions</h3>

    <button class='add-mission-modal'>Add mission</button>
    <ul id='mission-list'>
        ${agency.missions.map(mission => {
            return `
                <li>
                    <div class='child-image'>
                    <img src='${mission.imageURL}'></img>
                    </div>
                    <h4 class='target'>${mission.name}</h4>
                    <input class='mission_id' type='hidden' value='${mission.missionId}'>
                    <input class='mission_name' type='hidden' value='${mission.description}'>
                    <input class='mission_recordLabel' type='hidden' value='${mission.agencyId}'>
                    <input class='stellarBody_Id' type='hidden' value='${mission.stellarBodyId}'>
                </li>
    `;
        })
        .join("")}
    </ul>
    </div>
    `

};
