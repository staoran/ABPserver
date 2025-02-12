﻿using Abp.AutoMapper;
using siasun.MCS.Authentication.External;

namespace siasun.MCS.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
