<template>
<div class="content">
    <div v-if="this.image" class="card">
        <img :src=this.image class="image" alt="...">
        <div class="content" :style="cssVars">
            <h5 class="card-title">{{firstName}} {{lastName}}</h5>
        </div>
    </div>
</div>
</template>

<script>  
    export default {
        components:{
        },
        props:{
            user: Object,
        },
        data() {
            return {
                image: '',
                firstName: '',
                lastName: '',
            }
        },

        methods:{
            getUserData(){
                this.image = this.user.picture.large;
                this.firstName = this.user.name.first;
                this.lastName = this.user.name.last;
            },
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
    .content{
        display: flex;
        justify-content: center;
    }
    .card-title{
        color: black;
    }

</style>