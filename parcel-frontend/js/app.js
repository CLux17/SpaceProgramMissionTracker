import Home from './components/home';
import Missions from './components/missions';


pageBuild();

function pageBuild(){
    home();
    mission();
}

function home(){
    const body = document.getElementById('root');
    const home = document.getElementById('nav_home');

    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });
};

function mission(){
    const body = document.getElementById('root');
    const home = document.getElementById('nav_mission');

    home.addEventListener('click', function(){
        body.innerHTML = Missions();
    });
};

