<template>
  <div class="container">
    <div class="row">
      <div class="col-md-3">
        <nav-menu></nav-menu>
      </div>
      <div class="col-md-9 col-md-offset-3">
        <router-view />
      </div>
    </div>
  </div>
</template>

<script>
    import NavMenu from './components/NavMenu.vue'

export default {
  name: 'App',
  components: {
      NavMenu
  }
}
</script>

<style>
@import './styles.css';

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
