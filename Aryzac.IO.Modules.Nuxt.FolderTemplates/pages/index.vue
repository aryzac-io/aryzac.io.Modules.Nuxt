<script setup lang="ts">
const debug = useDebug();
useDefaultNavigation();
</script>

<template>
  <div class="relative z-0 flex flex-1 h-full overflow-hidden">
    <main
          class="relative z-0 flex-1 overflow-y-auto focus:outline-none xl:order-last">
      <!-- Start main area-->
      <div class="inset-0 h-full px-4 py-6 sm:px-6 lg:px-8">
        <div class="h-full rounded-lg"
             :class="{ 'border-2 border-dashed border-gray-200': debug }" />
      </div>
      <!-- End main area -->
    </main>
  </div>
</template>