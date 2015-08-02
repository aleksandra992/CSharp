function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this);
            var templateID = '#' + $this.attr('data-template');
            var templateHtml = $(templateID).html();
            var template = handlebars.compile(templateHtml);

            for (var i = 0; i < data.length; i += 1) {
                $this.append(template(data[i]));
            }
            return this;


        };
    };
}
module.exports = solve;
//if you want to test in browser uncomment this and comment the above code
//(function ($) {
//    $.fn.listview = function (data) {
//        var $this = $(this);
//        var templateID = '#' + $this.attr('data-template');
//        var templateHtml = $(templateID).html();
//        var template = Handlebars.compile(templateHtml);
//
//        for (var i = 0; i < data.length; i += 1) {
//            $this.append(template(data[i]));
//        }
//        return this;
//
//
//    };
//}(jQuery));
