var message = function () {
    var messageIndex = "this is index page";
    var messageAbout = "this is about page";

    return {
        GetMessageIndex: function () {
            return messageIndex;
        },

        GetMessageAbout: function () {
            return messageAbout;
        }
    }
}();

module.exports = message;
