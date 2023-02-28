<template>
    <div class="task">
        <input v-model = contact.name type="text" disabled="true">
        <RouterLink :to="{name: 'Details', params:{id: contact.id}}">
            <button>Detalhes</button>
        </RouterLink>
    </div>
</template>

<script>
import { useContactStore } from '../stores/ContactStore';
import {ref} from 'vue'
import {RouterLink} from 'vue-router'

    export default {
        props:['contact'],

        setup(){
            const contactStore = useContactStore()

            return {contactStore}
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