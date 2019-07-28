export default function Home(stellarBodies){
    return`
    <h1>Space Program Mission Tracker</h1>
        <p>This site shows you all the different missions to outspace worldwide. It's divided up by Agency, Mission, and Stellar Body. Check out all the times we mere mortals have expanded our research into the great unknown.</p>
        <ul id="stellarbody-list">
        ${stellarBodies.map(stellarBody => {
            return`
            <li>
                <h4>${stellarBody.name}</h4>
            </li>`

        }).join("")}
        </ul>

        
        `;
};