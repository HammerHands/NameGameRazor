$(window).keypress(function (key) {
    switch (key.keyCode) {
        case 49:
            guess(0);
            break;
        case 50:
            guess(1);
            break;
        case 51:
            guess(2);
            break;
        case 52:
            guess(3);
            break;
        case 53:
            guess(4);
            break;
        default:
            //do nothing
            break;
    }
});