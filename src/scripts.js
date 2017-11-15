$(function() {
    /*
        Close functions
    */

    // Click in BG
    $(".app-popup .background").click(function() {
        $(this).fadeOut();
        $(".app-popup .popup").fadeOut();
    });

    // Click on close
    $(".app-popup .popup-close").click(function() {
        $(".app-popup .background").fadeOut();
        $(".app-popup .popup").fadeOut();
    });

    // Press ESC on Keyboard
    $(document).keyup(function(e) {
        if (e.keyCode == 27) {
            $(".app-popup .background").fadeOut();
            $(".app-popup .popup").fadeOut();
       }
   });
});