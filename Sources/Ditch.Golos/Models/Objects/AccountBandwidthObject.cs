﻿using System;
using Ditch.Golos.Models.Enums;
using Newtonsoft.Json;

namespace Ditch.Golos.Models.Objects
{
    /// <summary>
    /// account_bandwidth_object
    /// libraries\chain\include\golos\chain\account_object.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class AccountBandwidthObject
    {

        // bdType : id_type
        [JsonProperty("id")]
        public object Id { get; set; }

        // bdType : account_name_type
        [JsonProperty("account")]
        public string Account { get; set; }

        // bdType : bandwidth_type
        [JsonProperty("type")]
        public BandwidthType Type { get; set; }

        // bdType : share_type
        [JsonProperty("average_bandwidth")]
        public object AverageBandwidth { get; set; }

        // bdType : share_type
        [JsonProperty("lifetime_bandwidth")]
        public object LifetimeBandwidth { get; set; }

        // bdType : time_point_sec
        [JsonProperty("last_bandwidth_update")]
        public DateTime LastBandwidthUpdate { get; set; }
    }
}
