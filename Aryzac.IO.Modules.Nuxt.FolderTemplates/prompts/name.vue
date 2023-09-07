<script setup lang="ts">
const props = defineProps({
    prompt: {
        type: Object,
        required: true
    }
});

const prompts = usePrompts();
</script>

<template>
    <ui-editor-section title="Prompt Name"
                       description="The name and description for the prompt.">

        <ui-input-textbox v-model="prompt.name"
                          label="Name"
                          name="name"
                          id="name" />

        <ui-input-textarea v-model="prompt.description"
                           label="Description"
                           name="description"
                           id="description" />

        <template #actions>
            <button type="button"
                    class="text-sm font-semibold leading-6 text-gray-900">Cancel</button>
            <button type="button"
                    @click="prompts.changeNameAndDescription($route.params.id, prompt.name, prompt.description)"
                    class="rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600">Save</button>
        </template>

    </ui-editor-section>
</template>