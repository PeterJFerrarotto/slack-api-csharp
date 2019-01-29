﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Slack.Api.CSharp.EventsApi;
//
//    var eventModel = EventModel.FromJson(jsonString);

namespace Slack.Api.CSharp.EventsApi
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Adapted from auto-generated content
    /// </summary>
    public partial class SlackEvent
    {
        /// <summary>
        /// Use this to distinguish which app the event belongs to if you use multiple apps with the
        /// same Request URL.
        /// </summary>
        [JsonProperty("api_app_id")]
        public string ApiAppId { get; set; }

        [JsonProperty("authed_users")]
        public List<string> AuthedUsers { get; set; }

        [JsonProperty("event")]
        public TheActualEventAnObjectThatHappened Event { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_time")]
        public long EventTime { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class TheActualEventAnObjectThatHappened
    {
        [JsonProperty("event_ts")]
        public string EventTs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class SlackEvent
    {
        public static SlackEvent FromJson(string json) => JsonConvert.DeserializeObject<SlackEvent>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SlackEvent self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}