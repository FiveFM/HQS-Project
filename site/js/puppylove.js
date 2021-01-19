const path = require('path');

import german_shepherd from '../assets/puppy-love/html/german_shepherd.html';
import golden_retriever from '../assets/puppy-love/html/golden_retriever.html';
import husky from '../assets/puppy-love/html/husky.html';
import maltese from '../assets/puppy-love/html/maltese.html';

let dogs = {
    german_shepherd: [german_shepherd],
    golden_retriever: [golden_retriever],
    husky: [husky],
    maltese: [maltese]
};

window.loadInfo = function loadInfo(type) {
    let title = document.querySelector('.modal #title');
    let content = document.querySelector('.modal #content');
    title.textContent = $(dogs[type][0])[0].textContent;
    content.innerHTML = $(dogs[type][0])[2].innerHTML;
};

window.openModal = function openModal(modal, type, args) {
    $(`#${modal}`).modal('show');

    if (type == 'puppy') loadInfo(args);
};

window.closeModal = function closeModal(modal) {
    $(`#${modal}`).modal('hide');
};
