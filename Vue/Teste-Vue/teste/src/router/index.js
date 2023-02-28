import {createRouter, createWebHistory} from 'vue-router'
import ContactList from '../components/ContactList.vue'




const routes = [
    {path:'/', name:'Home', component: ContactList },
    {path:'/details/:id', name:'Details', component: ()=> import('../components/ContactDetail.vue') },
    {path: '/details/', name:'GeneralDetails', component: import('../components/ContactDetails.vue') },
]


const router = createRouter({
    history:createWebHistory(),
    routes
})

export default router