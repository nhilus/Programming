<template>
    <form @submit.prevent="handleSubmit">
        <div class="form-group">
                    <label for="name">Name:</label>
                    <input type="text" id="name" v-model="newContact.name">
                </div>

                <div class="form-group">
                    <label for="phoneNumber">Phone Number:</label>
                    <input type="text" id="phoneNumber" v-model="newContact.phoneNumber">
                </div>

                <div class="form-group">
                    <label for="email">Email:</label>
                    <input type="email" id="email" v-model="newContact.email">
                </div>
                <div class="form-group">
                    <label for="address">Address:</label>
                    <input type="text" id="address" v-model="newContact.address">
                </div>
        <button>Adicionar Contacto</button>
    </form>
</template>

<script>
import { ref, reactive} from 'vue';
import { useContactStore } from '../stores/ContactStore';

    export default {

        methods: {
            resetForm(){
                    newContact.name = ''
                    newContact.phoneNumber=''
                    newContact.email=''
                    newContact.address=''
            },
        },

        setup(){
            const contactStore= useContactStore()

            const newContact = reactive({
                name: "",
                email: "",
                telephone: "",
                address: "",
            });

            // const getInitialFormData = () => ({ name: "", phoneNumber: "", email: "", address: ""});

            // const newContact = reactive(getInitialFormData());

            // const resetUserForm = () => Object.assign(contactForm, getInitialFormData());

            const handleSubmit = () => {
                console.log(newContact)
                contactStore.addContact({
                    name: newContact.name,
                    phoneNumber: newContact.phoneNumber,
                    email: newContact.email,
                    address: newContact.address,
                    disabled:true,
                    id: Math.floor(Math.random() * 10000),
                })
                newContact.name=''
                newContact.phoneNumber=''
                newContact.email=''
                newContact.address=''
            }

            return {handleSubmit, newContact}

        },

    }
</script>