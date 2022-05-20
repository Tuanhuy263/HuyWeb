/// <reference path="../../typings/jquery/jquery.d.ts" />
module Enums {

    export enum StatusCode {
        OK = 200,
        Conflict = 409,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        InternalServerError = 500,
        ExpectationFailed = 417
    }
}