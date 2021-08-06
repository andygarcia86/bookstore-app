<template>
  <div class="container"> 
    <h1>Authors</h1>
    <b-button>Add author</b-button>
    <b-table striped hover :items="authors" :fields="fields"></b-table>    
    <b-pagination
      v-model="currentPage"
      :total-rows="rows"
      :per-page="perPage"
      first-text="First"
      prev-text="Prev"
      next-text="Next"
      last-text="Last"
    ></b-pagination>
  </div>
</template>

<script>

export default {
  name: 'Authors',
  data() {
    return {
      fields: [
         { key: 'full_name', label: 'Fullname'} ,
         { key: 'books', label: 'Books' }
      ],
      authors: [
        { full_name: 'Tony Robbings', books: 7 },
        { full_name: 'Jhon Doe', books: 2 },
        { full_name: 'Bill Gates', books: 5 },
        { full_name: 'Robert Martin', books: 3 }
      ],
      currentPage: 1,
      rows: 214,
      perPage: 10
    }
  }
}
</script>

<style scoped>

</style>
