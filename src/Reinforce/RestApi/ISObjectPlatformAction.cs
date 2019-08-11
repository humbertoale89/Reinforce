using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RestEase;

namespace Reinforce.RestApi
{
    /// <summary>
    /// SObject PlatformAction
    /// PlatformAction is a virtual read-only object. It enables you to query for actions displayed in the UI, given 
    /// a user, a context, device format, and a record ID. Examples include standard and custom buttons, quick 
    /// actions, and productivity actions.
    /// https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_sobject_platformaction.htm
    /// </summary>

    public interface ISObjectPlatformAction
    {
        [Get("/services/data/v46.0/sobjects/PlatformAction?q={query}")]
        [Header("Authorization", "Bearer")]
        Task<ObjectDescribeResponse> GetAsync(
            [Path(UrlEncode = false)] string query,
            CancellationToken cancellationToken = default(CancellationToken)
        );
    }

    public class ObjectDescribeResponse
    {
        public SObject ObjectDescribe { get; set; }
        public IEnumerable<dynamic> RecentItems { get; set; }
    }
}