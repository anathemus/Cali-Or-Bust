// Initialize tooltip component
$(function () {
    $('[data-toggle="tooltip"]').tooltip();
});

// Initialize popover component
$(function () {
    $('[data-toggle="popover"]').popover();
});

// Initialize button plugin
$(function () {
    $('.btn').button();
});

$(document).ready(function () {


    $("input[type='radio'][name='continue1']").change(function () {
        if (this.id === 'continue1Op1') {
            $("#continue1Op1").button('toggle');
        } else if (this.id === 'continue1Op0') {
            $("#continue1Op0").button('toggle');
        } else {
            alert("Error in continue1 button set!");
        }
    });

    $("input[type='button'][id='firstButton']").click(function () {
        $("#hidden1").removeClass("invisible");
        $(".first").addClass("invisible");
    });
});