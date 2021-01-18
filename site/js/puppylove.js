import data from '../json/dogs.json';

window.loadInfo = function loadInfo(type) {
    let title = document.querySelector('.modal #title');
    let content = document.querySelector('.modal #content');
    title.innerHTML = data[type].name;
    content.innerHTML = data[type].desc;
};

window.openModal = function openModal(modal, type, args) {
    $(`#${modal}`).modal('show');

    if (type == 'puppy') loadInfo(args);
};

window.closeModal = function closeModal(modal) {
    $(`#${modal}`).modal('hide');
};
