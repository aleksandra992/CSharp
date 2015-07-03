function checkIfBrowserIsMozzila( THE_event, argumenti) {
    var myWindow= window,
        myBrowser = myWindow.navigator.appCodeName,
        isMozzila=myBrowser=="Mozilla";
    if(isMozzila) {
        alert("Yes");
    } else {
        alert("No");
    }
}/**
 * Created by Aleksandra on 6/29/2015.
 */
