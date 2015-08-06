/* globals $ */

function solve() {
    return function() {
        $.fn.gallery = function (cols) {
            var numberCols = cols || 4;

            var $this = this;
            $this.addClass('gallery');

            var selectedGallery = $this.children('.selected')
                .css('display', 'none');
            var images = $this.find('.image-container');
            images.each(function (index, item) {
                if (index % numberCols === 0) {
                    $(item).addClass('clearfix');
                }
            });

            var galleryList = $('.gallery-list');
            var imageChildren = galleryList.children();

            galleryList.on('click', '.image-container', function () {

                galleryList.addClass('blurred');
                var divDisabling = $('<div>');
                divDisabling.addClass('disabled-background');
                $this.append(divDisabling);
                selectedGallery.show();
                setImages($(this));


            });
            function setImages(currentContainer) {
                var currentSrc = currentContainer.find('img').attr('src');
                selectedGallery.find('.current-image').find('img').attr('src', currentSrc);
                setPrevious(currentContainer);
                setNext(currentContainer);
            }

            function setPrevious(currentContainer) {
                var imgClickedCurrent = currentContainer.find('img');

                if (imgClickedCurrent.attr('data-info') == 1) {

                    selectedGallery.find('.previous-image')
                        .find('img')
                        .attr('src', currentContainer.parent()
                            .children()
                            .last()
                            .find('img')
                            .attr('src'));

                }
                else {
                    selectedGallery.find('.previous-image')
                        .find('img')
                        .attr('src', currentContainer.prev().find('img').attr('src'));
                }
            }

            function setNext(currentContainer) {
                var imgClickedCurrent = currentContainer.find('img');
                if (imgClickedCurrent.attr('data-info') == imageChildren.length) {

                    selectedGallery.find('.next-image')
                        .find('img')
                        .attr('src', currentContainer.parent()
                            .children()
                            .first()
                            .find('img')
                            .attr('src'));

                }
                else {
                    selectedGallery.find('.next-image')
                        .find('img')
                        .attr('src', currentContainer.next().find('img').attr('src'));
                }


            }

            selectedGallery.find('.current-image').on('click', function () {
                selectedGallery.hide();
                galleryList.removeClass('blurred');
                $this.find('.disabled-background').remove();
            })
            selectedGallery.find('.previous-image').on('click', function () {
                var currentFromGallery = galleryList.find('img[src="' + $(this).find('img').attr('src') + '"]');
                //console.log(currentFromGallery);
                setImages(currentFromGallery.parent());
            })
            selectedGallery.find('.next-image').on('click', function () {

                var currentFromGallery = galleryList.find('img[src="' + $(this).find('img').attr('src') + '"]');
               // console.log(currentFromGallery);
                setImages(currentFromGallery.parent());
            })

            return this;

        }
    }
}
module.exports=solve;