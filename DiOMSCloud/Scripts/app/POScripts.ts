/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="General.ts" />

module Supply.PurchaseOrder {
    declare var SelectedPO: any;
    export function ShowPODetails(e, uri, idd) {
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
                $("#PODetails").html(data);
            },
            error: function (xhr, status) {
                //onAjaxComplete()
                alert(xhr.statusText);
            }
        });
    }

    export function Check_UncheckAll(ctr) {
        $("input[name*='chkPO_']").each(function () {
            //alert((this.checked ? $(this).val() : ""));
            //alert($(this).val());
            $(this).prop("checked", ctr.checked);
        })
    }

    export function AddNoteToMultiplePO(url) {
        SelectedPO = [];
        $("input[name*='chkPO_']:checked").each(function () {
            //alert((this.checked ? $(this).val() : ""));
            //alert($(this).val());
            SelectedPO.push(parseInt($(this).attr("name").split("_")[1]));
        })
        if (SelectedPO.length > 0) {
            location.href = url + '?id=' + SelectedPO;
        }
        else
            alert("Please select Purchase Order")
    }

    export function GetSelectedPO() {
        SelectedPO = [];
        $("#modalMsg").empty();
        $("#UpdateMultiPO").prop("disabled", false);
        $("input[name*='chkPO_']:checked").each(function () {
            //alert((this.checked ? $(this).val() : ""));
            //alert($(this).val());
            SelectedPO.push(parseInt($(this).attr("name").split("_")[1]));
        })
        if (SelectedPO.length > 0) {
            $("#pos").text(SelectedPO);
        }
        else {
            $("#UpdateMultiPO").prop("disabled", true);
        }
    }

    export function UpdateNoteToPO(uri, val) {
        var result = 0;
        $("#UpdateMultiPO").prop("disabled", true);
        var dd = {Note:'123', PONumber:'456'};
        $.ajax({
            url: uri,
            dataType: "json",
            type: "Post",
            data: { ids: SelectedPO, note:val, sample:dd},
            //headers: {
            //    'test': vv
            //},
            //contentType: 'application/json; charset=utf-8',
            async: false,
            cache: false,
            success: function (data) {
                //onAjaxComplete();
                // var oo = JSON.parse(data);
                //alert(oo.UserName);
                //alert(JSON.stringify(data));
                //alert(data.success);
                $("#modalMsg").text(data.message);
                result = 1;
            },
            error: function (xhr, status) {
                //onAjaxComplete()
                alert(xhr.statusText);
            }
        });
        if (result == 0)
        {
            $("#UpdateMultiPO").prop("disabled", false);
        }
        return result;
    }

    interface POAttachedNote{
        url: any;
        note:any
    }

    export class AddNotes implements POAttachedNote{
        url: string;
        note: string;
        result: number;
        constructor(url: string, note: string) {
            this.url = url;
            this.note = note;
            this.result = 0;
        }

        UpdateNote(): number {
            $("#UpdateMultiPO").prop("disabled", true);
            var dd = { Note: '123', PONumber: '456' };
            var kqua = 0;
            $.ajax({
                url: this.url,
                dataType: "json",
                type: "Post",
                data: JSON.stringify({ ids: SelectedPO, note: this.note, sample: dd }),
                //headers: {
                //    'test': vv
                //},
                contentType: 'application/json; charset=utf-8',
                async: false,
                cache: false,
                success: function (data) {
                    //onAjaxComplete();
                    // var oo = JSON.parse(data);
                    //alert(oo.UserName);
                    //alert(JSON.stringify(data));
                    //alert(data.success);
                    $("#modalMsg").text(data.message);
                    kqua = 1;
                },
                error: function (xhr, status) {
                    //onAjaxComplete()
                    alert(xhr.statusText);
                }
            });
            this.result = kqua;
            if (this.result == 0) {
                $("#UpdateMultiPO").prop("disabled", false);
            }
            return this.result;
        }
    }
}