
var brends;
var brendsAssortment = {
    assortment: {},
    nameTable: "",
    thislength: 0,
    loadAssortment: function () {

        this.thislength = this.assortment.length;
        var row = "<tr><th>Артикул</th><th>Наименование</th></tr>";
        for (var i = 0; i < this.thislength; i++) {
            row += '<tr class="brendsAssortment" onclick="brendsAssortment.selectAssortment(this)" id=assortment_' + i +
                '><td>' + this.assortment[i].Article + '</td>';
            row += '<td id="td_' + i + '">' + this.assortment[i].Name + '</td></tr>';
        }

        $('#' + this.nameTable).html(row);
    },
    selectItem: {},
    editText: "",
    selectAssortment: function (el) {
        if (this.selectItem !== el) {
            if (this.selectItem.style != undefined) {
                this.selectItem.style.backgroundColor = "burlywood";
                var id = this.selectItem.id.split('_')[1] * 1;
                $('#td_' + id).html(this.assortment[id].Name);

            }

            this.selectItem = el;
            this.selectItem.style.backgroundColor = "#99cb97";

            var id = this.selectItem.id.split('_')[1] * 1;
            editText = this.assortment[id].Name.toString();
            var row =
                '<input id="editItem_' + id + '" style="width:' + (this.assortment[id].Name.length * 8) +
                'px;" type="text" value=' + editText + ' />' +
                '<input id="btnEdit_' + id + '" type="button" onclick="brendsAssortment.saveChanges(this.id)" value="Сохранить"/>';

            $('#td_' + id).html(row);

        }
    },
    saveChanges: function (id) {
        var nId = id.split('_')[1] * 1;
        //alert($('#editItem_' + nId).val());
        var editElem = this.assortment[nId];
        editElem.Name = '"' + $('#editItem_' + nId).val() + '"';
        this.saveChangesServer(editElem, nId);
    },
    saveChangesServer: function (editElem, nid) {

        var token = $("#__AjaxAntiForgeryForm input").val();

        var formData = new FormData();

        formData.append("__RequestVerificationToken", token);

        formData.append("Id", editElem.Id);
        formData.append("Name", editElem.Name);

        $.ajax({
            url: "../Assortment/SaveChanges",
            type: "POST",
            data: formData,
            contentType: false,
            processData: false,
            success: function (result) {

                if (result) {
                    alert("Все ОК!");
                   
                    if (brendsAssortment.selectItem.style != undefined) {
                        brendsAssortment.selectItem.style.backgroundColor = "burlywood";
                        var id = brendsAssortment.selectItem.id.split('_')[1] * 1;
                        $('#td_' + id).html(brendsAssortment.assortment[id].Name);

                    }
                    
                }
                else if (!result) {
                    alert("Данные не изменились");
                }
                else {
                    alert(JSON.parse(result).toString());
                }
                
            }
        });


    }

};
var table;

$(document).ready(function () {

    var token = $("#__AjaxAntiForgeryForm input").val();

    var formData = new FormData();

    formData.append("__RequestVerificationToken", token);

    $.ajax({
        url: "../Default/Brends",
        type: "POST",
        data: formData,
        contentType: false,
        processData: false,
        success: function (result) {

            brends = JSON.parse(result);
            var rowBrends = "";
            for (var i = 0; i < brends.length; i++) {
                rowBrends += '<div style="cursor:pointer" onclick="SelectBrend(this)" id=brends_' + brends[i].Id + '>' + brends[i].BrendName + '</div>';

            }

            $('#divBrends').html(rowBrends);
        }
    });

});

var currentBrend;

function SelectBrend(el) {

    $('#' + currentBrend).css('background-color', '#bfbeb4');
    currentBrend = el.id;
    $('#tblAssortment').html('');
     var token = $("#__AjaxAntiForgeryForm input").val();

    var formData = new FormData();

    formData.append("__RequestVerificationToken", token);

    formData.append("id", currentBrend);

    $.ajax({
        url: "../Assortment/GetAssortment",
        type: "POST",
        data: formData,
        contentType: false,
        processData: false,
        success: function (result) {

            brendsAssortment.assortment = result;
            brendsAssortment.nameTable = "tblAssortment";
            brendsAssortment.loadAssortment();

        }
    });

    
    el.style.backgroundColor = "#99cb97";
}


