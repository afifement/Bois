var global_id = 0;
var global_documentid = 0;

 
$(document).ready(function () {
    getlstClients();
    selectView("summary"); 
    $.getScript("../Scripts/jquery.maskedinput.js", function () { $("#birth_date").mask("99/99/9999", { placeholder: "dd/mm/yyyy" }); });
    $("button").click(function (e) { ClickHandler(e);  });
    $(".fiche, .ladate").change(function () { ValidateClient(); });
    $(".docinput").change(function () { ValidateDoc(); });
    
});

function ClickHandler(e) {

    switch (e.target.id) {
  
        case "btndeleteclient": DeleteClient(); getlstClients(); break;

        case "Annuler":   selectView("summary"); break;

        case "btnaddclient": $('#labErrStep1').hide(); EmptyFormStep2(); $('#btnStepTwo').prop('disabled', true); selectView("step2"); break;

        case "btneditclient": FillFormStep2(); $('#btnStepTwo').prop('disabled', false); break;

        case "btnStepTwo": SaveOrUpdateClient(); getlstClients(); selectView("summary"); break;

        case "btnfileCancel": selectView("clientDocuments"); break;

        case "btnclientDocuments": clientDocuments(); break;

        case "btndeleteclientDocument": deleteClientDocument(); break;

        case "btnaddclientDocument": emptyAdddocumentFormStep2(); $('#btnfileStepTwo').prop('disabled', true); selectView("addclientDocument"); break;

        case "btnfileStepTwo": saveClientDocument(); clientDocuments(); selectView("clientDocuments"); break;

        case "btnviewclientDocument": fileViewer(); break;

    }
}

function ValidateDoc() {
    var blnIsNotValid = ($("#document_name").val() == "") || ($("#document_type").val() == "") || ($("#documentContent").val() == "");
    $('#btnfileStepTwo').prop('disabled', blnIsNotValid);
}
                                                                                  
function ValidateClient() {

    $.ajax({
        type: "Post",
        url: "/api/Client/ValidateClient",
        data: $('#editForm').serialize(),
        success: function (result) {
            $('#btnStepTwo').prop('disabled', !result);

        }
    });
}

function DeleteClient()
{
    $.ajax({ type: "Delete", async: false, url: "/api/Client/DeleteClient/" + global_id });
}

function EmptyFormStep2() {
    global_id = 0;
    $('#identificateur').val(0);
    $('#cnss').val("");
    $('#lastname').val("");
    $('#firstname').val("");
    $('#address').val("");
    $('#birth_date').val("");
    $('#birth_place').val("");
    $('#mutuelle').val("");
    $('#caisse_assu_maladie').val("");
}

function FillFormStep2() {
    if (global_id == 0) {
        $('#labErrStep1').show();
        return;
    }
    else {
        $.ajax({
            type: "GET",
            url: "/api/Client/GetClient/" + global_id,
            success: function (data) {

                if (data.birth_date != null)
                {
                    var year = data.birth_date.split('-')[0];
                    var month = data.birth_date.split('-')[1];
                    var day = data.birth_date.split('-')[2].substring(0, 2);
                    var res = day + '/' + month + '/' + year;
                    $('#birth_date').val(res);
                }
                

                $('#identificateur').val(global_id);
                $('#cnss').val(data.cnss);
                $('#lastname').val(data.lastname);
                $('#firstname').val(data.firstname);
                $('#address').val(data.address);
                $('#birth_place').val(data.birth_place);
                $('#mutuelle').val(data.mutuelle);
                $('#caisse_assu_maladie').val(data.caisse_assu_maladie);
                $('#client_type').val(data.client_type);

            }
        });
        selectView("step2");
    }

}

function SaveOrUpdateClient() {
  
    var id_client = global_id; 
    try {
        var tempDate = $('#birth_date').val();
        var day1 = tempDate.split('/')[0];
        var month1 = tempDate.split('/')[1];
        var year1 = tempDate.split('/')[2];
        var res1 = month1 + '/' + day1 + '/' + year1;
        $('#birth_date').val(res1);
    }
    catch (e) { }

    if (id_client == 0) { 
        $.ajax({
            type: "Post",
            async: false,
            url: "/api/Client/CreateClient",
            data: $('#editForm').serialize()
        });
    }
    else { 
        $.ajax({
            type: "PUT",
            async: false,
            url: "/api/Client/UpdateClient/" + id_client,
            data: $('#editForm').serialize()
        });

    }

}

function EmptyGridStep1() {
    $('#tableClientBody').remove();
    $('#tblclient').append('<tbody id="tableClientBody"></tbody> </table>');
}

function selectView(view) {
    $('.display').not('#' + view + "Display").hide();
    $('#' + view + "Display").show();
}

function getlstClients() {

    $.ajax({
        type: "GET",
        url: "/api/Client/GetListClient",
        success: function (data) {
            EmptyGridStep1();
            for (var i = 0; i < data.length; i++) {
                $('#tableClientBody').append('<tr><td><input id="id" name="id" type="hidden"'
                + 'value="' + data[i].id + '" /></td>'
                + '<td>' + data[i].cnss + '</td>'
                 + '<td>' + data[i].lastname + '</td>'
                 + '<td>' + data[i].firstname + '</td>'
                + '<td>' + data[i].address + '</td></tr>');
            }
            initGridClient();

        }
    });
}

function initGridClient() {
    var table = $('#tblclient').dataTable({
        "bPaginate": true,
        "bLengthChange": false,
        "bFilter": true,
        "bSort": false,
        "bInfo": true,
        "responsive": true,
        "scrollX": true,
        "scrollCollapse": true,
        "bAutoWidth": false,
        "language": { "url": "//cdn.datatables.net/plug-ins/1.10.7/i18n/French.json" },
        "lengthMenu": [[5, 10, 25, 50, -1], [10, 25, 50, "Tout"]],
        "destroy": true,
        "aoColumnDefs": [
                         { "width": "0.1%", "targets": 0 }
        ]
    });

    $("#tblclient tr").css('cursor', 'pointer');



    $('#tableClientBody').on('click', 'tr', function () {
        $('#labErrStep1').hide();
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

function clientDocuments() {

    if (global_id == 0) {
        $('#labErrStep1').show();
        return;
    }
    else {
        $.ajax({
            type: "GET",
            url: "/api/ClientDocument/GetDocumentsByClient/" + global_id,
            cache: false,
            success: function (data) {
                EmptyGridDoc();
                $.each(data, function (index, value) {
                    $('#tableclientDocumentsBody').append('<tr>' +
                        '<td><input id="iddoc" name="iddoc" type="hidden" value="' + value.id + '" /></td>'
                         + '<td>' + value.name + '</td>'
                         + '<td>' + value.Type + '</td>'
                         + '</tr>');
                });

                initGridDoc();
                global_documentid = 0;
                selectView("clientDocuments");
            }
        });
    }
}

function initGridDoc() {

    var tableDocumentClient = $('#tblclientDocuments').dataTable({
        "bPaginate": true,
        "bLengthChange": false,
        "bFilter": true,
        "bSort": false,
        "bInfo": true,
         "responsive": true,
        "scrollX": true,
        "bAutoWidth": false,
        "language": { "url": "//cdn.datatables.net/plug-ins/1.10.7/i18n/French.json" },
        "lengthMenu": [[5, 10, 25, 50, -1], [10, 25, 50, "Tout"]],
        "destroy": true,
        "aoColumnDefs": [
                         { "width": "0.1%", "targets": 0 }
        ]
    });

    $("#tblclientDocuments").css('cursor', 'pointer');



    $('#tableclientDocumentsBody').on('click', 'tr', function () {

        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            tableDocumentClient.$('tr.selected').removeClass();
            $(this).addClass('selected');
            global_documentid = $(this).find("td:first input[type=hidden]:first").val();
        }

    });

}

function deleteClientDocument() {
    if (global_documentid > 0) {
        var formData = new FormData();
        formData.append("clientId", global_id);
        $.ajax({
            type: "Delete",
            async: false,
            contentType: false,
            processData: false,
            url: "/api/ClientDocument/DeleteClientDocument/" + global_documentid,
            data: formData
        });
        global_documentid = 0;
        clientDocuments();
    }

}

function emptyAdddocumentFormStep2() {

    $('#document_name').val('');
    $('#document_type').val('');  
    reset($('#documentContent'));
}

function saveClientDocument() {

    var formData = new FormData();
    var files = $("#documentContent").get(0).files;

    // Add the uploaded file content to the form data collection
    if (files.length > 0) {
        formData.append("UploadedFile", files[0]);
    }

    formData.append("document_name", $('#document_name').val());
    formData.append("document_type", $('#document_type').val());

    formData.append("clientId", global_id);

    $.ajax({
        type: "POST",
        async: false,
        contentType: false,
        processData: false,
        url: "/api/ClientDocument/CreateClientDocument",
        data: formData
    });
}

function fileViewer() {
    if (global_documentid > 0) {
        window.open("/api/ClientDocument/fileViewer/" + global_documentid, '_blank', '');
    }
}

function EmptyGridDoc() {
    $('#tableclientDocumentsBody').remove();
    $('#tblclientDocuments').append('<tbody id="tableclientDocumentsBody"></tbody> </table>');
}

window.reset = function (e) {
    e.wrap('<form>').closest('form').get(0).reset();
    e.unwrap();
}