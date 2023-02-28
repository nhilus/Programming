import { createContactListItem } from "../components/contactListItemCreation.js";


const ul=document.querySelector('ul');

function addContactToUI(contact) {
    ul.append(createContactListItem(contact))
}

function clearList() {
    ul.innerHTML = ''
  }

function renderList(contactsList){
    contactsList.forEach(contact => {
        addContactToUI(contact);
    });
}



export {addContactToUI,clearList, renderList}