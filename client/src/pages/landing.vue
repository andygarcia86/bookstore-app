<template>
  <div>
    <h1>Landing Page</h1>
    <p>
      Most visited books
    </p>

    <b-container class="bv-example-row">
      <b-row>
        <b-col>
          <book-card/>
        </b-col>
        <b-col>
          <book-card/>
        </b-col>
        <b-col>
          <book-card/>
        </b-col>
      </b-row>
    </b-container>

  </div>
</template>

<script>
import BookCard from '../components/books/BookCard.vue'

export default {
  name: 'Landing',
  components: {
    BookCard
  }
}
</script>

<style scoped>

</style>
