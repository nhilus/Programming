<template>
    <section>
        <div class="container">
            <form @submit.prevent="submitForm($event)">
                <div class="form-group">
                    <label for="name">Name:</label>
                    <input type="text" id="name" v-model="userList.name">
                </div>

                <div class="form-group">
                    <label for="phoneNumber">PhoneNumber:</label>
                    <input type="text" id="phoneNumber" v-model="userList.phoneNumber">
                </div>

                <div class="form-group">
                    <label for="email">Email:</label>
                    <input type="email" id="email" v-model="userList.email">
                </div>

                <div class="form-group">
                    <label for="message">Message:</label>
                    <textarea id="message"  rows="5" v-model="userList.message" ></textarea>
                </div>
                <div class="form-goup">
                    <label for="image">Upload Image</label>
                    <input  style="display:none" 
                            type="file" 
                            @change="onFileSelected($event)"
                            ref="fileInput">
                    <button type="button" id="filePicker" @click="$refs.fileInput.click()">Pick File</button>
                    <button type="button" id="uploader" @click="onUpload">Upload</button>
                </div>
                <button type="submit">Submit</button>
            </form>
        </div>
    </section>
    <section>
        <div>
            <UserFormList/>
        </div>
    </section>
</template>

<script>
import UserFormList from './UserFormList.vue';
import {useUserListStore} from '../store/UserData';
import { mapActions, mapWritableState } from 'pinia'

    export default {

    components: { UserFormList },
    props:{
    },
    name: "UserFormData",
    data() {
            return {
                selectedFile: null,
                errors:[],

            }
        },


    methods:{
        ...mapActions(useUserListStore, ['addUserToList']),

        validateEmail() {
            if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(this.newUser.email)) {
                this.msg['email'] = 'Please enter a valid email address';
            } else {
                this.msg['email'] = '';
            }
        },


        validatePhoneNumber() {
            const validationRegex = /^\d{9}$/;
            if (this.newUser.phoneNumber.match(validationRegex)) {
                this.isValidPhoneNumber = true;
            } else {
                this.isValidPhoneNumber = false;
            }
        },

        onFileSelected(event){
            const files = event.target.files
            if (!files.length) return

            const reader = new FileReader()
            reader.readAsDataURL(files[0])
            reader.onload = () => (this.selectedFile = reader.result)
        },

        onUpload(){
            this.userList.image = this.selectedFile
            console.log(this.userList.image)
        },

        submitForm(event){
            this.addUserToList(this.userList)
            
        },
    },

    computed: {
        ...mapWritableState(useUserListStore, ['userList']),
    },
}


</script>



<style scoped>

    section {
    height: 100vh;
    display: flex;
    justify-content: center;
    flex-direction: column;
    }
    .container {
    width: 90%;
    max-width: 500px;
    margin: 0 auto;
    padding: 20px;
    box-shadow: 0px 0px 20px #00000033;
    border-radius: 8px;
    }
    .form-group {
    margin-top: 20px;
    font-size: 20px;
    color: #9e9e9e;
    }
    .form-group input,
    .form-group textarea {
    width: 100%;
    padding: 5px;
    font-size: 18px;
    border: 1px solid rgba(128, 128, 128, 0.199);
    margin-top: 5px;
    }
    textarea {
    resize: vertical;
    }
    button {
    width: 100%;
    border: none;
    padding: 20px;
    font-size: 24px;
    border-radius: 8px;
    cursor: pointer;
    margin-top: 10px;
    }
</style>