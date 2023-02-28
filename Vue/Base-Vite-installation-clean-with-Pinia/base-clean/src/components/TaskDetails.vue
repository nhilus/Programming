<template>
    <div class="task">
        <input v-model = task.title type="text" :disabled="task.disabled">
        <RouterLink :to="{name: 'Details', params:{id: task.id}}">
        <button>Detalhes</button>
        </RouterLink>
    </div>
</template>

<script>
import { useTaskStore } from '../stores/TaskStore';
import {ref} from 'vue'
import {RouterLink} from 'vue-router'

    export default {
        props:['task'],

        setup(){
            const taskStore = useTaskStore()

            return {taskStore}
        }

    }
</script>

<style scoped>


.disable{
   cursor: not-allowed;
   pointer-events: none;
   color:red;
}

.isActive{
    color:goldenrod;
}

.material-symbols-outlined { font-size: 24px; }


</style>