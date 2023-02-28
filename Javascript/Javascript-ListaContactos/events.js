import { renderContactList } from "./presenter/contactListPresenter.js";

function setupContactList(){
    document.addEventListener('DOMContentLoaded', ()=>{renderContactList()});
}
export {setupContactList}


