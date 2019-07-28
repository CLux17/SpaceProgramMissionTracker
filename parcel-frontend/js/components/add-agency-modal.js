export default function AddAgencyModal(){
    return `
    <section class='add-agency'>
        <input class='add-agency_name' type='text' placeholder='Add Stellar Body name...'>
        <input class='add-agency_descrip' type='text' placeholder='Add Description...'>
        <input class='add-agency_img' type='text' placeholder='Add Image...'>
        <button class="add-agency_submit multibutton">Add Stellar Body</button>
        <input class='agency_Id' type='hidden' value='${agency.Id}>
    </section>
    `
}