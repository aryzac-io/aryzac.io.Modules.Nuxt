<template>
  <div class="flex min-h-screen">
    <layout-sidebar />

    <div class="flex flex-col flex-1 lg:pl-72">
      <layout-appbar />

      <div class="flex-1 w-full h-full">
        <!-- Your content -->
        <slot />
      </div>
    </div>
  </div>
</template>
