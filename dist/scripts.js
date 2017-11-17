$(function() {
    /*
        General Functions
    */
    function popupOut() {
        $(".app-popup").fadeOut();
        $("body").css("overflow", "auto");
    }

    /*
        Administration functions
    */
    $("#app-popup-test-popup").click(function() {
        $(".app-popup.admin").fadeIn();     
    });

    $("#app-popup-close-menu").click(function() {
        $(".app-popup-settings").fadeOut();
        $(".app-popup-settings-small").fadeIn();
    });
    $("#app-popup-open-menu").click(function() {
        $(".app-popup-settings").fadeIn();
        $(".app-popup-settings-small").fadeOut();
    });

    /*
        Close functions
    */

    // Click in BG
    $(".app-popup .background").click(function() {
        popupOut();
    });

    // Click on close
    $(".app-popup .popup-close").click(function() {
        popupOut();
    });

    // Press ESC on Keyboard
    $(document).keyup(function(e) {
        if (e.keyCode == 27) {
            popupOut();
       }
   });
});