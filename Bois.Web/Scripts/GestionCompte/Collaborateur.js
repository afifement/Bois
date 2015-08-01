var global_id = 0;
var global_documentid = 0;

$(document).ready(function () {
    getlstCollaborator();
    selectView("summary");
    $(".addition").change(function () { ValidateAddition(); });
    $(".edition").change(function () { ValidateUpdate(); });
    $(".docinput").change(function () { ValidateDoc(); });
    $("button").click(function (e) { ClickHandler(e);  });
     
});

function ClickHandler(e) {

    switch (e.target.id) {

        case "delete": DeleteCollaborator(); getlstCollaborator(); break;
 
        case "add": $('#labErrStep1').hide(); EmptyFormAdd(); $('#AddNew').prop('disabled', true); selectView("add"); break;
             
        case "edit": FillFormEdit(); $('#submitEdit').prop('disabled', false); break; 

        case "submitEdit": UpdateCollaborator(); getlstCollaborator(); selectView("summary"); break; 

        case "AddNew": SaveCollaborator(); getlstCollaborator(); selectView("summary"); break;

        case "Annuler": selectView("summary"); break;
          
        case "btnfileCancel": selectView("collaboratorDocuments"); break;  
 
    }

}

function DeleteCollaborator() {
    $.ajax({ type: "Delete", async: false, url: "/api/AccountManage/DeleteAccount/" + global_id, });
}

function EmptyFormAdd() {
    global_id = 0;
    $('#Nom').val("");
    $('#Prenom').val("");
    $('#adress').val("");
    $('#Username').val("");
    $('#Email').val("");
    $('#Password').val("");
}

function FillFormEdit() {
    if (global_id == 0) {
        $('#labErrStep1').show();
        return;
    }
    else {
        $.ajax({
            type: "GET",
            url: "/api/AccountManage/GetCollaborator/" + global_id,
            success: function (data) {
                $('#editid').val(data.id);
                $('#editiduser').val(data.id_user_fk);
                $('#editNom').val(data.Nom);
                $('#editPrenom').val(data.Prenom);
                $('#editAdresse').val(data.address);  
            }
        });
        selectView("edit");
    }
}

function ValidateAddition() {

    $.ajax({
        type: "Post",
        async:false,
        url: "/api/AccountManage/ValidateCollaborateur",
        data: $('#addForm').serialize(),
        success: function (result) {
            console.log( " active ="+result);
            $('#AddNew').prop('disabled', !result);

        }
    });
}

function ValidateUpdate() {

    $.ajax({
        type: "Post",
        url: "/api/AccountManage/ValidateCollaborateurEdition",
        data: $('#editForm').serialize(),
        async:false,
        success: function (result) { 
            $('#submitEdit').prop('disabled', !result);

        }
    });
}

function selectView(view) {
    $('.display').not('#' + view + "Display").hide();
    $('#' + view + "Display").show();
}

function EmptyGridDoc()
{
    $('#tablecollaboratorDocumentsBody').remove();
    $('#tblcollaboratorDocuments').append('<tbody id="tablecollaboratorDocumentsBody"></tbody> </table>');
}

function EmptyGridCol() {
    $('#tableBody').remove();
    $('#tblaffichage').append('<tbody id="tableBody"></tbody> </table>');

}

function getlstCollaborator() {
   
    $.ajax({
        type: "GET",
        url: "/api/AccountManage/GetAllCollaborators",
        success: function (data) {
            EmptyGridCol();
            for (var i = 0; i < data.length; i++) {
                $('#tableBody').append('<tr><td><input id="id" name="id" type="hidden"'
                + 'value="' + data[i].id + '" /></td>'
                + '<td>' + data[i].marital_status + '</td>'
                + '<td>' + data[i].Nom + '</td>'
                 + '<td>' + data[i].Prenom + '</td>'
                 + '<td>' + data[i].address + '</td>'
                + '<td>' + data[i].Role + '</td></tr>');
            }
             
            initGridCol();
        }
    });
}

function initGridCol() {

    var table = $('#tblaffichage').dataTable({
        "bPaginate": true,
        "bLengthChange": false,
        "bFilter": true,
        "bSort": false,
        "bInfo": true,
        "bAutoWidth": false,
        "responsive": true,
        "scrollX": true,
        "language": { "url": "//cdn.datatables.net/plug-ins/1.10.7/i18n/French.json" },
        "lengthMenu": [[5, 10, 25, 50, -1], [10, 25, 50, "Tout"]],
        "destroy": true,
        "aoColumnDefs": [
                         { "width": "0.1%", "targets": 0 }
        ]
    });

    $("#tblaffichage tr").css('cursor', 'pointer');

    $('#tableBody').on('click', 'tr', function () {
     
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass();
            $(this).addClass('selected');
            global_id = $(this).find("td:first input[type=hidden]:first").val(); 
        }
       
    });

}

function UpdateCollaborator()
{
    $.ajax({
        type: "PUT",
        url: "/api/AccountManage/UpdateAccount/" + global_id,
        async: false,
        data: $('#editForm').serialize()       
            });
}

function SaveCollaborator() {
    $.ajax({
        type: "Post",
        url: "/api/AccountManage/CreateAccount",
        async: false,
        data: $('#addForm').serialize() 
         });
}
 