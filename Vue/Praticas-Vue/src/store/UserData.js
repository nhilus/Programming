import { defineStore } from 'pinia';
import RegisterUser from '../models/RegisterUser';



export const useUserListStore = defineStore('userListStore', {
    state:() =>({
        userList: [],
    }),

    getters:{
        getUserForm(){
            return this.userList
          }
    },

    actions:{
        
        addUserToList(newUser){
            this.userList.push(new RegisterUser(newUser))
            console.log(this.userList)
            localStorage.setItem('Users',JSON.stringify(this.userList));
        },

        getFromLocalStorage(){
            this.userlist = JSON.parse(localStorage.getItem('Users'))
            console.log(this.userList)
            return this.userList
        },

    },

})