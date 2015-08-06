$.fn.tabs = function () {

    var $this = $(this);
    $this.addClass('tabs-container');
    var $tabChildren = $this.children();
    $($tabChildren).find('.tab-item-content').hide();
    $($tabChildren.first('.tab-item')).addClass('current');
    console.log($($tabChildren.first('.tab-item')).find('.tab-item-content').show());
    var previousTab = $tabChildren.first('.tab-item');

    function onItemClick() {
        previousTab.removeClass('current');
        previousTab.find('.tab-item-content').css('display', 'none');
        var $this = $(this);
        $this.find('.tab-item-content').css('display', 'inline-block');
        $this.addClass('current');
        previousTab = $this;
    }

    $this.on('click', '.tab-item', onItemClick);
    return this;

};