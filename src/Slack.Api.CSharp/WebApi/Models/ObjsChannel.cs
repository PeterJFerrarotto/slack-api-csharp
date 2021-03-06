// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Channel Object
    /// </summary>
    public partial class ObjsChannel
    {
        /// <summary>
        /// Initializes a new instance of the ObjsChannel class.
        /// </summary>
        public ObjsChannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjsChannel class.
        /// </summary>
        /// <param name="unlinked">Field to determine whether a channel has
        /// ever been shared/disconnected in the past</param>
        public ObjsChannel(int created, string creator, string id, bool isChannel, bool isMpim, bool isOrgShared, bool isPrivate, bool isShared, IList<string> members, string name, string nameNormalized, ObjsChannelPurpose purpose, ObjsChannelTopic topic, string acceptedUser = default(string), bool? isArchived = default(bool?), bool? isGeneral = default(bool?), bool? isMember = default(bool?), int? isMoved = default(int?), bool? isPendingExtShared = default(bool?), bool? isReadOnly = default(bool?), string lastRead = default(string), object latest = default(object), int? numMembers = default(int?), IList<string> pendingShared = default(IList<string>), IList<string> previousNames = default(IList<string>), int? priority = default(int?), int? unlinked = default(int?), int? unreadCount = default(int?), int? unreadCountDisplay = default(int?))
        {
            AcceptedUser = acceptedUser;
            Created = created;
            Creator = creator;
            Id = id;
            IsArchived = isArchived;
            IsChannel = isChannel;
            IsGeneral = isGeneral;
            IsMember = isMember;
            IsMoved = isMoved;
            IsMpim = isMpim;
            IsOrgShared = isOrgShared;
            IsPendingExtShared = isPendingExtShared;
            IsPrivate = isPrivate;
            IsReadOnly = isReadOnly;
            IsShared = isShared;
            LastRead = lastRead;
            Latest = latest;
            Members = members;
            Name = name;
            NameNormalized = nameNormalized;
            NumMembers = numMembers;
            PendingShared = pendingShared;
            PreviousNames = previousNames;
            Priority = priority;
            Purpose = purpose;
            Topic = topic;
            Unlinked = unlinked;
            UnreadCount = unreadCount;
            UnreadCountDisplay = unreadCountDisplay;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accepted_user")]
        public string AcceptedUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_channel")]
        public bool IsChannel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_general")]
        public bool? IsGeneral { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_member")]
        public bool? IsMember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_moved")]
        public int? IsMoved { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_mpim")]
        public bool IsMpim { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_org_shared")]
        public bool IsOrgShared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_pending_ext_shared")]
        public bool? IsPendingExtShared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_private")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_read_only")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_shared")]
        public bool IsShared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_read")]
        public string LastRead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latest")]
        public object Latest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<string> Members { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name_normalized")]
        public string NameNormalized { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "num_members")]
        public int? NumMembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pending_shared")]
        public IList<string> PendingShared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previous_names")]
        public IList<string> PreviousNames { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        public ObjsChannelPurpose Purpose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "topic")]
        public ObjsChannelTopic Topic { get; set; }

        /// <summary>
        /// Gets or sets field to determine whether a channel has ever been
        /// shared/disconnected in the past
        /// </summary>
        [JsonProperty(PropertyName = "unlinked")]
        public int? Unlinked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unread_count")]
        public int? UnreadCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unread_count_display")]
        public int? UnreadCountDisplay { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Creator == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Creator");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Members == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Members");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (NameNormalized == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NameNormalized");
            }
            if (Purpose == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Purpose");
            }
            if (Topic == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Topic");
            }
            if (Members != null)
            {
                if (Members.Count < 0)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Members", 0);
                }
                if (Members.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Members)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Members");
                }
            }
            if (PendingShared != null)
            {
                if (PendingShared.Count < 0)
                {
                    throw new ValidationException(ValidationRules.MinItems, "PendingShared", 0);
                }
                if (PendingShared.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(PendingShared)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "PendingShared");
                }
            }
            if (PreviousNames != null)
            {
                if (PreviousNames.Count < 0)
                {
                    throw new ValidationException(ValidationRules.MinItems, "PreviousNames", 0);
                }
                if (PreviousNames.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(PreviousNames)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "PreviousNames");
                }
            }
            if (Purpose != null)
            {
                Purpose.Validate();
            }
            if (Topic != null)
            {
                Topic.Validate();
            }
        }
    }
}
