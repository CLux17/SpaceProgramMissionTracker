import StellarBodies from "./stellarBodies";

export default function SingleStellarBody(stellarBody){
    return `
    <img class='stellar_img single' src='${stellarBody.imageURL}' alt='${stellarBody.name} image'></img>
    
    <div id='name-info'><h3>${stellarBody.name}</h3>
    <div id='button-box'>
        <button class='edit-stellarBody multibutton'>Edit Stellar Body</button>
        <button class='delete-stellarBody multibutton'>Delete Stellar Body</button>
            <section class='edit-box'>
                <input class='stellarBody_id' type='hidden' value='${stellarBody.stellarBodyId}'>
                <input class='stellarBody_name' type='text' value='${stellarBody.name}'>
                <input class='stellarBody_classification' type='text' value='${stellarBody.classification}'>
                <textarea class='stellarBody_description'>${stellarBody.description}</textarea>
                <input class='stellarBody_imageUrl' type='text' value='${stellarBody.imageURL}'>
                <button class='edit-stellarBody_submit multibutton'>Submit</button>
            </section>
    </div>
    <p>${stellarBody.description}</p>
    </div>
    <div id='main-children'>
    <h3>Missions</h3>
    
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
        }).join("")}
    <ul id='mission-list'>
    </ul>
    </div>
`;

};


