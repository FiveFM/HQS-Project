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

//BLockers

/*

//F12
$(document).keydown(function (event) {
    if (event.keyCode == 123) {
        return false;
    } else if (event.ctrlKey && event.shiftKey && event.keyCode == 73) {
        return false;
    }
});

//CTRL P
$(document).on('keydown', function (e) {
    if ((e.ctrlKey || e.metaKey) && (e.key == 'p' || e.charCode == 16 || e.charCode == 112 || e.keyCode == 80)) {
        e.cancelBubble = true;
        e.preventDefault();

        e.stopImmediatePropagation();
    }
});

//CTRL SHIFT I && Manual open
$(document).on('contextmenu', function (e) {
    e.preventDefault();
});
*/
