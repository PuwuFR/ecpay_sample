using ecpay_sample.Models.ViewModel;
using ecpay_sample.ST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecpay_sample.Controllers
{
    public class EcpayController : Controller
    {
        // GET: Ecpay
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gopay()
        {
            STPay stp = new STPay();
            int Amt = 100;
            int CustomerId = 1000002;
            VMGateway vmg = new VMGateway();
            vmg.formhtml = stp.GoCC(Amt, CustomerId);
            return View(vmg);
        }

        [HttpPost]
        public void Paid()
        {
            var MerchantID= Request["MerchantID"];
            var Tid = Request["MerchantTradeNo"];
            var RtnCode= Request["RtnCode"];
            var RtnMsg = Request["RtnMsg"];
            var TradeNo = Request["TradeNo"];
            var TradeAmt = Request["TradeAmt"];
            var PayAmt = Request["PayAmt"]==null?"0": Request["PayAmt"];
            var PaymentDate = Request["PaymentDate"];
            var PaymentType = Request["PaymentType"];
            var PaymentTypeChargeFee = Request["PaymentTypeChargeFee"];
            var TradeDate = Request["TradeDate"];
            var SimulatePaid = Request["SimulatePaid"];
            string Memo = string.Empty;
           
           
            //當交易結果為成功且商家ID正確時
            if (!string.IsNullOrEmpty(Tid))
            {
                STNote stn = new STNote();
                string content = "TradeNo: " + TradeNo.ToString() + ", RtnCode: " + RtnCode.ToString() + ", RtnMsg: " + RtnMsg.ToString() + ", TradeAmt: " + TradeAmt.ToString() + ", PayAmt: " + PayAmt + ", PaymentType: " + PaymentType + ", PaymentTypeChargeFee: " + PaymentTypeChargeFee + ", TradeDate: " + TradeDate.ToString() + ", SimulatePaid: " + SimulatePaid.ToString() + ", Tid: " + Tid + ", Memo: " + Memo;
                stn.Write(content);
                Response.Write("1|OK");
            }
            Response.End();
        }
    }
}