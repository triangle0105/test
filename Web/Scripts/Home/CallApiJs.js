// 创建XHR对象
function createCORSRequest(method, url) {
    var xhr = new XMLHttpRequest();
    if ("withCredentials" in xhr) {
        // 针对Chrome/Safari/Firefox.
        xhr.open(method, url, true);
    } else if (typeof XDomainRequest != "undefined") {
        // 针对IE
        xhr = new XDomainRequest();
        xhr.open(method, url);
    } else {
        // 不支持CORS
        xhr = null;
    }
    return xhr;
}

// 辅助函数，用于解析返回的内容
function getTitle(text) {
    return text.match('')[1];
}

// 发送CORS请求
function makeCorsRequest() {
    // bibliographica.org是支持CORS的
    var url = 'http://web.local/api/CustomerApi';

    var xhr = createCORSRequest('GET', url);
    if (!xhr) {
        alert('CORS not supported');
        return;
    }

    // 回应处理
    xhr.onload = function () {
        var text = xhr.responseText;
        var title = getTitle(text);
        alert('Response from CORS request to ' + url + ': ' + title);
    };

    xhr.onerror = function () {
        alert('Woops, there was an error making the request.');
    };

    xhr.send();
}


var url = 'http://alice.com/cors';
var xhr = createCORSRequest('GET', url);
xhr.send();


//HTTP简单请求： 

//GET /cors HTTP/1.1
//Origin: http://api.alice.com
//Host: api.bob.com
//Accept-Language: en-US
//Connection: keep-alive
//User-Agent: Mozilla/5.0...

//HTTP复杂请求： 
var url = 'http://alice.com/cors';
var xhr = createCORSRequest('PUT', url);
xhr.setRequestHeader(
    'X-Custom-Header', 'value');
xhr.send();
//预请求：

//OPTIONS /cors HTTP/1.1
//Origin: http://api.alice.com
//Access-Control-Request-Method: PUT
//Access-Control-Request-Headers: X-Custom-Header
//Host: api.bob.com
//Accept-Language: en-US
//Connection: keep-alive
//User-Agent: Mozilla/5.0...