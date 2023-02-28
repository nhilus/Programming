<template>
    <div class="mode-toggle" @click="modeToggle" :class="darkDark">
        <div class="toggle">
            <div id="dark-mode" type="checkbox"></div>
        </div>
    </div>
</template>

<script>
    export default {
        methods: {

        data() {
            return {
                darkMode: false
                }
        },
        dark() {
            document.querySelector('body').classList.add('dark-mode')
            this.darkMode = true
            this.$emit('dark')
        },

        light() {
            document.querySelector('body').classList.remove('dark-mode')
            this.darkMode = false
            this.$emit('light')
        },

        modeToggle() {
            (this.darkMode || document.querySelector('body').classList.contains('dark-mode')) ? this.light() : this.dark();
        },
    },
    
    computed: {
        darkDark() {
            return this.darkMode && 'darkmode-toggled'
        }
    }
    }
        
</script>

<style lang="scss" >
$dark: #171717;
$mode-toggle-bg: #262626;

body {
    background-color: #fff;
    color: $dark;
    transition: background-color .9s ease, color .9s ease;
    font-style: $dark;
    & .card{
        box-shadow : 0 5px 20px rgba(0,0,0,0.5);
        transition: background-color .9s ease;
        transition : 0.3s ease-in-out;
    }
    & button{
        background-color: #a5abba;
        transition: background-color .9s ease;
    }
}


body {
    &.dark-mode {
        background-color: lighten($dark, 5%);
        color:#fff;
    }
    &.dark-mode .card{
        box-shadow : 0 5px 20px goldenrod;
        transition: background-color .9s ease;
        transition : 0.3s ease-in-out;
    }
    &.dark-mode button{
        background-color: goldenrod;
        transition: background-color .9s ease;
        
    }
}

// _mode-toggle.scss
.mode-toggle {
    position: relative;
    margin: auto .5rem .5rem auto;
    padding: 0;
    width: 44px;
    height: 24px;
    min-width: 36px;
    min-height: 20px;
    background-color: $mode-toggle-bg;
    border: 0;
    border-radius: 24px;
    outline: 0;
    overflow: hidden;
    cursor: pointer;
    z-index: 2;
    -webkit-tap-highlight-color: rgba(0,0,0,0);
    -webkit-touch-callout: none;
    appearance: none;
    transition: background-color .9s ease;

    .toggle {
        position: absolute;
        top: 0;
        left: 0;
        bottom: 0;
        margin: auto;
        width: 20px;
        height: 20px;
        border-radius: 50%;
        border: 3px solid transparent;
        box-shadow: inset 0 0 0 2px #a5abba;
        overflow: hidden;
        transition: transform .9s ease;

        #dark-mode {
            position: relative;
            width: 100%;
            height: 100%;
            overflow: hidden;
            border-radius: 50%;

            &:before {
                content: '';
                position: relative;
                width: 100%;
                height: 100%;
                left: 50%;
                float: left;
                background-color: #a5abba;
                transition: border-radius .9s ease, width .9s ease, height .9s ease, left .9s ease, transform .9s ease;
            }
        }
    }
}

body.dark-mode {
    .mode-toggle {
        background-color: lighten($mode-toggle-bg, 5%);

        .toggle {
            transform: translateX(19px);

            #dark-mode {
                &:before {
                    border-radius: 50%;
                    width: 150%;
                    height: 85%;
                    left: 40%;
                    transform: translate(-10%, -40%), rotate(-35deg);
                }
            }
        }
    }
}



html {
    font-size: 16px;
}



h1 {
    font-weight: 400;
    transition: color .5s ease;
}

.flex {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    width: 100%;
    height: 100%;
}

</style>