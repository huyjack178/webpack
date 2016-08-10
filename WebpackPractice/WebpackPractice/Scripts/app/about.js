var jQuery = require('../jquery-1.10.2.js');
var message = require('./message.js');

require('../../Content/About.css');

(function ($) {
    $("p").text(message.GetMessageAbout());
})(jQuery)
