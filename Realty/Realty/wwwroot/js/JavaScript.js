document.addEventListener("DOMContentLoaded", function (event) {
    getRealty();
});

function getRealty() {
    $.ajax({
        url: "/api/realty", 
        type: "GET", 
        dataType: "HTML", 
        success: function (data) { 
            let realty = JSON.parse(data); 
            let html = ""; 
            html += "<div class=\"card-group\">";
            if (realty) {
                for (var i in realty) { 
                    html += "<div class=\"card\">";
                    html += "<div class=\"card-body\">";
                    html += "<img class=\"card-img-top\" src=\"images/" + realty[i].adress + ".JPG\">";
                    html += '<strong> <h3>' + realty[i].property.name + '</h3> </strong>';
                    html += '<p>Адрес: ' + realty[i].adress + '</p>';
                    html += '<p>Метраж: ' + realty[i].area + 'кв.м.</p>';
                    html += '<p>Цена: ' + realty[i].cost + 'руб.</p>';
                    html += '<button type="button" class="btn btn-primary btn-block innerBtn"   data-toggle="modal" data-target="#myModal2" onclick="Getrealty(' + realty[i].realtyId + ');"> Редактировать </button>';
                    html += '<button type="button" class="btn btn-btn-link btn-block innerBtn" onclick="deleteRealty(' + realty[i].realtyId + ');"> Удалить </button>';
                    html += '</div>';
                    html += "</div>";
                }
            }
            html += "</div>";
            $('#realtyDiv').html(html);   
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}

function createRealty() {
    var adress = $('#addAdress').val();
    var area = $('#addArea').val();
    var Property = $('#addProperty').val();
    var cost = $('#addCost').val();
  

    $.ajax({
        url: '/api/realty',
        type: 'POST',
        contentType: 'application/json',
        dataType: 'HTML',
        data: JSON.stringify({
            Adress: adress,
            Area: area,
            PropertyId: Property,
            Cost: cost,
            
        }),
        success: function (data) {
            getRealty();
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert("У вас недостаточно прав!");
        }
    });
}

function deleteRealty(id) {
    $.ajax({
        url: '/api/realty/' + id,
        type: 'DELETE',
        dataType: 'HTML',
        success: function () {
            getRealty();
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}

function Showrealty(realty) {
    if (realty != null) {

        $("#editId").val(realty.realtyId);
        $("#editAdress").val(realty.adress);
        $("#editArea").val(realty.area);
        $("#editCost").val(realty.cost);
        $("#editProperty").val(realty.propertyId);
      
    }
    else {
        alert("Нет такого объекта");
    }
}

function Getrealty(id) {
    $.ajax({
        url: '/api/realty/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            Showrealty(data);
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}

function updateRealty() {
    var id = $('#editId').val();
    var adress = $('#editAdress').val();
    var area = $('#editArea').val();
    var propertyId = $('#editProperty').val();
    var cost = $('#editCost').val();
    $.ajax({
        url: '/api/realty/' + id,
        type: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify({
            RealtyId: id,
            Adress: adress,
            Area: area,
            PropertyId: propertyId,
            Cost: cost,
        }),
        success: function (data) {
            getRealty();
         
            console.log(data);
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}