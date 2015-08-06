function createCalendar(selector, events) {
    var domElement = document.querySelector(selector);
    if (!domElement) {
        throw new Error();
    }

    var div = document.createElement('div');
    div.className = 'item';

    var divCaption = document.createElement('span');
    divCaption.style.display = "inline-block";
    divCaption.style.background = 'grey';

    divCaption.style.width = '150px';
    divCaption.style.height = '20px';
    divCaption.style.borderBottom = 'solid black 1px';
    divCaption.style.textAlign = 'center';
    divCaption.innerText = 'nesto';
    var divContent = document.createElement('div');
    divContent.style.textAlign = "center";
    divContent.style.width = '150px';
    divContent.style.height = '99px';
    var titleParagraph = document.createElement('p');
    titleParagraph.style.margin = 0;
    divContent.appendChild(titleParagraph);
    divContent.className = 'content';
    div.appendChild(divCaption);
    div.appendChild(divContent);
    div.style.width = '150px';
    div.style.height = '120px';
    div.style.border = 'solid black 1px';
    div.style.float = 'left';

    var daysOfJune = ['Sun', 'Mon', 'Tue', 'Wed', 'Thur', 'Fri', 'Sat'];
    var fragment = document.createDocumentFragment();

    for (var i = 0, len = 30; i < len; i += 1) {

        var newDiv = div.cloneNode(true);
        newDiv.setAttribute('data-info', (i + 1).toString());
        var span = newDiv.querySelector('span');
        span.innerHTML = daysOfJune[i % 6] + ' ' + (i + 1) + ' June ' + '2014';
        if (i % 7 === 0) {
            newDiv.style.clear = "left";
        }
        fragment.appendChild(newDiv);
    }

    for (var i = 0; i < events.length; i += 1) {
        var event = events[i];
        var currentDiv = fragment.querySelector('div[data-info="' + event.date + '"]');
        var currentContent = currentDiv.querySelector('.content');
        var paragraph = currentContent.querySelector('p');
        var title = 'Title ' + event.title;
        paragraph.innerText = title;
        var content = 'duration ' + event.duration + '</br>' + 'Hour ' + event.hour;
        currentContent.innerHTML += content;
    }
    function click(ev) {
        var current = ev.target;
        if (current.className === 'content') {
            if (current.style.background === 'red') {

                current.style.background = 'white';

            }
            else
                current.style.background = 'red';
        }


    }

    function onMouseOut() {
        var current = this;
        var p = this.querySelector('p');
        p.style.background = 'white';
        console.log('tuka');
    }

    domElement.addEventListener('click', click, true);
    domElement.addEventListener('mouseover', onMouseOver, false);


    domElement.appendChild(fragment);
    var previousTag=domElement.querySelector('.item');

    function onMouseOver(ev) {
        var current = ev.target;
        var previouP=previousTag.querySelector('p');
        console.log(previouP);
        previouP.style.background='white';
        if (current.className === 'content') {
            var p = current.querySelector('p');
            p.style.background = 'red';
            previousTag=current;
        }
        else if (current instanceof HTMLParagraphElement) {

            current.style.background = 'red';
            previousTag=current;
        }

    }



}