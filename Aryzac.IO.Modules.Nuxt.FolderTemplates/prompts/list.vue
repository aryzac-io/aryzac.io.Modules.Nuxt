<script setup>
const props = defineProps({
    items: {
        type: Array,
        default: () => []
    }
})

// Navigate to the given URL
const navigate = async (e) => {
    await navigateTo(`/prompts/${e.item.id}`);
}
</script>

<template>
    <ui-view-list :items="items"
                  @item-clicked="navigate">
        <template #default="{ item, index }">
            <div class="min-w-0 flex-auto">
                <div class="flex items-start gap-x-3">
                    <p class="text-sm font-semibold leading-6 text-gray-900">{{
                        item.name }}</p>
                </div>
                <div
                     class="mt-1 flex items-center gap-x-2 text-xs leading-5 text-gray-500">
                    <p class="whitespace-nowrap">{{ item.description }}</p>
                </div>
            </div>
            <div class="flex flex-none items-center gap-x-4">
                <!-- Chevron Right Icon -->
                <icon name="heroicons:chevron-right-20-solid"
                      class="h-5 w-5 flex-none text-gray-400"
                      aria-hidden="true" />
            </div>
        </template>
    </ui-view-list>
</template> 