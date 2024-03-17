// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class Domain : IAdditionalDataHolder, IParsable {
        /// <summary>Null for satellite domains.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountsPortalUrl { get; set; }
#nullable restore
#else
        public string AccountsPortalUrl { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cname_targets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CNameTarget>? CnameTargets { get; set; }
#nullable restore
#else
        public List<CNameTarget> CnameTargets { get; set; }
#endif
        /// <summary>The development_origin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevelopmentOrigin { get; set; }
#nullable restore
#else
        public string DevelopmentOrigin { get; set; }
#endif
        /// <summary>The frontend_api_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FrontendApiUrl { get; set; }
#nullable restore
#else
        public string FrontendApiUrl { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The is_satellite property</summary>
        public bool? IsSatellite { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The object property</summary>
        public Domain_object? Object { get; set; }
        /// <summary>The proxy_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyUrl { get; set; }
#nullable restore
#else
        public string ProxyUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Domain"/> and sets the default values.
        /// </summary>
        public Domain() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Domain"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Domain CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Domain();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accounts_portal_url", n => { AccountsPortalUrl = n.GetStringValue(); } },
                {"cname_targets", n => { CnameTargets = n.GetCollectionOfObjectValues<CNameTarget>(CNameTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"development_origin", n => { DevelopmentOrigin = n.GetStringValue(); } },
                {"frontend_api_url", n => { FrontendApiUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"is_satellite", n => { IsSatellite = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"object", n => { Object = n.GetEnumValue<Domain_object>(); } },
                {"proxy_url", n => { ProxyUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accounts_portal_url", AccountsPortalUrl);
            writer.WriteCollectionOfObjectValues<CNameTarget>("cname_targets", CnameTargets);
            writer.WriteStringValue("development_origin", DevelopmentOrigin);
            writer.WriteStringValue("frontend_api_url", FrontendApiUrl);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("is_satellite", IsSatellite);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<Domain_object>("object", Object);
            writer.WriteStringValue("proxy_url", ProxyUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
