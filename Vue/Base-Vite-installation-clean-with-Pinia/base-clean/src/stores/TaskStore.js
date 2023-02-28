import {defineStore} from 'pinia'


export const useTaskStore = defineStore('taskStore', {
    state:()=>({
        tasks:[],
    }),

    getters:{

        isCompleted() {
            return this.tasks.filter(t => t.isComp)
        },

        isIncomplete() {
            return this.tasks.filter(t => !t.isComp)
        },

        CompletedCount(){
            return this.tasks.reduce( (p, c) => {
                return c.isComp ? p + 1 : p
            },0)
        },

        IncompleteCount(){
            return this.tasks.reduce( (p, c) => {
                return c.isComp ? p : p + 1
            },0)
        },

        totalCount: (state) => {
            return state.tasks.length
        }
    },

    actions:{
        addTask(task) {
            this.tasks.push(task)
           
        },

        deleteTask(id){
            this.tasks = this.tasks.filter(t => {
                return t.id != id
            })
        },

        toggleComplete(id){
            const task = this.tasks.find(t => t.id === id)
            task.isComp = !task.isComp
            
        },

        activateEdit(disabled){
            disabled = !disabled
        },

        canEdit(){
            this.activateEdit()
        },

        getTask(id){
            return this.tasks.find(t => t.id == id)
        }
    }
})