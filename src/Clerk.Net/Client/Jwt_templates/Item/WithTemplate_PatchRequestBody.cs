// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Jwt_templates.Item {
    public class WithTemplate_PatchRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>JWT token allowed clock skew</summary>
        public double? AllowedClockSkew { get; set; }
        /// <summary>JWT template claims in JSON format</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WithTemplate_PatchRequestBody_claims? Claims { get; set; }
#nullable restore
#else
        public WithTemplate_PatchRequestBody_claims Claims { get; set; }
#endif
        /// <summary>Whether a custom signing key/algorithm is also provided for this template</summary>
        public bool? CustomSigningKey { get; set; }
        /// <summary>JWT token lifetime</summary>
        public double? Lifetime { get; set; }
        /// <summary>JWT template name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The custom signing algorithm to use when minting JWTs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SigningAlgorithm { get; set; }
#nullable restore
#else
        public string SigningAlgorithm { get; set; }
#endif
        /// <summary>The custom signing private key to use when minting JWTs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SigningKey { get; set; }
#nullable restore
#else
        public string SigningKey { get; set; }
#endif
        /// <summary>
        /// Instantiates a new WithTemplate_PatchRequestBody and sets the default values.
        /// </summary>
        public WithTemplate_PatchRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithTemplate_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithTemplate_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowed_clock_skew", n => { AllowedClockSkew = n.GetDoubleValue(); } },
                {"claims", n => { Claims = n.GetObjectValue<WithTemplate_PatchRequestBody_claims>(WithTemplate_PatchRequestBody_claims.CreateFromDiscriminatorValue); } },
                {"custom_signing_key", n => { CustomSigningKey = n.GetBoolValue(); } },
                {"lifetime", n => { Lifetime = n.GetDoubleValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"signing_algorithm", n => { SigningAlgorithm = n.GetStringValue(); } },
                {"signing_key", n => { SigningKey = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("allowed_clock_skew", AllowedClockSkew);
            writer.WriteObjectValue<WithTemplate_PatchRequestBody_claims>("claims", Claims);
            writer.WriteBoolValue("custom_signing_key", CustomSigningKey);
            writer.WriteDoubleValue("lifetime", Lifetime);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("signing_algorithm", SigningAlgorithm);
            writer.WriteStringValue("signing_key", SigningKey);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
