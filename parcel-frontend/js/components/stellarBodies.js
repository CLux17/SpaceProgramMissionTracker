export default function StellarBodies(stellarBodies){
    return`
    <ul id="stellarbody-list">
    ${stellarBodies.map(stellarBody => {
            return`
            <li>
                <h2>${stellarBody.name}</h2>
                <img class='stellar_img' src='${stellarBody.imageURL}' alt='${stellarBody.name} image'/>
                <input class='stellar-body_id' type='hidden' value='${stellarBody.stellarBodyId}'>
                <h4>${stellarBody.classification}</h4>
                <h4>${stellarBody.description}</h4>
            </li>`

        }).join("")}
        </ul>
            <section class='add-stellarBody'>
                <input class='add-stellarBody_name' type='text' placeholder='Add Stellar Body name...'>
                <input class='add-stellarBody_class' type='text' placeholder='Add Classification...'>
                <input class='add-stellarBody_img' type='text' placeholder='Add Image...'>
                <input class='add-stellarBody_descrip' type='text' placeholder='Add Description...'>
                <button class="add-stellarBody_submit multibutton">Add Stellar Body</button>
                <input class='stellarBody_Id' type='hidden' value='${stellarBodies.Id}>
            </section>
        
        `;

};