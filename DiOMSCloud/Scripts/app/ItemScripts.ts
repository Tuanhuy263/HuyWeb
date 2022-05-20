/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="General.ts" />
module Item {
    export function GetItems(lnk, token) {
        lnk = lnk + "Test/LoadItem";
        var val = { ERPItemCode: "EE-3186", ItemType: "" };
        var dl = {page:1,abc:val}
        $.ajax({
            url: lnk,
            dataType: "json",
            type: "Get",
            data: JSON.stringify(val),
            headers: {
                Authorization: 'Bearer ' + token
            },
            contentType: 'application/json; charset=utf-8',
            async: true,
            cache: false,
            success: function (data) {
                //onAjaxComplete();
                // var oo = JSON.parse(data);
                //alert(oo.UserName);
                //alert(JSON.stringify(data));
                alert(data.Data);
            },
            error: function (xhr, status) {
                //onAjaxComplete()
                alert(xhr.statusText);
            }
        });
    }

    export function GetJWTToKen() {

        var body = {
            grant_type: 'password',
            username: "huy",
            password: "huy"
        };
        $.ajax({
            url: "http://localhost:51254/huy/token",
            dataType: "json",
            type: "Post",
            data: body,
            
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            async: true,
            cache: false, 
            success: function (data) {
                //onAjaxComplete();
                // var oo = JSON.parse(data);
                //alert(oo.UserName);
                //alert(JSON.stringify(data));
                alert(data.access_token); 
            },
            error: function (xhr, status) {
                //onAjaxComplete()
                alert(xhr.statusText);
            }
        });
    }
        
}
