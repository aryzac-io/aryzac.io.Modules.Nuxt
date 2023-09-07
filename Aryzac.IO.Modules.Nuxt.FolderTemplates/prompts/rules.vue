<script setup lang="ts">
const props = defineProps({
    prompt: {
        type: Object,
        required: true
    }
});

const route = useRoute();
const prompts = usePrompts();

const updatePromptRules = async () => {
    for (let i = 0; i < props.prompt.promptRules.length; i++) {
        const rule = props.prompt.promptRules[i];

        if (rule.id && !rule.deleted) {
            continue;
        }

        if (rule.deleted) {
            await prompts.deleteRule(route.params.id, rule.id);
            continue;
        }

        await prompts.addRule(route.params.id, rule.rule);
        rule.id = `saved-${i}`;
    }
}

const deleteRule = (rule) => {
    if (rule.id) {
        rule.deleted = true;
    }
    else {
        const index = props.prompt.promptRules.indexOf(rule);
        props.prompt.promptRules.splice(index, 1);
    }
}

const addRule = (rule) => {
    props.prompt.promptRules.push({ rule });
}
</script>

<template>
    <ui-editor-section title="Rules"
                       description="The rules for the AI assistant">

        <ui-input-post :show-title="false"
                       description-placeholder="Write a prompt rule..."
                       create-button-text="Add Rule"
                       @create="addRule($event.description)" />

        <ui-view-list :items="prompt.promptRules">
            <template #default="{ item, index }">
                <div class="min-w-0 flex-auto">
                    <div class="flex items-start gap-x-3">
                        <p class="text-sm font-semibold leading-6 text-gray-900"
                           :class="{ 'text-amber-500': !item.id, 'text-red-500': item.deleted }">
                            {{ item.rule }}
                        </p>
                    </div>
                </div>
                <div class="flex flex-none items-center gap-x-4">
                    <!-- Chevron Right Icon -->
                    <icon name="heroicons:trash-20-solid"
                          @click="deleteRule(item)"
                          class="h-5 w-5 flex-none text-red-400"
                          aria-hidden="true" />
                </div>
            </template>
        </ui-view-list>

        <template #actions>
            <button type="button"
                    class="text-sm font-semibold leading-6 text-gray-900">Cancel</button>
            <button type="button"
                    @click="updatePromptRules"
                    class="rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600">Save</button>
        </template>

    </ui-editor-section>
</template>