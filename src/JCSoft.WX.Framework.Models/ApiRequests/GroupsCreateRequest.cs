﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCSoft.WX.Framework.Models.ApiResponses;

namespace JCSoft.WX.Framework.Models.ApiRequests
{
    public class GroupsCreateRequest : ApiRequest<GroupCreateResponse>
    {
        [JsonProperty("group", TypeNameHandling = TypeNameHandling.Objects)]
        public Group Group { get; set; }

        public override string Method
        {
            get { return "POST"; }
        }

        protected override string UrlFormat
        {
            get { return "https://api.weixin.qq.com/cgi-bin/groups/create?access_token={0}"; }
        }

        public override string GetUrl()
        {
            return String.Format(UrlFormat, AccessToken);
        }

        protected override bool NeedToken
        {
            get { return true; }
        }

        public override void Validate()
        {
            base.Validate();
            var namelength = this.Group.Name.Length;
            if (namelength < 0 || namelength > 30)
            {
                throw new ArgumentException("Property Name length between 1 to 30");
            }
        }

        public override string GetPostContent()
        {
            return JsonConvert.SerializeObject(new { group = Group });
        }
    }
}
