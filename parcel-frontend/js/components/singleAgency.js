export default function SingleAgency(agency){
    return `
    <div id='agency-name'><h2>${agency.name}</h2>
    <img class='agency_img single' src='${agency.imageURL}' alt='${agency.name} image'></img>
    
    <div id='button-box'>
        <button class='edit-agency multibutton'>Edit Agency</button>
        <button class='delete-agency multibutton'>Delete Agency</button>
        <section class='edit-box'>
            <input class='agency_id' type='hidden' value='${agency.agencyId}'>
            <input class='agency_name' type='text' value='${agency.name}'>
            <textarea class='agency_description'>${agency.description}</textarea>
            <input class='agency_imageUrl' type='text' value='${agency.imageURL}'>
            <button class='agency_submit multibutton'>Submit</button>
        </section>
    </div>
    
    </div>
    <div id='main-children'>
    <h3>Missions</h3>

    <ul class='list' id='mission-list'>
        ${agency.missions.map(mission => {
            return `
                <li>
                    <div class='child-image'>
                    <img class='mission_img single' src='${mission.imageURL}'></img>
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
