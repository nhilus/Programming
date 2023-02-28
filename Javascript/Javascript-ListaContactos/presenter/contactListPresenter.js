import {Contact} from "../model/contact.js";
import {addContactToList, getContactList} from "../store/contactListStore.js";
import {addContactToUI, renderList} from "../components/contactListComponent.js"



function addContact({_id,fullname,phone_Number, email}){

    const newContact = new Contact( {_id,fullname,phone_Number,email} );
    addContactToList(newContact);
    addContactToUI(newContact);
}

function renderContactList(){
    renderList(getContactList());
}

export {addContact, renderContactList}

