document.addEventListener("DOMContentLoaded", function (event) {
    getAgent();
});

function getAgent() {
    $.ajax({
        url: "/api/agent",
        type: "GET",
        dataType: "HTML",
        success: function (data) {
            let agent = JSON.parse(data);
            let html = "";
            html += "<div class=\"card-group\">";
            if (agent) {
                for (var i in agent) {
                    html += "<div class=\"card\">";
                    html += "<div class=\"card-body\">";
                    html += "<img class=\"card-img-top\" src=\"images/" + agent[i].name + ".JPG\">";
                    html += '<strong> <h3>' + agent[i].name + '</h3> </strong>';
                    html += '<p>Телефон: ' + agent[i].tell + '</p>';
                    html += '<p>Email: ' + agent[i].email + 'кв.м.</p>';
                    html += '<button type="button" class="btn btn-primary btn-block innerBtn"   data-toggle="modal" data-target="#myModal2" onclick="Getagent(' + agent[i].agentId + ');"> Редактировать </button>';
                    html += '<button type="button" class="btn btn-btn-link btn-block innerBtn" onclick="deleteAgent(' + agent[i].agentId + ');"> Удалить </button>';
                    html += '</div>';
                    html += "</div>";
                }
            }
            html += "</div>";
            $('#agentDiv').html(html);
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}

function createAgent() {
    var name = $('#addName').val();
    var tell = $('#addTell').val();
    var email = $('#addEmail').val();


    $.ajax({
        url: '/api/agent',
        type: 'POST',
        contentType: 'application/json',
        dataType: 'HTML',
        data: JSON.stringify({
            Name: name,
            Tell: tell,
            Email: email,

        }),
        success: function (data) {
            getAgent();
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert("У вас недостаточно прав!");
        }
    });
}

function deleteAgent(id) {
    $.ajax({
        url: '/api/agent/' + id,
        type: 'DELETE',
        dataType: 'HTML',
        success: function () {
            getAgent();
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}

function Showagent(agent) {
    if (agent != null) {

        $("#editId").val(agent.agentId);
        $("#editName").val(agent.name);
        $("#editTell").val(agent.tell);
        $("#editEmail").val(agent.email);

    }
    else {
        alert("Нет такого агента");
    }
}

function Getagent(id) {
    $.ajax({
        url: '/api/agent/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            Showagent(data);
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}

function updateAgent() {
    var id = $('#editId').val();
    var name = $('#editName').val();
    var tell = $('#editTell').val();
    var email = $('#editEmail').val();
    $.ajax({
        url: '/api/agent/' + id,
        type: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify({
            AgentId: id,
            Name: name,
            Tell: tell,
            Email: email,
        }),
        success: function (data) {
            getAgent();

            console.log(data);
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError + "\r\n" + xhr.statusText + "\r\n" + xhr.responseText);
        }
    });
}
