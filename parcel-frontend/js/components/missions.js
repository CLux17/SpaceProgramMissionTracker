export default function Missions(missions, agencies, stellarBodies){
    console.log(stellarBodies)
    console.log(agencies)
    return`
    <ul class='list' id="mission-list">
    ${missions.map(man => {
            return`
            <li>
                <h2 class='mission_name' >${man.missionName}</h2>
                <input class='mission_id' type='hidden' value='${man.missionId}'>
                <img class='mission_img' src='${man.imageURL}' alt='${man.missionName} image'/>
                <h4 class='mission_description' >${man.description}</h4>
            </li>`

        }).join("")}
        </ul>
        <section class='add-mission'>
                <input class='add-mission_name' type='text' placeholder='Add Mission name...'>
                <input class='add-mission_img' type='text' placeholder='Add Image...'>
                <input class='add-mission_descrip' type='text' placeholder='Add Description...'>
                <div>
                <select id="select">
                ${agencies.map(agencylist =>{
                    return `
                            <option value="${agencylist.AgencyId}">Hi</option>
                            `
                        })}
                </select>
                </div>
                <div>
                <select id="selecttwo">
                ${stellarBodies.map(bodylist =>{
                    return `
                            <option value="${bodylist.StellarBodyId}">Bods</option>
                            `
                        })}
                </select>

                 </div>       
                <button class="add-mission_submit multibutton">Add Mission</button>
            `
};