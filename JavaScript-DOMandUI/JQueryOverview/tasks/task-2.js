function solve() {
    return function (selector) {
        var $domElement,
            i,
            len

        if (selector === undefined) {
            throw Error();
        }

        if (typeof selector !== 'string') {
            throw Error();
        }

        var $domElement = $(selector);
       // console.log($domElement);
        if ($domElement.size()===0) {
            throw Error();
        }

        var $buttons = $domElement.find(".button");

        for (i = 0, len = $buttons.length; i < len; i += 1) {
            var $button = $($buttons[i]);
            $button.html("hide");

            $button.on("click", function () {

                var $next = $(this).next();

                while (!$next.hasClass('button')) {
                    if ($next.hasClass('content')) {
                        break;
                    }
                    $next = $next.next();

                }

                if ($next.hasClass('content') && $next.css('display') == '') {
                    // console.log('tukaaaaa');
                    $(this).html('show');
                    $next.css('display', 'none');
                }
                else if ($next.hasClass('content') && $next.css('display') == 'none') {
                    //  console.log('none');
                    $(this).html('hide');
                    $next.css('display', '');
                }

            });

        }

    };
}
module.exports=solve;