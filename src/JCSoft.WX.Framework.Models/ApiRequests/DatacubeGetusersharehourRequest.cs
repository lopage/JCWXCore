﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCSoft.WX.Framework.Models.ApiRequests
{
    public class DatacubeGetusersharehourRequest : DatacubeGetarticlesummaryRequest
    {
        protected override string UrlFormat
        {
            get
            {
                return "https://api.weixin.qq.com/datacube/getusersharehour?access_token={0}";
            }
        }
    }
}
