<template>
  <b-navbar toggleable="md" type="dark" variant="dark">
    <div class="container">
      <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
      <b-navbar-brand href="#" @click.prevent="route_to('/')">Bookstore</b-navbar-brand>
      <b-collapse is-nav id="nav_collapse">
        <b-navbar-nav>
          <b-nav-item href="#" @click.prevent="route_to('/')">Home</b-nav-item>
          <b-nav-item href="#" @click.prevent="route_to('/books')">Books</b-nav-item>
          <b-nav-item href="#" @click.prevent="route_to('/authors')">Authors</b-nav-item>
          <!-- 
          <b-nav-item-dropdown text="Categories" left>
            <b-dropdown-item href="#" v-for="category in categories" :key="category" @click.prevent="route_to('/categories/'+category)">{{category}}</b-dropdown-item>
          </b-nav-item-dropdown>
          -->
        </b-navbar-nav>

        <!-- Right aligned nav items -->
        <!-- 
        <b-navbar-nav class="ml-auto">
          <b-button variant="primary" @click="checkout" right>
            Checkout <b-badge variant="light">${{purchase}}</b-badge>
          </b-button>
        </b-navbar-nav>
        -->
      </b-collapse>
    </div>
  </b-navbar>
</template>

<script>
export default {
  name: 'TopMenu',
  methods: {
    route_to (path) {
      this.$router.push(path)
    }
  }
}
</script>
