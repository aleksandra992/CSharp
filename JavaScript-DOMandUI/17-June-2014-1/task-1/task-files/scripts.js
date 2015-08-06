function createImagesPreviewer(selector, items) {
    var element = document.querySelector(selector),
        objectArr = items,
        leftDiv = document.createElement('div'),
        leftDivCaption = document.createElement('h1'),
        leftImg = document.createElement('img'),
        rightDiv = document.createElement('div'),
        listAnimals = document.createElement('ul'),
        listItemAnimal = document.createElement('li'),
        imageCaption = document.createElement('span'),
        imageAnimal = document.createElement('img'),
        filter = document.createElement('input'),
        filterCaption = document.createElement('span');

    rightDiv.style.height = "500px";
    rightDiv.style.width = "280px";
    rightDiv.style.overflowY = "auto";
    rightDiv.style.overflowX = "hidden";

    leftDiv.style.float = 'left';
    leftDivCaption.innerText = items[0].title;
    leftDivCaption.style.textAlign = "center";

    leftImg.src = items[0].url;
    // changeImageDim(leftImg,400);
    leftImg.style.width = "400px";


    leftDiv.appendChild(leftDivCaption);
    leftDiv.appendChild(leftImg);
    element.appendChild(leftDiv);
    filterCaption.style.display = "block";
    filterCaption.style.textAlign = "center";

    imageCaption.style.display = "block";
    imageCaption.style.textAlign = "center";
    imageCaption.style.fontSize = "18px";
    imageCaption.style.fontWeight = "bold";
    filterCaption.innerText = "Filter";

    filter.style.width = "220px";
    listItemAnimal.style.width = "220px";
    listItemAnimal.style.paddingBottom = '5px';
    imageAnimal.style.display = "block";
    imageAnimal.style.margin = "auto";
    imageAnimal.style.width = "200px";


    var filterDiv = document.createElement('div');
    filterDiv.style.marginLeft = "40px";
    filterDiv.appendChild(filterCaption);
    filterDiv.appendChild(filter);

    var fragmentList = document.createDocumentFragment();

    for (var i = 0, len = items.length; i < len; i += 1) {

        var newImageCaption = imageCaption.cloneNode();
        newImageCaption.innerText = items[i].title;

        var newImageAnimal = imageAnimal.cloneNode();
        newImageAnimal.src = items[i].url;
        //changeImageDim(newImageAnimal,200);

        var newListItemAnimal = listItemAnimal.cloneNode();
        newListItemAnimal.appendChild(newImageCaption);
        newListItemAnimal.appendChild(newImageAnimal);

        fragmentList.appendChild(newListItemAnimal);
    }
    listAnimals.style.listStyle = "none";

    filterDiv.style.height = "50px";

    listAnimals.appendChild(fragmentList);

    rightDiv.appendChild(filterDiv);
    rightDiv.appendChild(listAnimals);
    rightDiv.style.float = "left";
    element.appendChild(rightDiv);


    listAnimals.addEventListener('click', function (ev) {

        var current = ev.target;
        console.log(current.tagName);
        if (current.tagName === 'IMG') {
            var newCaption = current.parentNode.firstChild;
            newCaption = newCaption.innerHTML;
            var newImageSrc = current.src;
            leftDivCaption.innerText = newCaption;
            leftImg.src = newImageSrc;

            // changeImageDim(leftImg,400);


        }
        // console.log(newCaption.innerHTML);
    }, false);
    listAnimals.addEventListener('mouseover', function (event) {
        var current = event.target;
        console.log(current);
        if (current.tagName !== "LI" && current.tagName != 'UL') {
            var parent = current.parentNode;
            parent.style.backgroundColor = "red";
        }

    }, false);
    listAnimals.addEventListener('mouseout', function (event) {
        var current = event.target;
        console.log(current);
        if (current.tagName !== "LI" && current.tagName != 'UL') {
            var parent = current.parentNode;
            parent.style.backgroundColor = "white";
        }

    }, false);
    var allLi = listAnimals.querySelectorAll('li');

    filter.addEventListener('input', function () {
        var value = this.value.toLowerCase();
        var reg = new RegExp(value);
        for (var i = 0; i < allLi.length; i += 1) {

            console.log(allLi[i].childNodes[0].innerText.toLowerCase());
            if (!(reg.test(allLi[i].childNodes[0].innerText.toLowerCase()))) {
                allLi[i].style.display = "none";
            }
            else {
                allLi[i].style.display = "block";
            }
        }


    }, false)

    function changeImageDim(img, width) {
        var imgWidth = img.width;
        var coeficient = width / imgWidth;
        var height = img.height * coeficient;
        img.style.width = width + "px";
        img.style.height = height + "px";
    }

}