import Vue from 'vue'
import vueRouter from 'vue-router';
import VueRouter from 'vue-router';

//Register components
import Landing from '../pages/landing.vue'
import Authors from '../pages/authors.vue'
import Books from '../pages/books.vue'

Vue.use(vueRouter)

const routes = [
    { 
        path: "/", 
        name: 'Landing',
        component: Landing,
        props: true
    },
    { 
        path: "/authors", 
        name: 'Authors',
        component: Authors,
        props: true
    },
    { 
        path: "/books", 
        name: 'Books',
        component: Books,
        props: true
    }
  ]

const router = new VueRouter({routes, mode: 'history'})

export default router
