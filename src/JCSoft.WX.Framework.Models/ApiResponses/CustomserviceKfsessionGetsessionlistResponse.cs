﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCSoft.WX.Framework.Models.ApiResponses
{
    public class CustomserviceKfsessionGetsessionlistResponse : ApiResponse
    {
        [JsonProperty("sessionlist")]
        public IEnumerable<KfSession> SessionList { get; set; }
    }
}
