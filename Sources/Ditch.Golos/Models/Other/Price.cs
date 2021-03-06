﻿using Newtonsoft.Json;

namespace Ditch.Golos.Models.Other
{
    /// <summary>
    /// price
    /// libraries\protocol\include\golos\protocol\asset.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class Price
    {

        /// <summary>
        /// API name: base
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("base")]
        public Asset Base { get; set; }

        /// <summary>
        /// API name: quote
        /// 
        /// </summary>
        /// <returns>API type: asset</returns>
        [JsonProperty("quote")]
        public Asset Quote { get; set; }
    }
}