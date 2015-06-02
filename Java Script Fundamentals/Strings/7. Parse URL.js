/**
 Problem 7. Parse URL

 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 */

function parseUrl(url)
{
    var obj={},
        protocol,
        server,
        resource,
        preServerIndex=url.indexOf('://'),
        preResourceIndex=url.indexOf('/',preServerIndex+3);
    protocol=url.substring(0,preServerIndex);
    server=url.substring(preServerIndex+3,  preResourceIndex);
    resource=url.substring(preResourceIndex);
    obj['protocol']=protocol;
    obj['server']=server;
    obj['resource']=resource;
    return obj;

}
var url='http://telerikacademy.com/Courses/Courses/Details/239';
console.log(parseUrl(url));
