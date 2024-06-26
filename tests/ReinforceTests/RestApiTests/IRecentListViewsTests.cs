using System.Threading;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using FluentAssertions;
using Reinforce.RestApi;
using Reinforce.Constants;
using Reinforce.RestApi.Models;
using Xunit;

namespace ReinforceTests.RestApiTests
{
    public class IRecentListViewsTests
    {
        [Theory, AutoData]
        public async Task IRecentListViews(ListViewsResponse expected, string sobjectType)
        {
            using var handler = MockHttpMessageHandler.SetupHandler(expected);
            var api = handler.SetupApi<IRecentListViews>();
            var result = await api.GetAsync(sobjectType);
            result.Should().BeEquivalentTo(expected);
            handler.ConfirmPath($"/services/data/{Api.Version}/sobjects/{sobjectType}/listviews/recent");
        }

        [Theory, AutoData]
        public async Task IRecentListViews_ApiVersion(ListViewsResponse expected, string sobjectType)
        {
            using var handler = MockHttpMessageHandler.SetupHandler(expected);
            var api = handler.SetupApi<IRecentListViews>();
            var result = await api.GetAsync(sobjectType, CancellationToken.None, "v56.0");
            result.Should().BeEquivalentTo(expected);
            handler.ConfirmPath($"/services/data/v56.0/sobjects/{sobjectType}/listviews/recent");
        }
    }
}