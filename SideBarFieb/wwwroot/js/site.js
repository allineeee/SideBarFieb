// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    const sidebar = document.getElementById("sidebar");
    const button = document.getElementById("toggleSidebar");
    const root = document.documentElement;

    if (!sidebar || !button) return;

    // Estado inicial do botão
    if (root.classList.contains("sidebar-collapsed")) {
        button.innerHTML = "➡";
    } else {
        button.innerHTML = "⬅ Recolher";
    }

    button.addEventListener("click", function () {
        root.classList.toggle("sidebar-collapsed");

        const collapsed = root.classList.contains("sidebar-collapsed");
        localStorage.setItem("sidebarCollapsed", collapsed);

        button.innerHTML = collapsed ? "➡" : "⬅ Recolher";
    });
});
