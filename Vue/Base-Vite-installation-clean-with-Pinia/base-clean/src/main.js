import { createApp } from 'vue'
import { createPinia } from 'pinia'
import './assets/style.css'
import App from './App.vue'
import router from './router/index'

const pinia = createPinia();

pinia.use((context) => {

    const storeId = context.store.$id

    const serializer = {
        serialize: JSON.stringify,
        deserialize:JSON.parse
    }
    
    const fromStorage = serializer.deserialize(window.localStorage.getItem(storeId))
    if(fromStorage){
        context.store.$patch(fromStorage)
    }

    context.store.$subscribe((mutations, state) =>{
        window.localStorage.setItem(storeId, serializer.serialize(state))
    })
})


const app = createApp(App)

app.use(pinia)
app.use(router)
app.mount('#app')
