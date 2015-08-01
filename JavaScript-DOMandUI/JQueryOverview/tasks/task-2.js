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
        if ($domElement.size() === 0) {
            throw Error();
        }

        var $buttons = $domElement.find(".button");
        $buttons.html("hide");

        var $lastButton = $('.button').last();


        $domElement.on("click", '.button', function (ev) {
                var $next = $(this).next();
                var $contentElement;
                var firstContentFound = false;
                while ($next.size() !== 0) {
                    if ($next.hasClass('button')) {
                        break;
                    }
                    if ($next.hasClass('content')) {
                        $contentElement = $next;
                        break;
                    }
                    $next = $next.next();
                }
                if (!$(this).is($lastButton)) {

                    if ($contentElement !== undefined) {
                        if ($contentElement.css('display') === 'none') {
                            $(this).html('hide');
                            $contentElement.css('display', '');

                        }
                        else {
                            console.log($contentElement.css('display'));
                            $(this).html('show');
                            $contentElement.css('display', 'none');
                        }
                    }
                }

            }
        )
        ;


    };
}
module.exports = solve;