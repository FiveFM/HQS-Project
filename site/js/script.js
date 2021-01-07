import {MDCTopAppBar} from '@material/top-app-bar/index';
import {MDCDrawer} from '@material/drawer';

// Instantiation
const topAppBarElement = document.querySelector('.mdc-top-app-bar');
const topAppBar = new MDCTopAppBar(topAppBarElement);

// Instantiation
const listElem = document.querySelector('.mdc-drawer .mdc-list');
const drawer = MDCDrawer.attachTo(document.querySelector('.mdc-drawer'));

//If click list element close drawer
listElem.addEventListener('click', (event) => {
    drawer.open = !drawer.open;
});

//If drawer is open close it
topAppBar.setScrollTarget(document.getElementById('main-content'));
topAppBar.listen('MDCTopAppBar:nav', () => {
    drawer.open = !drawer.open;
});

const path = require('path');

//Function for dynamically loading the page content
window.goto = function goto(event = 'Home', page = event) {
    if (event != 'Home') {
        page = event.querySelector('.mdc-list-item__text').innerHTML;
    }

    //Set the app bar title to the page name
    document.getElementById('top-app-bar-title').innerHTML = page;

    //Jquery function that dynamically loads x.html into the main content of the page by id
    $(function () {
        //on build add vapor-store
        $('#main-content').load(path.join('..', `${page.toLowerCase().replace(/ /g, '_')}.html`));
  
    });

    try {
        window.mdc.autoInit();
    } catch (e) {}
};
goto();