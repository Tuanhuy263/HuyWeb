/// <reference path="../../typings/jquery/jquery.d.ts" />
var Enums;
(function (Enums) {
    var StatusCode;
    (function (StatusCode) {
        StatusCode[StatusCode["OK"] = 200] = "OK";
        StatusCode[StatusCode["Conflict"] = 409] = "Conflict";
        StatusCode[StatusCode["BadRequest"] = 400] = "BadRequest";
        StatusCode[StatusCode["Unauthorized"] = 401] = "Unauthorized";
        StatusCode[StatusCode["NotFound"] = 404] = "NotFound";
        StatusCode[StatusCode["InternalServerError"] = 500] = "InternalServerError";
        StatusCode[StatusCode["ExpectationFailed"] = 417] = "ExpectationFailed";
    })(StatusCode = Enums.StatusCode || (Enums.StatusCode = {}));
})(Enums || (Enums = {}));
/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="Enums.ts" />
var General;
(function (General) {
    var Sample = /** @class */ (function () {
        function Sample(id, code) {
            this.id = id;
            this.code = code;
        }
        Sample.prototype.getId = function () {
            return this.id;
        };
        Sample.prototype.setCode = function (code) {
            this.code = code;
        };
        return Sample;
    }());
    General.Sample = Sample;
    function mm() {
        var user = {
            name: 'tuan huy',
            id: 9
        };
        return user.id;
    }
    General.mm = mm;
    General.Messages = {
        'English': { 'Logout': 'Are you sure to sign out?' }, 'VietNamese': { 'Logout': 'Bạn chắc muốn thoát ? ' }
    };
    function DisableSubmitButton(e, frm, ctr) {
        e.preventDefault();
        var val = $(frm).valid();
        if (val) {
            $(':input[type="submit"]').prop('disabled', true);
            if (ctr != null)
                $(ctr).prop('disabled', true);
            $(frm).submit();
        }
    }
    General.DisableSubmitButton = DisableSubmitButton;
    function EnableButton(id) {
        $(id).prop('disabled', false);
    }
    General.EnableButton = EnableButton;
    function DisableButton(id) {
        $(id).prop('disabled', true);
    }
    General.DisableButton = DisableButton;
    function Back() {
        window.history.back();
    }
    General.Back = Back;
    function UpdateSelection(selCtr, hidCtr) {
        $(hidCtr).val($(selCtr).val());
    }
    General.UpdateSelection = UpdateSelection;
    function setDatePickerToEditor(editors) {
        $.each(editors, function (index, val) {
            $(val).datepicker({ dateFormat: "mm/dd/yy" });
        });
    }
    General.setDatePickerToEditor = setDatePickerToEditor;
    function setMultiSelectToList(id) {
        $(id).multiselect({
            includeSelectAllOption: true
        });
    }
    General.setMultiSelectToList = setMultiSelectToList;
    function Empty(id) {
        $(id).empty();
    }
    General.Empty = Empty;
    function ok(id) {
        $(id).click(function () {
            var csrfToken = $("input[name='__RequestVerificationToken']").val();
            alert(csrfToken);
        });
    }
    General.ok = ok;
})(General || (General = {}));
/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="General.ts" />
var Item;
(function (Item) {
    function GetItems(lnk, token) {
        lnk = lnk + "Test/LoadItem";
        var val = { ERPItemCode: "EE-3186", ItemType: "" };
        var dl = { page: 1, abc: val };
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
    Item.GetItems = GetItems;
    function GetJWTToKen() {
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
    Item.GetJWTToKen = GetJWTToKen;
})(Item || (Item = {}));
/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="General.ts" />
var Supply;
(function (Supply) {
    var PurchaseOrder;
    (function (PurchaseOrder) {
        function ShowPODetails(e, uri, idd) {
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
        PurchaseOrder.ShowPODetails = ShowPODetails;
        function Check_UncheckAll(ctr) {
            $("input[name*='chkPO_']").each(function () {
                //alert((this.checked ? $(this).val() : ""));
                //alert($(this).val());
                $(this).prop("checked", ctr.checked);
            });
        }
        PurchaseOrder.Check_UncheckAll = Check_UncheckAll;
        function AddNoteToMultiplePO(url) {
            SelectedPO = [];
            $("input[name*='chkPO_']:checked").each(function () {
                //alert((this.checked ? $(this).val() : ""));
                //alert($(this).val());
                SelectedPO.push(parseInt($(this).attr("name").split("_")[1]));
            });
            if (SelectedPO.length > 0) {
                location.href = url + '?id=' + SelectedPO;
            }
            else
                alert("Please select Purchase Order");
        }
        PurchaseOrder.AddNoteToMultiplePO = AddNoteToMultiplePO;
        function GetSelectedPO() {
            SelectedPO = [];
            $("#modalMsg").empty();
            $("#UpdateMultiPO").prop("disabled", false);
            $("input[name*='chkPO_']:checked").each(function () {
                //alert((this.checked ? $(this).val() : ""));
                //alert($(this).val());
                SelectedPO.push(parseInt($(this).attr("name").split("_")[1]));
            });
            if (SelectedPO.length > 0) {
                $("#pos").text(SelectedPO);
            }
            else {
                $("#UpdateMultiPO").prop("disabled", true);
            }
        }
        PurchaseOrder.GetSelectedPO = GetSelectedPO;
        function UpdateNoteToPO(uri, val) {
            var result = 0;
            $("#UpdateMultiPO").prop("disabled", true);
            var dd = { Note: '123', PONumber: '456' };
            $.ajax({
                url: uri,
                dataType: "json",
                type: "Post",
                data: { ids: SelectedPO, note: val, sample: dd },
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
            if (result == 0) {
                $("#UpdateMultiPO").prop("disabled", false);
            }
            return result;
        }
        PurchaseOrder.UpdateNoteToPO = UpdateNoteToPO;
        var AddNotes = /** @class */ (function () {
            function AddNotes(url, note) {
                this.url = url;
                this.note = note;
                this.result = 0;
            }
            AddNotes.prototype.UpdateNote = function () {
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
            };
            return AddNotes;
        }());
        PurchaseOrder.AddNotes = AddNotes;
    })(PurchaseOrder = Supply.PurchaseOrder || (Supply.PurchaseOrder = {}));
})(Supply || (Supply = {}));
/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="General.ts" />
var Demand;
(function (Demand) {
    var SalesOrder;
    (function (SalesOrder) {
        function UpdateSONote(e) {
            e.preventDefault();
            var val = '@Url.Action("Edit", "SO", new { area = "Demand" })';
            alert('hh');
            var up = { Note: $("#Note").val, ID: '@Model.ID', SONumber: '@Model.SONumber' };
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
        SalesOrder.UpdateSONote = UpdateSONote;
        function Filter(frm, e, hidden, multiselect) {
            e.preventDefault();
            var selected_val = $(multiselect).val();
            $(hidden).val(selected_val);
            $(frm).submit();
        }
        SalesOrder.Filter = Filter;
        function ShowSODetails(e, uri, idd) {
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
        SalesOrder.ShowSODetails = ShowSODetails;
        function AddNoteToMultipleSO(url) {
            SelectedSO = [];
            $("input[name*='chkSO_']:checked").each(function () {
                //alert((this.checked ? $(this).val() : ""));
                //alert($(this).val());
                SelectedSO.push(parseInt($(this).attr("name").split("_")[1]));
            });
            if (SelectedSO.length > 0) {
                location.href = url + '?id=' + SelectedSO;
            }
            else
                alert("Please select Sales Order");
        }
        SalesOrder.AddNoteToMultipleSO = AddNoteToMultipleSO;
        function Check_UncheckAll(ctr) {
            $("input[name*='chkSO_']").each(function () {
                //alert((this.checked ? $(this).val() : ""));
                //alert($(this).val());
                $(this).prop("checked", ctr.checked);
            });
        }
        SalesOrder.Check_UncheckAll = Check_UncheckAll;
        function thunghiem() {
            SelectedSO = [];
            //var arrs = [];
            $("input[name*='chkSO_']:checked").each(function () {
                //alert((this.checked ? $(this).val() : ""));
                //alert($(this).val());
                SelectedSO.push(parseInt($(this).attr("name").split("_")[1]));
            });
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
    })(SalesOrder = Demand.SalesOrder || (Demand.SalesOrder = {}));
})(Demand || (Demand = {}));
/// <reference path="../../typings/jquery/jquery.d.ts" />
var Security;
(function (Security) {
    function DisableSubmitButton(e) {
        e.preventDefault();
        $("#loginFrm").submit();
        $(':input[type="submit"]').prop('disabled', true);
    }
    Security.DisableSubmitButton = DisableSubmitButton;
    function SwitchLanguage(ctr, url, returnURL) {
        //sessionStorage.setItem('Language', $(ctr).val());
        //var tt = '@'
        //'@Url.Action("Login","Security",new { area = "" })';
        //alert(tt);
        location.href = url + "?returnUrl=" + returnURL + "&lang=" + $(ctr).val();
        //location.reload();
    }
    Security.SwitchLanguage = SwitchLanguage;
})(Security || (Security = {}));
//# sourceMappingURL=advanceScript.js.map