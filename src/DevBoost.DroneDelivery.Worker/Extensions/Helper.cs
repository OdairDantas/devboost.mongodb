using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace DevBoost.DroneDelivery.Worker.Extensions
{
    public static  class Helper
    {

        public static ByteArrayContent ConvertObjectToByteArrayContent(this string valor)
        {
            ByteArrayContent byteContent = new ByteArrayContent((Encoding.UTF8.GetBytes(valor)));
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return byteContent;
        }
    }
}
