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
            `
};