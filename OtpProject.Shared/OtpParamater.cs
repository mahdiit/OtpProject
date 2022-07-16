using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OtpProject.Shared
{
    public class OtpParamater
    {
        public OtpParamater(string otpUrl = "otpauth://totp/{0}?secret={1}&issuer={2}&algorithm={3}&digits={4}&period={5}")
        {
            OtpUrl = otpUrl;
        }

        public string OtpUrl { get; }

        public string Account { get; set; }
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public OtpParamHash Hash { get; set; }
        public OtpParamTime Time { get; set; }
        public OtpParamDigit Digit { get; set; }

        public override string ToString()
        {
            var domain = Issuer + ":" + Account;
            domain = HttpUtility.UrlEncode(domain);

            return String.Format(OtpUrl, 
                domain, 
                Secret, 
                HttpUtility.UrlEncode(Issuer),
                Hash.ToString(),
                ((int)Digit).ToString(),
                ((int)Time).ToString()
                );
        }
    }
}
