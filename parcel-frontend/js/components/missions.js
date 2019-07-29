export default function Missions(missions){
    return`
    <ul class='list' id="mission-list">
    ${missions.map(mission => {
            return`
            <li>
                <h2 class='mission_name' >${mission.name}</h2>
                <input class='mission_id' type='hidden' value='${mission.missionId}'>
                <img class='mission_img' src='${mission.imageURL}' alt='${mission.name} image'/>
                <h4 class='mission_description' >${mission.description}</h4>
            </li>`

        }).join("")}
        </ul>
            <section class='add-mission'>
                <input class='add-mission_name' type='text' placeholder='Add Mission name...'>
                <input class='add-mission_img' type='text' placeholder='Add Image...'>
                <input class='add-mission_descrip' type='text' placeholder='Add Description...'>
                <div>
            <select id="select">
                <option value="${missions[1].agencyId}">name</option>
            </select> </div>       
                <button class="add-mission_submit multibutton">Add Mission</button>
        
        
                <input class='mission_Id' type='hidden' value='${missions.Id}>
            `
};