using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecpay_sample.Global
{
    public static class PaymentConfig
    {
        private static ECpayCOnfig _ecpay_config;
        public static ECpayCOnfig ECpayConfig { get {
                if (_ecpay_config == null)
                    _ecpay_config = new ECpayCOnfig();
                return _ecpay_config;
                    }
        }
        public class ECpayCOnfig
        {
            public ECpayCOnfig()
            {
                this.HashIV = "v77hoKGq4kWxNNIS";
                this.HashKey = "5294y06JbISpM5x9";
                this.ServiceURL = "https://payment-stage.ecpay.com.tw/Cashier/AioCheckOut/V5";
                this.MerchantID = "2000132";
            }

            public string HashKey { get; set; }
            public string HashIV { get; set; }
            public string ServiceURL { get; set; }
            public string MerchantID { get; set; }
        }
    }
}