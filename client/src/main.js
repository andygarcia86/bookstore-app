import Vue from 'vue'
import App from './App.vue'
import vueRouter from 'vue-router'

import Landing from './pages/landing.vue'
import Authors from './pages/authors.vue'
import Books from './pages/books.vue'
import VueRouter from 'vue-router';

Vue.use(vueRouter)

const routes = [
  { path: "/", component: Landing},
  { path: "/authors", component: Authors},
  { path: "/books", component: Books}
]

const router = new VueRouter({routes, mode: 'history'})

Vue.config.productionTip = false

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
