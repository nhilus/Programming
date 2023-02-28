<script>
  import MainComponentVue from './components/MainComponent.vue'
  import {RouterView, RouterLink} from 'vue-router'
  import MainComponent from './components/MainComponent.vue';


  export default {
    components: {
    MainComponentVue,
    RouterLink,
    RouterView,
    MainComponent
},
  }

</script>

<template>
  <nav id="navbar">
  <button>
    <router-link to="/" class="link">Go to Home</router-link>
  </button>
  <button>
    <router-link to="/myself/:name/:age" class="link"> Go to About</router-link>
  </button>
  <button>
    <router-link to="/maincomponent" class="link"> Go to Main</router-link>
  </button>
  </nav>
  <router-view />
</template>

<style> 
  .link{
    gap: 20px;
    margin: 20px;
    border: 3px;
    border-color: goldenrod;
    color:white;

  }


</style>

