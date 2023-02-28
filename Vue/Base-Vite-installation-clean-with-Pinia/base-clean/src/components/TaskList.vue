<template>
  <main class="content">
  <header>
    <h1>Exercício Revisões</h1>
  </header>
    <nav class="filter" style="align-content: center ;">
      <button @click="filter='all'">Todas as tarefas</button>
      <button @click="filter='isCompleted'">Completas</button>
      <button @click="filter='isIncomplete'">Incompletas</button>
    </nav>
    <div>
    <TaskForm></TaskForm>
    </div>

      <div class="task-list" v-if="this.filter === 'all'">
        <p>Todas as tarefas</p>
        <p>Tens {{taskStore.totalCount}} tarefas no total</p>
        <div v-for= "task in taskStore.tasks">
          <TaskDetails :task = "task" />
        </div>
      </div>

      <div class="task-list" v-if="this.filter === 'isCompleted'">
        <p>Completas</p>
        <p>Tens {{taskStore.CompletedCount}} tarefas completas</p>
        <div v-for= "task in taskStore.isCompleted" >
          <TaskDetails :task = "task" />
        </div>
      </div>

      <div class="task-list" v-if="this.filter === 'isIncomplete'">
        <p>Incompletas</p>
        <p>Tens {{taskStore.IncompleteCount}} tarefas incompletas</p>
        <div v-for= "task in taskStore.isIncomplete" >
          <TaskDetails :task = "task" />
        </div>
      </div>
    
  </main>

</template>

<script>
  import TaskDetails from './TaskDetails.vue'
  import { useTaskStore } from '../stores/TaskStore'
  import { ref } from 'vue'
  import TaskForm from '../components/TaskForm.vue'

  export default {
    components:{ TaskDetails, TaskForm },
    setup(){
      const taskStore = useTaskStore()
      const filter = ref('all')
      return {taskStore, filter }
    },
  }

</script>
  
  
  
  <style>


  
  </style>