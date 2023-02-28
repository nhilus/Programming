<template>
    <div  v-if="this.image" class="card">
        <img :src=this.image class="image" alt="...">
        <div class="content" :style="cssVars">
            <h5 class="card-title">{{this.firstName}} {{this.lastName}}</h5>
            <p class="card-text">Residence: {{this.country}}, {{this.city}}</p>
            <p class="card-text">Email: {{this.email}}</p>
            <AlertButton @click="SubmitNameAlert(`${this.firstName} ${this.lastName}`, $event)">Click Me</AlertButton>
        </div>
    </div>
</template>

<script>
import AlertButton from './AlertButton.vue';
import User from '../models/userData.js';
import CheckUserGender from '../models/userData.js';

    export default {
        components:{
            AlertButton
        },
        props:{
            user: Object,
        },
        data() {
            return {
                image: '',
                firstName: '',
                lastName: '',
                country: '',
                city: '',
                email: '',
                gender:'',
                isMale:null,
            }
        },

        methods:{
            getUserData(){
                this.image = this.user.picture.large;
                this.firstName = this.user.name.first;
                this.lastName = this.user.name.last;
                this.country = this.user.location.country;
                this.city = this.user.location.city;
                this.email = this.user.email;
                this.gender = this.user.gender;
            },

            CheckUserGender() {
                User.gender === 'male' ? true : false;
            },

            SubmitNameAlert(message, event){
                confirm(message)
                if(event){
                    this.$emit('last-user')
                }
            },
              

        },
        emits:[
            'last-user'
        ],
        computed:{
            cssVars () {
                return {
                    'background-color': this.isMale ? 'lightblue' : 'pink'
                }
             }
        },

        beforeCreate() {
            
        },

        created() {

        },

        beforeMount() {
            this.getUserData();
        },

        mounted() {
        },

        beforeUpdate() {
            console.log("lifecycle hook: beforeUpdate");
        },

        updated() {
            console.log("lifecycle hook: updated", this);
            this.getUserData()
        },

        beforeUnmount() {
            console.log("lifecycle hook: beforeUnmount");
        },
        
        unmounted() {
            console.log("lifecycle hook: unmounted");
        },
    }
</script>

<style scoped>

.card {
  position: relative;
  max-width : 300px;
  height : 215px;  
  background-color : #fff;
  margin : 30px 10px;
  padding : 20px 15px;
  border-radius: 25px;
  display : flex;
  flex-direction : column;
  box-shadow : 0 5px 20px rgba(0,0,0,0.5);
  transition : 0.3s ease-in-out;
  border-radius : 15px;
}
.card:hover {
  height : 320px;    
}
.card .image {
  position : relative;
  width : 260px;
  height : 260px;
  border-radius: 25px;
  top : -40%;
  box-shadow : 0 5px 20px rgba(0,0,0,0.2);
  z-index : 1;
}
.card .image image {
    justify-content: center;
    max-width : 100%;
}
.card .content {
  position : absolute;
  top : 140px;
  padding : 10px 15px;
  color : #111;
  text-align : center;
  border-radius: 25px;
  visibility : hidden;
  opacity : 0;
  transition : 0.3s ease-in-out;
  z-index: 2;
    
}
.card:hover .content {
   margin-top : 30px;
   visibility : visible;
   opacity : 1;
   transition-delay: 0.3s;
  
}
</style>