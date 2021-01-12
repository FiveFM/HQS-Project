const path = require('path');

//Function for dynamically loading the page content
window.goto = function goto(event = 'Home', page = event) {
    if (event != 'Home') {
        page = event.textContent;
        document.querySelectorAll('.nav-link.active').forEach((elem) => {
            elem.classList.remove('active');
        });
    
        event.classList.add('active');
    }


    //Jquery function that dynamically loads x.html into the main content of the page by id
    $(function () {
        //on build add vapor-store
        $('#main-content').load(path.join('..', `${page.toLowerCase().replace(/ /g, '_')}.html`));
    });
};
goto();
