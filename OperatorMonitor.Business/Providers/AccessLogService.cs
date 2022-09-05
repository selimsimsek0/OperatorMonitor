using Newtonsoft.Json;
using OperatorMonitor.Business.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OperatorMonitor.Business.Providers
{
    public class AccessLogService:IAccessLogService
    {
        private HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.ConnectionClose = true;
            return client;
        }
        public async Task<ServiceResult<AccessLogDto>> GetOperationLog()
        {
            ServiceResult<AccessLogDto> retVal = new ServiceResult<AccessLogDto>();
            retVal.Data = null;
            try
            {
                HttpClient client = GetHttpClient();
                HttpResponseMessage responseMessage = await client.GetAsync(ServiceEndPoints.AccesLog);

                if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    retVal.Response = false;
                    retVal.Message = $"Servis hatası: {(int)responseMessage.StatusCode} {responseMessage.StatusCode}";
                }
                else
                {
                    string serviceContent = await responseMessage.Content.ReadAsStringAsync();
                    string jsonConvertString = JsonConvert.DeserializeObject<string>(serviceContent);
                    AccessLogDto logResult = JsonConvert.DeserializeObject<AccessLogDto>(jsonConvertString);
                    if (logResult == null)
                    {
                        retVal.Message = "Servisten veri getirilemiyor.";
                        retVal.Response = false;
                    }
                    else
                    {
                        retVal.Message = "Başarılı";
                        retVal.Response = true;
                        retVal.Data = logResult;
                    }
                }

            }
            catch (Exception exp)
            {
                retVal.Message = exp.Message;
                retVal.Response = false;
                retVal.Data = null;
            }
            return retVal;
        }

        public async Task<bool> ConfirmVerification(string logId)
        {
            bool retVal = true;
            try
            {

                HttpClient client = GetHttpClient();

                ConfirmVerificationModel model = new ConfirmVerificationModel { LogID = logId, Description = $"Operator confirmed the verification." };
                string jsonModel = JsonConvert.SerializeObject(model);
                HttpResponseMessage response = await client.PostAsync(ServiceEndPoints.AccesLog, new StringContent(jsonModel, Encoding.UTF8, "application/json"));
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    retVal = false;
                }
            }
            catch
            {
                retVal = false;
            }

            return retVal;
        }

    }
}
