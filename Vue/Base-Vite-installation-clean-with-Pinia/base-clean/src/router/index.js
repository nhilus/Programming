import {createRouter, createWebHistory} from 'vue-router'
import TaskList from '../components/TaskList.vue'



const routes = [
    {path:'/', name:'Home', component: TaskList },
    {path:'/details/:id', name:'Details', component: ()=> import('../components/TaskDetail.vue') },
]


const router = createRouter({
    history:createWebHistory(),
    routes
})

export default router