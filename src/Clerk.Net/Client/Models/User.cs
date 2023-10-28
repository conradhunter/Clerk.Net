// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class User : IParsable {
        /// <summary>The backup_code_enabled property</summary>
        public bool? BackupCodeEnabled { get; set; }
        /// <summary>Flag to denote whether user is banned or not.</summary>
        public bool? Banned { get; set; }
        /// <summary>The birthday property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Birthday { get; set; }
#nullable restore
#else
        public string Birthday { get; set; }
#endif
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>If enabled, user can create organizations via FAPI.</summary>
        public bool? CreateOrganizationEnabled { get; set; }
        /// <summary>If enabled, user can delete themselves via FAPI.</summary>
        public bool? DeleteSelfEnabled { get; set; }
        /// <summary>The email_addresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmailAddress>? EmailAddresses { get; set; }
#nullable restore
#else
        public List<EmailAddress> EmailAddresses { get; set; }
#endif
        /// <summary>The external_accounts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<User_external_accounts>? ExternalAccounts { get; set; }
#nullable restore
#else
        public List<User_external_accounts> ExternalAccounts { get; set; }
#endif
        /// <summary>The external_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The first_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The gender property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Gender { get; set; }
#nullable restore
#else
        public string Gender { get; set; }
#endif
        /// <summary>The has_image property</summary>
        public bool? HasImage { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The image_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl { get; set; }
#nullable restore
#else
        public string ImageUrl { get; set; }
#endif
        /// <summary>The last_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Unix timestamp of last sign-in.</summary>
        public long? LastSignInAt { get; set; }
        /// <summary>Flag to denote whether user is currently locked, i.e. restricted from signing in or not.</summary>
        public bool? Locked { get; set; }
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public User_object? Object { get; set; }
        /// <summary>The password_enabled property</summary>
        public bool? PasswordEnabled { get; set; }
        /// <summary>The phone_numbers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PhoneNumber>? PhoneNumbers { get; set; }
#nullable restore
#else
        public List<PhoneNumber> PhoneNumbers { get; set; }
#endif
        /// <summary>The primary_email_address_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryEmailAddressId { get; set; }
#nullable restore
#else
        public string PrimaryEmailAddressId { get; set; }
#endif
        /// <summary>The primary_phone_number_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryPhoneNumberId { get; set; }
#nullable restore
#else
        public string PrimaryPhoneNumberId { get; set; }
#endif
        /// <summary>The primary_web3_wallet_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryWeb3WalletId { get; set; }
#nullable restore
#else
        public string PrimaryWeb3WalletId { get; set; }
#endif
        /// <summary>The private_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public User_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public User_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>The profile_image_url property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileImageUrl { get; set; }
#nullable restore
#else
        public string ProfileImageUrl { get; set; }
#endif
        /// <summary>The public_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public User_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public User_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The saml_accounts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SAMLAccount>? SamlAccounts { get; set; }
#nullable restore
#else
        public List<SAMLAccount> SamlAccounts { get; set; }
#endif
        /// <summary>The totp_enabled property</summary>
        public bool? TotpEnabled { get; set; }
        /// <summary>The two_factor_enabled property</summary>
        public bool? TwoFactorEnabled { get; set; }
        /// <summary>The unsafe_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public User_unsafe_metadata? UnsafeMetadata { get; set; }
#nullable restore
#else
        public User_unsafe_metadata UnsafeMetadata { get; set; }
#endif
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>The username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>The web3_wallets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Web3Wallet>? Web3Wallets { get; set; }
#nullable restore
#else
        public List<Web3Wallet> Web3Wallets { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static User CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"backup_code_enabled", n => { BackupCodeEnabled = n.GetBoolValue(); } },
                {"banned", n => { Banned = n.GetBoolValue(); } },
                {"birthday", n => { Birthday = n.GetStringValue(); } },
                {"create_organization_enabled", n => { CreateOrganizationEnabled = n.GetBoolValue(); } },
                {"created_at", n => { CreatedAt = n.GetLongValue(); } },
                {"delete_self_enabled", n => { DeleteSelfEnabled = n.GetBoolValue(); } },
                {"email_addresses", n => { EmailAddresses = n.GetCollectionOfObjectValues<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"external_accounts", n => { ExternalAccounts = n.GetCollectionOfObjectValues<User_external_accounts>(User_external_accounts.CreateFromDiscriminatorValue)?.ToList(); } },
                {"external_id", n => { ExternalId = n.GetStringValue(); } },
                {"first_name", n => { FirstName = n.GetStringValue(); } },
                {"gender", n => { Gender = n.GetStringValue(); } },
                {"has_image", n => { HasImage = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"image_url", n => { ImageUrl = n.GetStringValue(); } },
                {"last_name", n => { LastName = n.GetStringValue(); } },
                {"last_sign_in_at", n => { LastSignInAt = n.GetLongValue(); } },
                {"locked", n => { Locked = n.GetBoolValue(); } },
                {"object", n => { Object = n.GetEnumValue<User_object>(); } },
                {"password_enabled", n => { PasswordEnabled = n.GetBoolValue(); } },
                {"phone_numbers", n => { PhoneNumbers = n.GetCollectionOfObjectValues<PhoneNumber>(PhoneNumber.CreateFromDiscriminatorValue)?.ToList(); } },
                {"primary_email_address_id", n => { PrimaryEmailAddressId = n.GetStringValue(); } },
                {"primary_phone_number_id", n => { PrimaryPhoneNumberId = n.GetStringValue(); } },
                {"primary_web3_wallet_id", n => { PrimaryWeb3WalletId = n.GetStringValue(); } },
                {"private_metadata", n => { PrivateMetadata = n.GetObjectValue<User_private_metadata>(User_private_metadata.CreateFromDiscriminatorValue); } },
                {"profile_image_url", n => { ProfileImageUrl = n.GetStringValue(); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<User_public_metadata>(User_public_metadata.CreateFromDiscriminatorValue); } },
                {"saml_accounts", n => { SamlAccounts = n.GetCollectionOfObjectValues<SAMLAccount>(SAMLAccount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totp_enabled", n => { TotpEnabled = n.GetBoolValue(); } },
                {"two_factor_enabled", n => { TwoFactorEnabled = n.GetBoolValue(); } },
                {"unsafe_metadata", n => { UnsafeMetadata = n.GetObjectValue<User_unsafe_metadata>(User_unsafe_metadata.CreateFromDiscriminatorValue); } },
                {"updated_at", n => { UpdatedAt = n.GetLongValue(); } },
                {"username", n => { Username = n.GetStringValue(); } },
                {"web3_wallets", n => { Web3Wallets = n.GetCollectionOfObjectValues<Web3Wallet>(Web3Wallet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("backup_code_enabled", BackupCodeEnabled);
            writer.WriteBoolValue("banned", Banned);
            writer.WriteStringValue("birthday", Birthday);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteBoolValue("create_organization_enabled", CreateOrganizationEnabled);
            writer.WriteBoolValue("delete_self_enabled", DeleteSelfEnabled);
            writer.WriteCollectionOfObjectValues<EmailAddress>("email_addresses", EmailAddresses);
            writer.WriteCollectionOfObjectValues<User_external_accounts>("external_accounts", ExternalAccounts);
            writer.WriteStringValue("external_id", ExternalId);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteStringValue("gender", Gender);
            writer.WriteBoolValue("has_image", HasImage);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("image_url", ImageUrl);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteLongValue("last_sign_in_at", LastSignInAt);
            writer.WriteBoolValue("locked", Locked);
            writer.WriteEnumValue<User_object>("object", Object);
            writer.WriteBoolValue("password_enabled", PasswordEnabled);
            writer.WriteCollectionOfObjectValues<PhoneNumber>("phone_numbers", PhoneNumbers);
            writer.WriteStringValue("primary_email_address_id", PrimaryEmailAddressId);
            writer.WriteStringValue("primary_phone_number_id", PrimaryPhoneNumberId);
            writer.WriteStringValue("primary_web3_wallet_id", PrimaryWeb3WalletId);
            writer.WriteObjectValue<User_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteStringValue("profile_image_url", ProfileImageUrl);
            writer.WriteObjectValue<User_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteCollectionOfObjectValues<SAMLAccount>("saml_accounts", SamlAccounts);
            writer.WriteBoolValue("totp_enabled", TotpEnabled);
            writer.WriteBoolValue("two_factor_enabled", TwoFactorEnabled);
            writer.WriteObjectValue<User_unsafe_metadata>("unsafe_metadata", UnsafeMetadata);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteStringValue("username", Username);
            writer.WriteCollectionOfObjectValues<Web3Wallet>("web3_wallets", Web3Wallets);
        }
    }
}
