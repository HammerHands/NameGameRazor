$(document).ready(function () {
    if (!sessionStorage.numCorrect) {
        sessionStorage.numCorrect = 0;
    }
    $('#streak').html('Streak = ' + sessionStorage.numCorrect);
});