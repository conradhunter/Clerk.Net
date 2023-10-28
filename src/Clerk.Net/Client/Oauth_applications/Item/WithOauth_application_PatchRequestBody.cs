// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Oauth_applications.Item {
    public class WithOauth_application_PatchRequestBody : IParsable {
        /// <summary>The new callback URL of the OAuth application</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallbackUrl { get; set; }
#nullable restore
#else
        public string CallbackUrl { get; set; }
#endif
        /// <summary>The new name of the OAuth application</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Define the allowed scopes for the new OAuth applications that dictate the user payload of the OAuth user info endpoint. Available scopes are `profile`, `email`, `public_metadata`, `private_metadata`. Provide the requested scopes as a string, separated by spaces.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scopes { get; set; }
#nullable restore
#else
        public string Scopes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new WithOauth_application_PatchRequestBody and sets the default values.
        /// </summary>
        public WithOauth_application_PatchRequestBody() {
            Scopes = "profile email";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithOauth_application_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithOauth_application_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callback_url", n => { CallbackUrl = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scopes", n => { Scopes = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callback_url", CallbackUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("scopes", Scopes);
        }
    }
}
