using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtpNet;
using QRCoder;

namespace OtpProject.Shared
{
    public static class OtpUtility
    {
        public static string GenerateKey()
        {
            var guid = Guid.NewGuid();
            return GenerateKey(guid);
        }

        public static string GenerateKey(Guid guid)
        {
            var secrectKey = guid.ToByteArray();
            return Base32.ToBase32String(secrectKey, false);
        }

        public static Image GenerateOtpQrcode(OtpParamater paramater, int eccLevel = 2)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(paramater.ToString(), (QRCodeGenerator.ECCLevel)eccLevel))
                {
                    using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
                    {
                        byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);
                        using (var ms = new MemoryStream(qrCodeAsPngByteArr))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        public static string ComputeOtp(Guid guid)
        {
            return ComputeOtp(guid.ToByteArray());
        }

        public static string ComputeOtp(byte[] secretKey)
        {
            return (new Totp(secretKey)).ComputeTotp();
        }

        public static bool VerifyOtp(Guid id, string check)
        {
            return VerifyOtp(id.ToByteArray(), check);
        }
        public static bool VerifyOtp(byte[] secretKey, string check)
        {
            long dt;
            return (new Totp(secretKey)).VerifyTotp(check, out dt);
        }
    }
}
