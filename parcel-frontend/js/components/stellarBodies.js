export default function StellarBodies(stellarBodies){
    return`
    <ul class='list' id="stellarbody-list">
    ${stellarBodies.map(stellarBody => {
            return`
            <li>
                <h2>${stellarBody.stellarBodyName}</h2>
                <img class='stellar_img' src='${stellarBody.imageURL}' alt='${stellarBody.stellarBodyName} image'/>
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

//in app.js
// function stellarBodyModal(){
//     document.getElementById('root').addEventListener('click', function() {
//         if(event.target.classList.contains('add-stellarBody-modal')){
//             const modal = document.getElementById('boxbg')
//             const modalbox = document.getElementById('box')

//             modalbox.innerHTML = AddStellarBodyModal()
//             modal.style.display = 'block'
//         };
//     })

//     document.getElementById('root').addEventListener('click', function(){
//         if(event.target.classList.contains('add-stellarBody_submit')){
//             const newBody = event.target.parentElement.querySelector('.add-stellarBody_name').value;
//             const data = {
//                 id: 0,
//                 name: newBody
//             };

//             apiActions.postRequest('https://localhost:44388/api/stellarbody',
//             data,
//             stellar => {
//                 document.querySelector('#root').innerHTML = StellarBodies(stellar);
//             })
//         }
//     });
// }
