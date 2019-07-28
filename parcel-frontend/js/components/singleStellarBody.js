export default function SingleStellarBody(stellarBody){
    return `
    <img src='${stellarBody.imageURL}' id='main-image' alt='Stellar Body image'></img>
    
    <div id='name-info'><h3>${stellarBody.name}</h3>
    <div id='button-box'>
        <button class='edit-stellarBody'>Edit Stellar Body</button>
        <button class='delete-stellarBody'>Delete Stellar Body</button>
        <section class='edit-box'>
            <input class='stellarBody_id' type='hidden' value='${stellarBody.stellarBodyId}'>
            <input class='edit-stellarBody_imageUrl' type='hidden' value='${stellarBody.imageURL}'>
            <input class='edit-stellarBody_name' type='text' value='${stellarBody.name}'>
            <textarea class='edit-stellarBody_description'>${stellarBody.description}</textarea>
            <button class='edit-stellarBody_submit'>Submit</button>
        </section>
    </div>
    <p>${stellarBody.description}</p>
    </div>
    <div id='main-children'>
    <h3>Missions</h3>

    <button class='add-mission-modal'>Add mission</button>
    <ul id='mission-list'>
        ${stellarBody.missions.map(mission => {
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
