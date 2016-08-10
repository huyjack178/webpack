var jQuery = require('../jquery-1.10.2.js');
var message = require('./message.js');

require('../../Content/Index.css');

(function ($) {
    $("p").text(message.GetMessageIndex());
})(jQuery);