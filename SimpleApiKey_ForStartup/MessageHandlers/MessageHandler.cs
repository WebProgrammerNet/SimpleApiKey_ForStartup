using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace SimpleApiKey_ForStartup.MessageHandlers
{
    public class MessageHandler : DelegatingHandler
    {
        private const string ApiKeyToCheck = "5684cwevca68461rfdv83512vc";
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            bool check = false;
            IEnumerable<string> values;
            bool checkRequest = httpRequestMessage.Headers.TryGetValues("APIKey", out values);

            if (checkRequest)
            {
                if (values.FirstOrDefault().Equals(ApiKeyToCheck))
                {
                    check = true;
                }
            }

            if (!checkRequest || !check)
            {
                return httpRequestMessage.CreateResponse(HttpStatusCode.Forbidden, "Invalid ApiKey");
            }
            var response = await base.SendAsync(httpRequestMessage, cancellationToken);

            return response;
        }

    }

}