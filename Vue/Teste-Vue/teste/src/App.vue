<template>
  <router-view></router-view>
</template>

<script>
import {RouterView, RouterLink} from 'vue-router'
import ContactList from './components/ContactList.vue';

  export default {
    components: { ContactList,
                  RouterLink,
                  RouterView, }
}

</script>



<style scoped>

</style>
