<template>
<main class="content">
<header>
    <h1>Gestão Contactos</h1>
</header>
    <div>
    <ContactForm></ContactForm>
    </div>

    <div class="task-list" v-if="this.filter === 'all'">
        <p>Tens {{contactStore.totalCount}} Contactos</p>
        <div v-for= "contact in contactStore.contacts">
        <ContactDetails :contact = "contact" />
        </div>
    </div>
</main>

</template>
  
<script>
import ContactDetails from '../components/ContactDetails.vue'
import { useContactStore } from '../stores/ContactStore'
import { ref } from 'vue'
import ContactForm from '../components/ContactForm.vue'

export default {
    components:{ ContactDetails, ContactForm },
    setup(){
        const contactStore = useContactStore()
        const filter = ref('all')
        return {contactStore, filter }
    },
}
  
</script>

<style>
</style>