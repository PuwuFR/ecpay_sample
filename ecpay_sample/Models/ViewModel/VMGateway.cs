using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecpay_sample.Models.ViewModel
{
    public class VMGateway
    {
        public VMGateway(string errorcode = "0000", string errormsg = "")
        {
            this.ResultCode = errorcode;
            this.ErrorMsg = errormsg;

        }
        public string formhtml { get; set; }
        public string ErrorMsg { get; set; }
        public string ResultCode { get; set; }
    }
}