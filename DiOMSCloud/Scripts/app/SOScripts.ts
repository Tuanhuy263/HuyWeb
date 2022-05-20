/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="General.ts" />

module Demand.SalesOrder {

    declare var SelectedSO:any;

    export function UpdateSONote(e) {
        e.preventDefault();
        var val = '@Url.Action("Edit", "SO", new { area = "Demand" })';
        alert('hh');
        var up = { Note: $("#Note").val, ID : '@Model.ID', SONumber : '@Model.SONumber' };
        alert(JSON.stringify(up));
        $.ajax({
            url: val,
            dataType: "json",
            type: "Post",
            data: JSON.stringify(up),
            //headers: {
            //    'test': vv
            //},
            contentType: 'application/json; charset=utf-8',
            async: true,
            cache: false,
            success: function (data) {
                //onAjaxComplete();
                // var oo = JSON.parse(data);
                //alert(oo.UserName);
                //alert(JSON.stringify(data));
                alert(data.success);
            },
            error: function (xhr, status) {
                //onAjaxComplete()
                alert(xhr.statusText);
            }
        });
    }
    export function Filter(frm,e,hidden,multiselect) {
        e.preventDefault();
        var selected_val = $(multiselect).val();
        $(hidden).val(selected_val);
        $(frm).submit();
    }

    export function ShowSODetails(e,uri,idd) {
        e.preventDefault();
        $.ajax({
            url: uri,
            dataType: "html",
            type: "Get",
            data: { id: idd },
            //headers: {
            //    'test': vv
            //},
            //contentType: 'application/json; charset=utf-8',
            async: true,
            cache: false,
            success: function (data) {
                //onAjaxComplete();
                // var oo = JSON.parse(data);
                //alert(oo.UserName);
                //alert(JSON.stringify(data));
                //alert(data.success);
                $("#SODetails").html(data);
            },
            error: function (xhr, status) {
                //onAjaxComplete()
                alert(xhr.statusText);
            }
        });
    }

    export function AddNoteToMultipleSO(url) {
        SelectedSO = [];
        $("input[name*='chkSO_']:checked").each(function () {
            //alert((this.checked ? $(this).val() : ""));
            //alert($(this).val());
            SelectedSO.push(parseInt($(this).attr("name").split("_")[1]));
        })
        if (SelectedSO.length > 0) {
            location.href = url + '?id=' + SelectedSO;
        }
        else
            alert("Please select Sales Order")
    }

    export function Check_UncheckAll(ctr) {
        $("input[name*='chkSO_']").each(function () {
            //alert((this.checked ? $(this).val() : ""));
            //alert($(this).val());
            $(this).prop("checked", ctr.checked);
        })
    }

    function thunghiem() {
        SelectedSO = [];
        //var arrs = [];
        $("input[name*='chkSO_']:checked").each(function () {
            //alert((this.checked ? $(this).val() : ""));
            //alert($(this).val());
            SelectedSO.push(parseInt($(this).attr("name").split("_")[1]));
        })
        /////////////////////////////////////////////////////////////////////////
        var val = '@Url.Action("Create1", "SO", new { area = "Demand" })';

        //alert(JSON.stringify(up));
        var oop = { SOOriginalNo: "abc", EDISONo: "vv", HubID: "", FromSODate: null, ToSODate: null, Status: "hh" };
        $.ajax({
            url: val,
            dataType: "json",
            type: "Post",
            data: JSON.stringify({ arr: SelectedSO, objj: oop }),
            //headers: {
            //    'test': vv
            //},
            contentType: 'application/json; charset=utf-8',
            async: true,
            cache: false,
            success: function (data) {
                //onAjaxComplete();
                // var oo = JSON.parse(data);
                //alert(oo.UserName);
                alert(JSON.stringify(data));
                //alert(data.success);
            },
            error: function (xhr, status) {
                //onAjaxComplete()
                alert(xhr.statusText);
            }
        });
    }
}