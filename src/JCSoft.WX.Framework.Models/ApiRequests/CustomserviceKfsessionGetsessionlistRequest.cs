﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCSoft.WX.Framework.Models.ApiResponses;

namespace JCSoft.WX.Framework.Models.ApiRequests
{
    public class CustomserviceKfsessionGetsessionlistRequest : ApiGetNeedTokenRequest<CustomserviceKfsessionGetsessionlistResponse>
    {
        public string KfAccount { get; set; }

        protected override string UrlFormat
        {
            get { return "https://api.weixin.qq.com/customservice/kfsession/getsessionlist?access_token={0}&kf_account={1}"; }
        }

        public override string GetUrl()
        {
            return String.Format(UrlFormat, AccessToken, KfAccount);
        }
    }
}
