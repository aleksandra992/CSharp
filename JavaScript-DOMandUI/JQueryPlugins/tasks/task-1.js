function solve() {
    return function (selector) {
        var $selectElement = $(selector).hide();

        var $optionElements = $selectElement.find('option');


        var $divDropDown = $('<div>')
            .addClass("dropdown-list")
            .append($selectElement);

        var $current = $('<div>')
            .addClass("current")
            .attr("data-value", '')
            .text("Select value");


        var $divOptionsContainer = $('<div>')
            .addClass("options-container").css({
                'position': 'absolute',
                'display': 'none'
            });


        for (var i = 0; i < $optionElements.length; i += 1) {
            var $optionElement = $optionElements[i];
            console.log($($optionElement).val());
            var $newDivOption = $('<div>');
            $newDivOption.addClass("dropdown-item").
                attr("data-value", $($optionElement).val()).
                attr("data-index", i).
                text($($optionElement).text());
            $divOptionsContainer.append($newDivOption);
        }

        $divDropDown.append($selectElement);
        $divDropDown.append($current);
        $divDropDown.append($divOptionsContainer);
        $divDropDown.appendTo("body");

        $current.on('click', function () {
            $current.text('Select a value');
            if ($divOptionsContainer.css('display') === 'block') {
                $divOptionsContainer.css('display', 'none');
            }
            else {
                $divOptionsContainer.css('display', 'block');
            }

        });

        $divOptionsContainer.on('click', '.dropdown-item', function () {
            $current.text($(this).html());
            $current.val($(this).attr('data-value'));
            $divOptionsContainer.css('display', 'none');
            $selectElement.val($(this).attr('data-value'));

        });

    };
}
module.exports = solve;