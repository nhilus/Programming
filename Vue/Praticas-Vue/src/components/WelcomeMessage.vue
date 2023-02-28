<template>
    <div>
       <p> Good {{DisplayMessageText}}, {{myName}}!</p>
    </div>
    <NameChange @change-name="ChangeName($event)" ></NameChange>
</template>



<script>
import NameChange from './NameChange.vue'
    export default {
    name: "WelcomeMessageVue",
    props: {},
    data() {
        return {
            myName: "Barbosa",
            hours: 0,
        };
    },
    methods: {
        ChangeName($event) {
            this.myName = $event;
        }
    },
    computed: {
        DisplayMessageText() {
            if (this.hours <= 12 && this.hours >= 5) return "Morning";
            if (this.hours <= 18) return " Afternoon";
            return "Evening";
        },
    },
    beforeMount() {
        const d = new Date();
        return this.hours = parseInt(d.getHours());
    },
    components: { NameChange }
}
</script>

<style lang="scss" scoped>

</style>