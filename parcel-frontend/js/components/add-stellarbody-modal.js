export default function AddStellarBodyModal(){
    return `
    <section class='add-stellarBody'>
        <input class='add-stellarBody_name' type='text' placeholder='Add Stellar Body name...'>
        <input class='add-stellarBody_descrip' type='text' placeholder='Add Description...'>
        <input class='add-stellarBody_img' type='text' placeholder='Add Image...'>
        <button class="add-stellarBody_submit multibutton">Add Stellar Body</button>
        <input class='stellarBody_Id' type='hidden' value='${stellarBody.Id}>
    </section>
    `
}