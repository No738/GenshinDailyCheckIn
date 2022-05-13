﻿using Serilog;

namespace GenshinCheckIn
{
    public sealed class ClaimRewardRequest : MihoyoRequest
    {
        private static readonly string AccountInfoUrl = "https://hk4e-api-os.mihoyo.com/event/sol/sign";

        public ClaimRewardRequest(AuthenticationData authenticationData, string userAgent) : base(authenticationData, userAgent) { }

        protected override HttpRequestMessage RequestMessage
        {
            get
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{AccountInfoUrl}?act_id=e202102251931481&{AdditionalMetaParameters}");

                return requestMessage;
            }
        }
    }
}
