// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Invitations {
    public class InvitationsPostRequestBody : IParsable {
        /// <summary>The email address the invitation will be sent to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>Metadata that will be attached to the newly created invitation.The value of this property should be a well-formed JSON object.Once the user accepts the invitation and signs up, these metadata will end up in the user&apos;s public metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InvitationsPostRequestBody_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public InvitationsPostRequestBody_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>Optional URL which specifies where to redirect the user once they click the invitation link.This is only required if you have implemented a [custom flow](https://clerk.com/docs/authentication/invitations#custom-flow) and you&apos;re not using Clerk Hosted Pages or Clerk Components.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectUrl { get; set; }
#nullable restore
#else
        public string RedirectUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InvitationsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvitationsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"email_address", n => { EmailAddress = n.GetStringValue(); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<InvitationsPostRequestBody_public_metadata>(InvitationsPostRequestBody_public_metadata.CreateFromDiscriminatorValue); } },
                {"redirect_url", n => { RedirectUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email_address", EmailAddress);
            writer.WriteObjectValue<InvitationsPostRequestBody_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteStringValue("redirect_url", RedirectUrl);
        }
    }
}
