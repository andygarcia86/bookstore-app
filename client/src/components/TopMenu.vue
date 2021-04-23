<template>
  <b-nav>
    <b-nav-item active>
      <router-link to="/">Home</router-link>
    </b-nav-item>
    <b-nav-item active>
      <router-link to="/books">Books</router-link>
    </b-nav-item>
    <b-nav-item>
      <router-link to="/authors">Authors</router-link>
    </b-nav-item>
  </b-nav>
</template>

<script>
export default {
  name: 'TopMenu'  
}
</script>
