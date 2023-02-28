<template>
    <div>
        <li>
            <p class="todoitem">{{todo.description}}</p>
            <input type="checkbox" v-model="todo.todoDone" @change="boxWasChecked" >
        </li>
    </div>
</template>

<script>
    export default {
        name: "todoitem",
        props:{
            todo:{
                type: Object,
            },
        },
        data(){
            return{

            }
        },
        methods:{
            boxWasChecked(){
                this.$emit("box-was-checked", this.todoDone);
            }
        },
        emits:[
            "box-was-checked"
        ],

    }
</script>

<style scoped>
    li{
        display: flex;
        justify-content: space-between;
        box-sizing: border-box;
        width: 100%;
    }  
</style>