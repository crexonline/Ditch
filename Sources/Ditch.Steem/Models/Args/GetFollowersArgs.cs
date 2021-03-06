using System;
using Newtonsoft.Json;
using Ditch.Steem.Models.Enums;

namespace Ditch.Steem.Models.Args
{
    /// <summary>
    /// get_followers_args
    /// libraries\plugins\apis\follow_api\include\steem\plugins\follow_api\follow_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class GetFollowersArgs
    {

        /// <summary>
        /// API name: account
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("account")]
        public string Account {get; set;}

        /// <summary>
        /// API name: start
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("start")]
        public string Start {get; set;}

        /// <summary>
        /// API name: type
        /// 
        /// </summary>
        /// <returns>API type: follow_type</returns>
        [JsonProperty("type")]
        public FollowType Type {get; set;}

        /// <summary>
        /// API name: limit
        /// = 1000;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("limit")]
        public UInt32 Limit {get; set;}
    }
}
