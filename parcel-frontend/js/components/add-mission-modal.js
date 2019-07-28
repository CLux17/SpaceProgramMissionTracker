export default function AddMissionModal(){
    return `
    <section class='add-mission'>
        <input class='add-mission_name' type='text' placeholder='Add Stellar Body name...'>
        <input class='add-mission_descrip' type='text' placeholder='Add Description...'>
        <input class='add-mission_img' type='text' placeholder='Add Image...'>
        <button class="add-mission_submit multibutton">Add Stellar Body</button>
        <input class='mission_Id' type='hidden' value='${mission.Id}>
    </section>
    `
}