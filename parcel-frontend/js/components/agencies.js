export default function Agencies(agencies){
    return`
    <ul id="stellarbody-list">
    ${agencies.map(agency => {
            return`
            <li>
                <h2>${agency.name}</h2>
                <img class='stellar_img' src='${agency.imageURL}' alt='${agency.name} image'/>
                <h4>${agency.description}</h4>
            </li>`

        }).join("")}
        </ul>
            <section class='add-agency'>
                <input class='add-agency_name' type='text' placeholder='Add Agency name...'>
                <input class='add-agency_img' type='text' placeholder='Add Image...'>
                <input class='add-agency_descrip' type='text' placeholder='Add Description...'>
                <button class="add-agency_submit multibutton">Add Agency</button>
                <input class='agency_Id' type='hidden' value='${agencies.Id}>
            </section>
        
        `;

};
