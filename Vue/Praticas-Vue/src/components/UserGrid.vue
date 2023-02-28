<template >
<h3>Random User Exercise</h3>
<div class="container">
    <div class="area-1">
        <RandomUserData
            v-for="(user,idx) in users"
            :user="user" :key="idx"
            @last-user="getClickedUser(user)"
        />
    </div>
    <div class="area-2">
        <div>
            <h3>Show Last Card Clicked</h3>
            <SelectedUser v-if="selectedUser" :user="selectedUser"/>
        </div>
    </div>
    <div class="area-3">
        <h3>Selected Users:</h3>
        <UserList />
    </div>
    <div class="area-4">
        <UserCounter :counter="childCounter"></UserCounter>
    </div>
</div>

</template>

<script>
import RandomUserData from './RandomUserData.vue';
import AlertButton from './AlertButton.vue';
import UserCounter from './UserCounter.vue';
import SelectedUser from './SelectedUser.vue';
import UserList from './UserList.vue';
    export default {
    components: { RandomUserData, AlertButton, UserCounter, SelectedUser, UserList },
    props:[
    ],  
    data(){
        return{
            users:[],
            selectedUser:null,
            userList:[],
            childCounter:0,
        }
    },

    methods:{
        getNewRando: async function(){
            const response = await fetch('https://randomuser.me/api/?results=6');
            const {results} = await response.json();
            this.users = await results;
        },

        getClickedUser: function(user){
            this.selectedUser = user;
            this.pushToArray(this.selectedUser)
            this.clicksCounted()
        },

        pushToArray: function(user){
            this.userList.push(user)
        },

        deleteLine: function(index){
            this.userList.splice(index, 1)
        },

        clicksCounted: function(){
            this.childCounter++;
        }
    },

    beforeMount(){
        this.getNewRando();
    },


} 
</script>

<style scoped>
.container {
  display: grid; 
  grid-template-columns: 1fr 1fr 1fr; 
  grid-template-rows: 1fr 1fr 1fr; 
  gap: 30px 30px; 
  grid-template-areas: 
    "area-1 area-1 area-2"
    "area-1 area-1 area-3"
    "area-1 area-1 area-4"; 
}
.area-1 { grid-area: area-1; }
.area-2 { grid-area: area-2; }
.area-3 { grid-area: area-3; }
.area-4 { grid-area: area-4; }

.area-1{
    display:flex;
    flex-wrap: wrap;
    flex-direction: row;
    gap: 70px;
    margin-top: 70px;
}
.area-2{
    position: relative;
    justify-content: center; 
}

.area-3 .ul-elem{
    max-height: 280px;
    overflow: auto;
}
</style>