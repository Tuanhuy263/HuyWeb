/// <reference path="../../typings/jquery/jquery.d.ts" />
module Security {
    export function DisableSubmitButton(e) {
        e.preventDefault();
        $("#loginFrm").submit();
        $(':input[type="submit"]').prop('disabled', true);
    }

    export function SwitchLanguage(ctr,url,returnURL) {
        //sessionStorage.setItem('Language', $(ctr).val());
        //var tt = '@'
            //'@Url.Action("Login","Security",new { area = "" })';
        //alert(tt);
        location.href = url + "?returnUrl=" + returnURL + "&lang=" + $(ctr).val();
        //location.reload();
    }
}