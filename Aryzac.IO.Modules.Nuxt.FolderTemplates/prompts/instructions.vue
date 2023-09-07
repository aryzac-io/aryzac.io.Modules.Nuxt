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
    <ui-editor-section title="Prompt"
                       description="The prompt for the AI assistant">

        <ui-input-textarea v-model="prompt.instructions"
                           label="Instruction"
                           name="instruction"
                           id="instruction" />

        <template #actions>
            <button type="button"
                    class="text-sm font-semibold leading-6 text-gray-900">Cancel</button>
            <button type="button"
                    @click="prompts.changeInstruction($route.params.id, prompt.instructions)"
                    class="rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600">Save</button>
        </template>

    </ui-editor-section>
</template>