using Newtonsoft.Json;

namespace Ditch.Steem.Models.Args
{
    /// <summary>
    /// get_blog_authors_args
    /// libraries\plugins\apis\follow_api\include\steem\plugins\follow_api\follow_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class GetBlogAuthorsArgs
    {

        /// <summary>
        /// API name: blog_account
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("blog_account")]
        public string BlogAccount {get; set;}
    }
}
