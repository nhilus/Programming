<template>
    <div>
        <header>
            <h1>Exercício Revisões</h1>
        </header>

        <div class="task">
        <input v-model = task.title type="text" :disabled="task.disabled">
        <div class="icons">
        <i 
            class="material-symbols-outlined"

            :class="{ isActive: !task.disabled}"
            @click="task.disabled = !task.disabled"
        >edit</i>
        <i 
            class="material-symbols-outlined"
            :class="{ disable: task.isComp}"
            id="delete"
            @click="deleteTask(task.id)"
        >delete</i>
        <i 
        class="material-symbols-outlined"
        :class="{active:task.isComp}"
        @click="toggleComplete(task.id)"
        >check_circle</i>
        </div>
        </div>
        <RouterLink :to="{name: 'Home'}">
        <button>Voltar</button>
        </RouterLink>


    </div>
</template>

<script>
import { mapActions } from 'pinia';
import { useTaskStore } from '../stores/TaskStore';
import {RouterLink} from 'vue-router'

    export default {

        data(){
            return{
                task: this.getTask(this.$route.params.id)
            }
        },
        
        methods:{
            ...mapActions(useTaskStore, ["getTask", "toggleComplete", "deleteTask"])
        },

        computed:{
            
        }

        
    }
</script>

<style scoped>
.task{
    width:640px;
    margin:10px auto;
    text-align: right;
}

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