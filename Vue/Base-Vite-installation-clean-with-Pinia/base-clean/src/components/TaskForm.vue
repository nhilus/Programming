<template>
    <form @submit.prevent="handleSubmit">
        <input 
        type="text"
        placeholder="add new task"
        v-model="newTask"
        >
        <button>Adicionar Tarefa</button>
    </form>
</template>

<script>
import { ref } from 'vue';
import { useTaskStore } from '../stores/TaskStore';

    export default {

        setup(){
            const taskStore= useTaskStore()

            const newTask = ref('')

            const handleSubmit = () => {
                if(newTask.value.length > 0){
                    taskStore.addTask({
                        title: newTask.value,
                        isComp: false,
                        id: Math.floor(Math.random() * 10000),
                        disabled: true,
                    })
                    newTask.value=''
                }
            }

            return {handleSubmit, newTask}

        },

    }
</script>