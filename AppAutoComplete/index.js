$(function () {
    var indexFn = {
        init: function () {
            $('#txtfiltro').on('keyup', indexFn.txtBind);
        },
        txtBind: function () {
            if ($(this).val().length > 2) {
                indexFn.Alumnos($(this).val());
            }
        },
        Alumnos: function (filtro) {
            $.ajax({
                type: "Get",
                url: "Api/Alumno/nombre",
                data: { "filtro": filtro },
                contentType: "application/json; charset=utf-8"
            }).done(function (data) {
                horsey($('#txtfiltro')[0], {
                    source: [{
                        list: data
                    }],
                    getText: 'Text',
                    getValue: 'Value',
                    limit: 2
                });
            });
        }
    };

    indexFn.init();
});