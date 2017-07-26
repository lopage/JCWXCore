﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCSoft.WX.Framework.Models.ApiRequests;
using JCSoft.WX.Framework.Models.ApiResponses;
using Xunit;

namespace FrameworkCoreTest
{
    public class ShorturlRequestTestTest : MockPostApiBaseTest<ShorturlRequest, ShorturlResponse>
    {
        protected override ShorturlRequest InitRequestObject()
        {
            return new ShorturlRequest
            {
                AccessToken = "123",
                Action = ConvertType.Long2Short,
                Url = "http://www.jamesying.com"
            };
        }

        protected override string GetReturnResult(bool errResult)
        {
            if (errResult) return s_errmsg;
            return "{\"errcode\":0,\"errmsg\":\"ok\",\"short_url\":\"http:\\/\\/w.url.cn\\/s\\/AvCo6Ih\"}";

        }

        public override ShorturlResponse GetResponse()
        {
            return mock_client.Object.Execute(Request);
        }
    }
}
