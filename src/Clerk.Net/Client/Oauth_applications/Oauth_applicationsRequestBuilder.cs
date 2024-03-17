// <auto-generated/>
using Clerk.Net.Client.Models;
using Clerk.Net.Client.Oauth_applications.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Oauth_applications {
    /// <summary>
    /// Builds and executes requests for operations under \oauth_applications
    /// </summary>
    public class Oauth_applicationsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Clerk.Net.Client.oauth_applications.item collection</summary>
        /// <param name="position">The ID of the OAuth application</param>
        /// <returns>A <see cref="WithOauth_application_ItemRequestBuilder"/></returns>
        public WithOauth_application_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("oauth_application_id", position);
            return new WithOauth_application_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="Oauth_applicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Oauth_applicationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oauth_applications{?limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="Oauth_applicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Oauth_applicationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oauth_applications{?limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// This request returns the list of OAuth applications for an instance.Results can be paginated using the optional `limit` and `offset` query parameters.The OAuth applications are ordered by descending creation date.Most recent OAuth applications will be returned first.
        /// </summary>
        /// <returns>A <see cref="OAuthApplications"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="ClerkErrors">When receiving a 403 status code</exception>
        /// <exception cref="ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OAuthApplications?> GetAsync(Action<RequestConfiguration<Oauth_applicationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OAuthApplications> GetAsync(Action<RequestConfiguration<Oauth_applicationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ClerkErrors.CreateFromDiscriminatorValue},
                {"403", ClerkErrors.CreateFromDiscriminatorValue},
                {"422", ClerkErrors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OAuthApplications>(requestInfo, OAuthApplications.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new OAuth application with the given name and callback URL for an instance.The callback URL must be a valid url.All URL schemes are allowed such as `http://`, `https://`, `myapp://`, etc...
        /// </summary>
        /// <returns>A <see cref="OAuthApplicationWithSecret"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="ClerkErrors">When receiving a 403 status code</exception>
        /// <exception cref="ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OAuthApplicationWithSecret?> PostAsync(Oauth_applicationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OAuthApplicationWithSecret> PostAsync(Oauth_applicationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ClerkErrors.CreateFromDiscriminatorValue},
                {"403", ClerkErrors.CreateFromDiscriminatorValue},
                {"422", ClerkErrors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OAuthApplicationWithSecret>(requestInfo, OAuthApplicationWithSecret.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This request returns the list of OAuth applications for an instance.Results can be paginated using the optional `limit` and `offset` query parameters.The OAuth applications are ordered by descending creation date.Most recent OAuth applications will be returned first.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Oauth_applicationsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Oauth_applicationsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new OAuth application with the given name and callback URL for an instance.The callback URL must be a valid url.All URL schemes are allowed such as `http://`, `https://`, `myapp://`, etc...
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Oauth_applicationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Oauth_applicationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/oauth_applications", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Oauth_applicationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Oauth_applicationsRequestBuilder WithUrl(string rawUrl) {
            return new Oauth_applicationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This request returns the list of OAuth applications for an instance.Results can be paginated using the optional `limit` and `offset` query parameters.The OAuth applications are ordered by descending creation date.Most recent OAuth applications will be returned first.
        /// </summary>
        public class Oauth_applicationsRequestBuilderGetQueryParameters {
            /// <summary>Applies a limit to the number of results returned.Can be used for paginating the results together with `offset`.Must be an integer greater than zero and less than 500.By default, if not supplied, a limit of 10 is used.</summary>
            [QueryParameter("limit")]
            public double? Limit { get; set; }
            /// <summary>Skip the first `offset` results when paginating.Needs to be an integer greater or equal to zero.To be used in conjunction with `limit`.</summary>
            [QueryParameter("offset")]
            public double? Offset { get; set; }
        }
    }
}
