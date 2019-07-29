export default function SingleMission(singleMission){
    console.log("hi there")
    return `
    <div id='name-info'><h2>${singleMission.name}</h2>
    <img class='mission_img single' src='${singleMission.imageURL}' alt='${singleMission.name} image'></img>
    
    <div id='button-box'>
        <button class='edit-mission multibutton'>Edit Mission</button>
        <button class='delete-mission multibutton'>Delete Mission</button>
            <section class='edit-box'>
                <input class='mission_id' type='hidden' value='${singleMission.missionId}'>
                <input class='mission_name' type='text' value='${singleMission.name}'>
                <textarea class='mission_description'>${singleMission.description}</textarea>
                <input class='mission_imageUrl' type='text' value='${singleMission.imageURL}'>
                <button class='edit-mission_submit multibutton'>Submit</button>
            </section>
    </div>
    <p>${singleMission.description}</p>
    </div>
`;

};
