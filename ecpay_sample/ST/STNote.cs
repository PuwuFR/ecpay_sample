using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ecpay_sample.ST
{
    public class STNote
    {
        public void Write(string content= "Hello World!")
    {
        FileStream fs = new FileStream("C:\\Users\\bob\\Downloads\\ak.txt", FileMode.Create);
        //獲得位元組陣列
        byte[] data = System.Text.Encoding.Default.GetBytes(content);
        //開始寫入
        fs.Write(data, 0, data.Length);
        //清空緩衝區、關閉流
        fs.Flush();
        fs.Close();
        }

    }
}