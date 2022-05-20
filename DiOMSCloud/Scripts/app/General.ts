/// <reference path="../../typings/jquery/jquery.d.ts" />
/// <reference path="Enums.ts" />
module General {

    export interface kokok {
        name: string;
        id: number;
    }

    export class Sample {
        id: number;
        code: string;

        constructor(id: number, code: string) {
            this.id = id;
            this.code = code;
        }

        getId(): number {
            return this.id;
        }

        setCode(code: string): void {
            this.code = code;
        }

    }

    export function mm() {
        let user: kokok = {
            name: 'tuan huy',
            id:9
        };
        return user.id;
    }


    export let Messages = {
        'English': { 'Logout': 'Are you sure to sign out?' }, 'VietNamese': { 'Logout': 'Bạn chắc muốn thoát ? ' }
    };

    export function DisableSubmitButton(e,frm,ctr) {
        e.preventDefault();
        var val = $(frm).valid();
        if (val) {
            $(':input[type="submit"]').prop('disabled', true);
            if(ctr != null)
                $(ctr).prop('disabled', true);
            $(frm).submit();
        }
    }

    export function EnableButton(id) {
        $(id).prop('disabled', false);
    }

    export function DisableButton(id) {
        $(id).prop('disabled', true);
    }

    export function Back() {
        window.history.back();
    }

    export function UpdateSelection(selCtr, hidCtr) {
        $(hidCtr).val($(selCtr).val());
    }

    export function setDatePickerToEditor(editors) {
        $.each(editors, function (index, val) {
            $(val).datepicker({ dateFormat: "mm/dd/yy" });
        });
    }

    export function setMultiSelectToList(id) {
        $(id).multiselect({
            includeSelectAllOption: true
        });
    }

    export function Empty(id) {
        $(id).empty();
    }


    export function ok(id) {
        $(id).click(function () {
            var csrfToken = $("input[name='__RequestVerificationToken']").val();
            alert(csrfToken);
        });
    }
}