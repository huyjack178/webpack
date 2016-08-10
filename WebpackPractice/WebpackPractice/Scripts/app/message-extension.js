var message = function () {
    var messageIndex = "extension - this is index page";
    var messageAbout = "extension - this is about page";

    return {
        GetMessageIndex: function () {
            return messageIndex;
        },

        GetMessageAbout: function () {
            return messageAbout;
        }
    }
}();