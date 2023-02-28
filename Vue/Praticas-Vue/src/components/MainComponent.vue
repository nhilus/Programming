<template>
  <div class="mainContainer">
  <nav>
  <toggle-button-vue></toggle-button-vue>
  </nav>
    <div>
        <change-u-i-button-vue :text="'Welcome Message'" @click="activeTab='WelcomeMessageVue'" />
        <change-u-i-button-vue :text="'TextBox'"  @click="activeTab='TextBoxVue'" />
        <change-u-i-button-vue :text="'User Grid'"  @click="activeTab='UserGrid'" />
        <change-u-i-button-vue :text="'Todo List'" @click="activeTab='TodoList'" />
        <change-u-i-button-vue :text="'Form'" @click="activeTab='UserForm'" />
    </div>
    <keep-alive>
          <component :is="activeTab"/>
    </keep-alive>
  </div>
</template>


<script>
import WelcomeMessageVue from './WelcomeMessage.vue';
import TextBoxVue from './TextBox.vue';
import ChangeUIButtonVue from './ChangeUIButton.vue';
import ToggleButtonVue from './ToggleButton.vue';
import TodoList from './TodoList.vue';
import UserGrid from './UserGrid.vue';
import UserForm from './UserForm.vue';

  export default {
      components: {
        WelcomeMessageVue,
        TextBoxVue,
        ChangeUIButtonVue,
        ToggleButtonVue,
        TodoList,
        UserGrid,
        UserForm,
      },

      name: 'MainComponent',
      data(){
        return{
          activeTab: '',
        }
      },

      methods: {
      }
  }
  
  </script>
  
  
<style scoped>

</style>