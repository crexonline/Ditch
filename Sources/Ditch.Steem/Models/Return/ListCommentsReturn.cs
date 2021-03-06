using Ditch.Steem.Models.Objects;
using Newtonsoft.Json;

namespace Ditch.Steem.Models.Return
{
    /// <summary>
    /// list_comments_return
    /// libraries\plugins\apis\database_api\include\steem\plugins\database_api\database_api_args.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class ListCommentsReturn
    {

        /// <summary>
        /// API name: comments
        /// 
        /// </summary>
        /// <returns>API type: api_comment_object</returns>
        [JsonProperty("comments")]
        public ApiCommentObject[] Comments {get; set;}
    }
}
