var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Teacher/GetAll"
        },
        "columns": [
            { "data": "firstName", "width": "15%" },
            { "data": "lastName", "width": "15%" },
            { "data": "grades", "width": "15%" },
             {
                "data": "id",
                "render": function (data) {
                    return `

                    <div class="w-75 btn-group" role="group">
                    <a href="/Teacher/Upsert?id=${data}"
                    class="btn btn-primary mx-2"> <i class="bi bi-pencil"></i>Edit</a>
                    
                            `
                },
                "width": "15%"
            }
        ]
    });
}
