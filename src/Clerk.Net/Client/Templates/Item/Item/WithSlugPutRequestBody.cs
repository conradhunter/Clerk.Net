// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Templates.Item.Item {
    public class WithSlugPutRequestBody : IParsable {
        /// <summary>The template body before variable interpolation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>Whether Clerk should deliver emails or SMS messages based on the current template</summary>
        public bool? DeliveredByClerk { get; set; }
        /// <summary>The local part of the From email address that will be used for emails.For example, in the address &apos;hello@example.com&apos;, the local part is &apos;hello&apos;.Applicable only to email templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromEmailName { get; set; }
#nullable restore
#else
        public string FromEmailName { get; set; }
#endif
        /// <summary>The editor markup used to generate the body of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Markup { get; set; }
#nullable restore
#else
        public string Markup { get; set; }
#endif
        /// <summary>The user-friendly name of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The email subject.Applicable only to email templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithSlugPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithSlugPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"body", n => { Body = n.GetStringValue(); } },
                {"delivered_by_clerk", n => { DeliveredByClerk = n.GetBoolValue(); } },
                {"from_email_name", n => { FromEmailName = n.GetStringValue(); } },
                {"markup", n => { Markup = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("body", Body);
            writer.WriteBoolValue("delivered_by_clerk", DeliveredByClerk);
            writer.WriteStringValue("from_email_name", FromEmailName);
            writer.WriteStringValue("markup", Markup);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
