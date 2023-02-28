<template>
    <div>
        <h3>Total Users Clicked</h3>
        <p class="counter-number">{{counter}}</p>
    </div>
</template>

<script>
    export default {
        props: ['counter']
    }

</script>

<style lang="scss" scoped>
    .counter-number{
        font-size: xx-large;
    }

</style>