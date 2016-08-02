import jQuery from '../jquery-1.10.2.js';
import '../../Content/About.css';
import {message} from './message.js';

(function ($) {
    $("p").text(message.GetMessageAbout);
})(jQuery)
