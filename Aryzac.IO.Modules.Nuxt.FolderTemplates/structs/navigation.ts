import { RouteLocationRaw } from 'vue-router';

interface Item {
    id: string | number,
    name: string,
    to: RouteLocationRaw,
    icon?: string
}

interface Section {
    id: string | number,
    title?: string,
    component: string,
    items?: Item[]
}

export { Item, Section }