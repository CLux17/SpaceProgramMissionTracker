export default function SingleMission(singleMission){
    console.log("hi there")
    return `
    <div id='name-info'><h2>${singleMission.missionName}</h2>
    <img class='mission_img single' src='${singleMission.imageURL}' alt='${singleMission.missionName} image'></img>
    
    <div id='button-box'>
        <button class='edit-mission multibutton'>Edit Mission</button>
        <button class='delete-mission multibutton'>Delete Mission</button>
            <section class='edit-box'>
                <input class='mission_id' type='hidden' value='${singleMission.missionId}'>
                <input class='agency_id' type='Hidden' value='${singleMission.agencyId}'>
                <input class='stellarbody_id' type='Hidden' value='${singleMission.stellarBodyId}'>
                <input class='mission_name' type='text' value='${singleMission.missionName}'>
                <textarea class='mission_description'>${singleMission.description}</textarea>
                <input class='mission_imageUrl' type='text' value='${singleMission.imageURL}'>
                <input class='agency_id' type='hidden' value='${singleMission.agencyId}'>
                <input class='stellarBody_id' type='hidden' value='${singleMission.stellarBodyId}'>

                <button class='edit-mission_submit multibutton'>Submit</button>
            </section>
    </div>
    <p>${singleMission.description}</p>
    </div>
    
`;

};
