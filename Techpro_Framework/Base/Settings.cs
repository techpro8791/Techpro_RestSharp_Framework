﻿using RestSharp;
using System;

namespace Techpro_Framework.Base
{
    public class Settings
    {
        public Uri BaseUrl { get; set; }
        public IRestResponse Response { get; set; }
        public IRestRequest Request { get; set; }
        public RestClient RestClient { get; set; } = new RestClient();
    }
}
