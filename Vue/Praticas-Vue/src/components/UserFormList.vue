<template>
    <div class="user-card-container">
        <ul>
            <li v-for="(user, idx) in getFromLocalStorage" :user="user" :key="idx">
                <span>{{user.name}}</span>
                <span>{{user.phoneNumber}}</span>
                <span>{{user.email}}</span>
                <span>{{user.message}}</span>
            </li>
        </ul>
    </div>
</template>

<script>
import { mapActions, mapWritableState } from 'pinia'
import {useUserListStore} from '../store/UserData';

export default {

    
    name: "UserList",
    props: [
        'users'
    ],
    methods: {
        
    },
    computed:{
        ...mapActions(useUserListStore, ['getFromLocalStorage'])
    },

    emits:[
        'editing-user'
    ],

    
}
</script>

<style scoped>
.user-card-container{
    display: flex;
    flex-wrap: wrap-reverse;
    justify-content: center;
    gap: 50px;
    max-width: 1200px;
}
</style>