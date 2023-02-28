import { Contact } from "../model/contact.js";

const ContactList=[
    new Contact ({_id: 0, fullname: 'Contact 01', phone_number: '919919919', email: 'contact1@mail.pt'}),
    new Contact ({_id: 1, fullname: 'Contact 02', phone_number: '929929929', email: 'contact2@mail.pt'}),
    new Contact ({_id: 2, fullname: 'Contact 03', phone_number: '939939939', email: 'contact3@mail.pt'})
]
function addContactToList(contact){
    contact._id= ContactList.length
    ContactList.push(contact)
    console.log(ContactList)
}

function getContactList(){
    return ContactList
}

export {addContactToList, getContactList}