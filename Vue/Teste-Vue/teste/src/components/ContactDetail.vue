<template>
    <div>
        <header>
            <h1>Gestão Contactos</h1>
        </header>

        <div class="task" style="display:flex; flex-direction: column ;">
        <input v-model = contact.name type="text" :disabled="contact.disabled">
        <input v-model = contact.phoneNumber type="text" :disabled="contact.disabled">
        <input v-model = contact.email type="text" :disabled="contact.disabled">
        <input v-model = contact.address type="text" :disabled="contact.disabled">
        <div class="icons">
        <i 
            class="material-symbols-outlined"

            :class="{ isActive: !contact.disabled}"
            @click="contact.disabled = !contact.disabled"
        >edit</i>
        <i 
            class="material-symbols-outlined"
            id="delete"
            @click="this.deleteContact(contact.id)"
        >delete</i>
        </div>
        </div>
        <RouterLink :to="{name: 'Home'}">
        <button>Voltar</button>
        </RouterLink>


    </div>
</template>

<script>
import { mapActions } from 'pinia';
import { useContactStore } from '../stores/ContactStore';
import {RouterLink} from 'vue-router'

    export default {

        data(){
            return{
                contact: this.getContact(this.$route.params.id)
            }
        },
        
        methods:{
            ...mapActions(useContactStore, ["getContact", "deleteContact"]),

            deleteContactFromList(){
                this.deleteContact(contact.id) //not working as intended
            }
        },

        
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