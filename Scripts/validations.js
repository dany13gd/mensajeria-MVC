(function () {
    var loc = window.location.pathname;
    if (loc === '/contactos/Create' || loc.includes('/contactos/Edit')) {
        $('form').on('submit', (e) => {
            if ($('#nombre').val() === '' || $('#email').val() === '' || $('#tel_movil').val() === '') {
                e.preventDefault();
                alert('Nombre, email y tel móvil son requeridos');
            }
        });
    }
})();
