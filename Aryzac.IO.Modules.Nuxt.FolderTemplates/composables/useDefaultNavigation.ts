import { Item } from '~/structs/navigation';

const defaultMainNavItems = ref<Item[]>([
    {
        id: 1,
        name: 'Home',
        to: '/',
        icon: 'heroicons:home',
    },
]);

export default function useDefaultNavigation() {
    const { addSection, clearAllSections } = useNavigation();

    clearAllSections();

    addSection({
        id: 'main',
        component: 'navigation',
        items: defaultMainNavItems.value,
    });
}
