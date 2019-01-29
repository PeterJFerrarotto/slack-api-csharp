// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// User profile object
    /// </summary>
    public partial class ObjsUserProfile
    {
        /// <summary>
        /// Initializes a new instance of the ObjsUserProfile class.
        /// </summary>
        public ObjsUserProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjsUserProfile class.
        /// </summary>
        public ObjsUserProfile(string avatarHash, string displayName, string displayNameNormalized, string image192, string image24, string image32, string image48, string image72, string realName, string realNameNormalized, bool? alwaysActive = default(bool?), string email = default(string), object fields = default(object), string firstName = default(string), string guestChannels = default(string), string image512 = default(string), string imageOriginal = default(string), string lastName = default(string), string phone = default(string), string skype = default(string), string statusEmoji = default(string), int? statusExpiration = default(int?), string statusText = default(string), string statusTextCanonical = default(string), string team = default(string), string title = default(string))
        {
            AlwaysActive = alwaysActive;
            AvatarHash = avatarHash;
            DisplayName = displayName;
            DisplayNameNormalized = displayNameNormalized;
            Email = email;
            Fields = fields;
            FirstName = firstName;
            GuestChannels = guestChannels;
            Image192 = image192;
            Image24 = image24;
            Image32 = image32;
            Image48 = image48;
            Image512 = image512;
            Image72 = image72;
            ImageOriginal = imageOriginal;
            LastName = lastName;
            Phone = phone;
            RealName = realName;
            RealNameNormalized = realNameNormalized;
            Skype = skype;
            StatusEmoji = statusEmoji;
            StatusExpiration = statusExpiration;
            StatusText = statusText;
            StatusTextCanonical = statusTextCanonical;
            Team = team;
            Title = title;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "always_active")]
        public bool? AlwaysActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "avatar_hash")]
        public string AvatarHash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name_normalized")]
        public string DisplayNameNormalized { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public object Fields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "guest_channels")]
        public string GuestChannels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_192")]
        public string Image192 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_24")]
        public string Image24 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_32")]
        public string Image32 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_48")]
        public string Image48 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_512")]
        public string Image512 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_72")]
        public string Image72 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_original")]
        public string ImageOriginal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "real_name_normalized")]
        public string RealNameNormalized { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skype")]
        public string Skype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status_emoji")]
        public string StatusEmoji { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status_expiration")]
        public int? StatusExpiration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status_text")]
        public string StatusText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status_text_canonical")]
        public string StatusTextCanonical { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team")]
        public string Team { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AvatarHash == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AvatarHash");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (DisplayNameNormalized == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayNameNormalized");
            }
            if (Image192 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image192");
            }
            if (Image24 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image24");
            }
            if (Image32 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image32");
            }
            if (Image48 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image48");
            }
            if (Image72 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image72");
            }
            if (RealName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RealName");
            }
            if (RealNameNormalized == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RealNameNormalized");
            }
        }
    }
}
