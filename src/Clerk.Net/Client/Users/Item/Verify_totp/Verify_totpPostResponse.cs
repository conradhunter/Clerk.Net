// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Users.Item.Verify_totp {
    public class Verify_totpPostResponse : IParsable {
        /// <summary>The code_type property</summary>
        public Verify_totpPostResponse_code_type? CodeType { get; set; }
        /// <summary>The verified property</summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Verify_totpPostResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Verify_totpPostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code_type", n => { CodeType = n.GetEnumValue<Verify_totpPostResponse_code_type>(); } },
                {"verified", n => { Verified = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Verify_totpPostResponse_code_type>("code_type", CodeType);
            writer.WriteBoolValue("verified", Verified);
        }
    }
}
