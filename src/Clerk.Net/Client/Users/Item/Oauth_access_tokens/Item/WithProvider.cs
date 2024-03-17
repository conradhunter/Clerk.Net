// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Users.Item.Oauth_access_tokens.Item {
    public class WithProvider : IParsable {
        /// <summary>The label property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The object property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Object { get; set; }
#nullable restore
#else
        public string Object { get; set; }
#endif
        /// <summary>The ID of the provider</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>The public_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WithProvider_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public WithProvider_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The list of scopes that the token is valid for.Only present for OAuth 2.0 tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Scopes { get; set; }
#nullable restore
#else
        public List<string> Scopes { get; set; }
#endif
        /// <summary>The access token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The token secret. Only present for OAuth 1.0 tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenSecret { get; set; }
#nullable restore
#else
        public string TokenSecret { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WithProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"label", n => { Label = n.GetStringValue(); } },
                {"object", n => { Object = n.GetStringValue(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<WithProvider_public_metadata>(WithProvider_public_metadata.CreateFromDiscriminatorValue); } },
                {"scopes", n => { Scopes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"token_secret", n => { TokenSecret = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("object", Object);
            writer.WriteStringValue("provider", Provider);
            writer.WriteObjectValue<WithProvider_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteCollectionOfPrimitiveValues<string>("scopes", Scopes);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("token_secret", TokenSecret);
        }
    }
}
