<template>
    <div>
    <p>Change User: </p>
    <input type="text" v-model="changedName" placeholder="Write new user name" @keypress.enter="SubmitNewName">
    <button @click="SubmitNewName">Submit</button>
    </div>
</template>

<script>

    export default {

        props: [],

        data(){
            return{
                changedName:'' 
            }
        },

        methods:{
            SubmitNewName(){
                console.log('name was changed', this.changedName)
                this.$emit("change-name", this.changedName);
            }
        },

        emits:[
            "change-name"
        ], 


    }
</script>

<style lang="scss" scoped>

</style>