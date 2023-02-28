<template>
        <ul class="ul-elem">
            <li v-for="(user,idx) in userList"
                :user="user" :key="idx"
                style="list-style: none">
                <div style="display:flex; justify-content:space-between">
                    <p>{{user.name.first}} {{user.name.last}}</p>
                    <button @click="deleteLine(idx)" class="btn-close" aria-label="Close" style="justify-content:space-between"></button>
                </div>
            </li>
        </ul>
</template>

<script>
    export default {
        
    }
</script>

<style lang="scss" scoped>

</style>