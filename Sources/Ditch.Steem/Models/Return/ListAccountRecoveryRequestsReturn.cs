using Ditch.Steem.Models.Objects;
using Newtonsoft.Json;

namespace Ditch.Steem.Models.Return
{
    /// <summary>
    /// list_account_recovery_requests_return
    /// libraries\plugins\apis\database_api\include\steem\plugins\database_api\database_api_args.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class ListAccountRecoveryRequestsReturn
    {

        /// <summary>
        /// API name: requests
        /// 
        /// </summary>
        /// <returns>API type: api_account_recovery_request_object</returns>
        [JsonProperty("requests")]
        public ApiAccountRecoveryRequestObject[] Requests {get; set;}
    }
}
