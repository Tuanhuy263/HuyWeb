using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud
{
    public class Enums
    {
        public enum SOStatus
        {
            //TODO: Consider add None
            //None = 0,
            DRAFT = 2,  // the order was just created in the system
            NEW = 3, //the order has been accepted
            PARTIALLY = 4, // items partially fulfilled
            FULFILLED = 5, // items fully fulfilled
            CANCEL = 6,  // order has been cancelled if the current SOStatus is new
            CLOSE = 7, // order has been closed if the current SOStatus is Partially
                       //TODO must remove SHIPMENT_REQUESTED, SHIPPED
                       //SHIPMENT_REQUESTED = 8, //the warehouse order message has been sent
                       //SHIPPED = 9 //the shipping advice has arrived	
            DROPSHIP = 8,
            DROPSHIP_PARTIALLY = 10,
            RENEW = 9,
            BACK_ORDER = 11,
            SPLITTED = 12,
            OVERSHIP = 13

        }

        public enum POStatus
        {
            //TODO: Consider add None
            //None = 0,
            //Not use pre_order 
            //PRE_ORDER = 1,
            DRAFT = 2,
            NEW = 3,
            PARTIALLY = 4,
            FULFILLED = 5,
            CANCEL = 6, // order has been cancelled if the current POStatus is new
            CLOSE = 7,  // order has been closed if the current POStatus is Partially	
            DROPSHIP = 8,
            BLIND = 9,
            RENEW = 10,
            OVERRECEIPT = 11
        }

        public enum ManagementType
        {
            None = 1,
            Batch = 2,
            Serial = 3
        }
    }
}