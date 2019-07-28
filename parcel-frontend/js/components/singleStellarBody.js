export default function SingleStellarBody(singleSB){
    return `
    <img src='${stellarBody.imageURL}' id='main-image' alt='Artist image'></img>
    
    <div id='name-info'><h3>${stellarBody.name}</h3>
    <div id='button-box'>
        <button class='edit-stellarBody'>Edit Artist</button>
        <button class='delete-stellarBody'>Delete Artist</button>
        <section class='edit-box'>
            <input class='stellarBody_id' type='hidden' value='${stellarBody.stellarBodyId}'>
            <input class='edit-stellarBody_imageUrl' type='hidden' value='${stellarBody.imageURL}'>
            <input class='edit-stellarBody_name' type='text' value='${stellarBody.name}'>
            <input class='edit-stellarBody_homeTown' type='text' value='${stellarBody.homeTown}'>
            <textarea class='edit-stellarBody_description'>${stellarBody.description}</textarea>
            <button class='edit-stellarBody_submit'>Submit</button>
        </section>
    </div>
    <p>${stellarBody.description}</p>
    </div>
    <div id='main-children'>
    <h3>Albums</h3>

    <button class='add-album-modal'>Add Album</button>
    <ul id='album-list'>
        ${stellarBody.albums.map(album => {
            return `
                <li>
                    <div class='child-image'>
                    <img src='${album.imageURL}'></img>
                    </div>
                    <h4 class='target'>${album.name}</h4>
                    <input class='album_id' type='hidden' value='${album.albumId}'>
                    <input class='album_name' type='hidden' value='${album.name}'>
                    <input class='album_recordLabel' type='hidden' value='${album.recordLabel}'>
                    <input class='stellarBody_Id' type='hidden' value='${album.stellarBodyId}'>
                </li>
    `;
        })
        .join("")}
    </ul>
    </div>
    `

};
