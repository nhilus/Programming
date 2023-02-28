<template>
    <div>
        <div>
        <p>Insert text in the box :</p>
        <h3>{{sumsum}}</h3>
        <input type="text" v-model="sumsum" placeholder="Write sumsum">
    </div>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                sumsum: ''
            }
        },
    }
</script>

<style lang="scss" scoped>

</style>