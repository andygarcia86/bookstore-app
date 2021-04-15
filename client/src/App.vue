<template>
  <div id="app">
    <!-- Menu -->
    <ul>
      <li>Books</li>
      <li>Authors</li>
    </ul>

    <v-content>
      <router-view />
    </v-content>
  </div>
</template>

<script>
//import Landing from './pages/landing.vue'

export default {
  name: 'App',
  components: {
    //Landing
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
