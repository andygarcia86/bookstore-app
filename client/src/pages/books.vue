<template>
  <div class="container">
    <h1>Books</h1>
    <b-button>Add Book</b-button>
    <b-table striped hover :items="books" :fields="fields"></b-table>
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
  name: 'Books',
  data() {
    return {
      fields: [
         { key: 'title', label: 'Title'} ,
         { key: 'author', label: 'Author' }
      ],
      books: [
        { title: 'DO ANDROIDS DREAM OF ELECTRIC SHEEP?', author: 'Dickerson Macdonald' },
        { title: 'EVERYTHING I NEVER TOLD YOU', author: 'Larsen Shaw' },
        { title: 'IS EVERYONE HANGING OUT WITHOUT ME? (AND OTHER CONCERNS)', author: 'Geneva Wilson' },
        { title: 'The Electric Kool-Aid Acid Test ', author: 'Jami Carney' }
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
