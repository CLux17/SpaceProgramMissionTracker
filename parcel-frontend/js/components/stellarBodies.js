export default function StellarBodies(stellarBodies){
    return`
    <ul id="stellarbody-list">
    ${stellarBodies.map(stellarBody => {
            return`
            <li>
                <h4>${stellarBody.name}</h4>
            </li>`

        }).join("")}
        </ul>
            <section class='add-stellarBody'>
                <input class='add-stellarBody_name' type='text' placeholder='Add Stellar Body name...'>
                <input class='add-stellarBody_class' type='text' placeholder='Add Classification...'>
                <input class='add-stellarBody_img' type='text' placeholder='Add Image...'>
                <input class='add-stellarBody_descrip' type='text' placeholder='Add Description...'>
        
        `;

};