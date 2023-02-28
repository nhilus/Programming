import {createRouter, createWebHistory} from 'vue-router'

import Home from '../views/Home.vue'

const routes = [
    { path:'/',component: Home},
    { path:'/about', component: () =>import ('../views/About.vue')},
    { path:'/myself/:name/:age', component: () =>import ('../views/Myself.vue')},
    { path:'/maincomponent', component: () =>import ('../components/MainComponent.vue')},
]


const router = createRouter({
    history:createWebHistory(),
    routes
})

export default router