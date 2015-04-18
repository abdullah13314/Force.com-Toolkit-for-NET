﻿using Newtonsoft.Json;

namespace Salesforce.Chatter.Models
{
    /// <summary>
    /// This class is similar to the FeedItemInput class, but only contains one of the optional properties.
    /// This property takes precedence over all other parameters.
    /// </summary>
    public class SharedFeedItemInput
    {
        [JsonProperty(PropertyName = "originalFeedItemId")]
        public string OriginalFeedItemId { get; set; }
    }
}
