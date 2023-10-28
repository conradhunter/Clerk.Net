// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class OrganizationSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The default for whether an admin can delete an organization with the Frontend API.</summary>
        public bool? AdminDeleteEnabled { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The max_allowed_memberships property</summary>
        public int? MaxAllowedMemberships { get; set; }
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public OrganizationSettings_object? Object { get; set; }
        /// <summary>
        /// Instantiates a new OrganizationSettings and sets the default values.
        /// </summary>
        public OrganizationSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrganizationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"admin_delete_enabled", n => { AdminDeleteEnabled = n.GetBoolValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"max_allowed_memberships", n => { MaxAllowedMemberships = n.GetIntValue(); } },
                {"object", n => { Object = n.GetEnumValue<OrganizationSettings_object>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("admin_delete_enabled", AdminDeleteEnabled);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteIntValue("max_allowed_memberships", MaxAllowedMemberships);
            writer.WriteEnumValue<OrganizationSettings_object>("object", Object);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
