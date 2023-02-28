<template>
    <div>
    <h2>Todo List</h2>
    <div>
        <p>Add Todo: </p>
        <input type="text" v-model="newTodo" placeholder="Add new Todo to do" @keypress.enter="SubmitNewTodo">
        <button @click="SubmitNewTodo">Submit</button>
    </div>
    <ul>
        <TodoItem 
        v-for="(todo, i) in todos"
        :todo="todo" 
        :key="i"
        @box-was-checked="boxWasChecked($event)"/>  
    </ul>
    </div>
</template>

<script>
import TodoItem from './TodoItem.vue';

    export default {
    name:"TodoList",
    components: { TodoItem },
    data(){
        return{
            newTodo:'',
            todos:[
                {description: "clean the house", todoDone:false},
                {description: "clean the car", todoDone:false},
                {description: "work on stuff", todoDone:false},
                {description: "work on more stuff", todoDone:false},
                {description: "work some more", todoDone:false},
                {description: "chill", todoDone:false},
            ]

        }
    },
    methods:{
        SubmitNewTodo(){
            this.todos.push({description: this.newTodo, todoDone:false});
        },
        boxWasChecked(){
            console.log("todo was checked")
        }
    },
    emits:[
        "add-todo"
    ]

}
</script>

<style scoped>
    ul{
        display: flex;
        flex-direction: column;
    }

</style>