import Vue from 'vue'
import App from './App.vue'
import vueRouter from 'vue-router'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'

// Import Bootstrap an BootstrapVue CSS files (order is important)
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

//Register components
import Landing from './pages/landing.vue'
import Authors from './pages/authors.vue'
import Books from './pages/books.vue'
import VueRouter from 'vue-router';

Vue.use(vueRouter)
Vue.use(BootstrapVue)
Vue.use(IconsPlugin)

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
