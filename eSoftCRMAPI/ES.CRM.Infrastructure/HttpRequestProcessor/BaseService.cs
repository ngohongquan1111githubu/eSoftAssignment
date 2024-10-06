using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.CRM.Infrastructure.HttpRequestProcessor
{
    public class BaseService
    {
        public OutputBaseApi<T> HandlerLogicData<T, G>(
            ResultCommon<G> resultBackend,
            string requestId,
            Func<G, OutputBaseApi<T>> funcHttpSuccess)
        {
            var result = new OutputBaseApi<T>();

            if (resultBackend.Status)
            {
                var dataBackend = resultBackend.DataObject;
                result = funcHttpSuccess(dataBackend);
            }
            else
            {
                var statusResult = new StatusOutputBaseApi();

                if (!string.IsNullOrEmpty(resultBackend.Message))
                {
                    // Handle backend error
                    statusResult.StatusCode = StatusOutputBaseApi.StatusCodeErrorBackend;
                    statusResult.StatusDesc = resultBackend.Message;
                }
                else if (resultBackend.ErrorInfo.Count > 0)
                {
                    switch (resultBackend.ErrorInfo[0].ErrorCode)
                    {
                        case HttpResultCommon.StatusTimeout:
                            statusResult.StatusCode = StatusOutputBaseApi.StatusCodeTimeout;
                            statusResult.StatusDesc = "Timeout Backend";
                            break;
                        case HttpResultCommon.StatusConnectionRefused:
                            statusResult.StatusCode = StatusOutputBaseApi.StatusCodeErrorBackend;
                            statusResult.StatusDesc = "Connection Refused";
                            break;
                        default:
                            statusResult.StatusCode = StatusOutputBaseApi.StatusCodeServerError;
                            statusResult.StatusDesc = resultBackend.Error;
                            break;
                    }
                }

                result.Status = statusResult;
            }

            result.RequestId = requestId;
            return result;
        }
    }

}
