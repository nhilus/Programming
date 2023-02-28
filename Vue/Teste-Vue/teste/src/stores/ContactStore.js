import {defineStore} from 'pinia'


export const useContactStore = defineStore('contactStore', {
    state:()=>({
        contacts:[],
    }),

    getters:{

        isCompleted() {
            return this.contacts.filter(t => t.isComp)
        },

        isIncomplete() {
            return this.contacts.filter(t => !t.isComp)
        },

        CompletedCount(){
            return this.contacts.reduce( (p, c) => {
                return c.isComp ? p + 1 : p
            },0)
        },

        IncompleteCount(){
            return this.contacts.reduce( (p, c) => {
                return c.isComp ? p : p + 1
            },0)
        },

        totalCount: (state) => {
            return state.contacts.length
        }
    },

    actions:{
        addContact(contact) {
            this.contacts.push(contact)
           
        },

        deleteContact(id){
            this.contacts = this.contacts.filter(contact => { //not working as intended
                return contact.id != id
            })
        },

        toggleComplete(id){
        },

        activateEdit(disabled){
            disabled = !disabled
        },

        canEdit(){
            this.activateEdit()
        },

        getContact(id){
            return this.contacts.find(c => c.id == id)
        }
    }
})