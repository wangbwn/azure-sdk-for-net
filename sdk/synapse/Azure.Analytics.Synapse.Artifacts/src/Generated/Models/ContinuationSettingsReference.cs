// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Continuation settings for execute data flow activity. </summary>
    public partial class ContinuationSettingsReference
    {
        /// <summary> Initializes a new instance of <see cref="ContinuationSettingsReference"/>. </summary>
        public ContinuationSettingsReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContinuationSettingsReference"/>. </summary>
        /// <param name="continuationTtlInMinutes"> Continuation TTL in minutes. </param>
        /// <param name="idleCondition"> Idle condition. </param>
        /// <param name="customizedCheckpointKey"> Customized checkpoint key. </param>
        internal ContinuationSettingsReference(object continuationTtlInMinutes, object idleCondition, object customizedCheckpointKey)
        {
            ContinuationTtlInMinutes = continuationTtlInMinutes;
            IdleCondition = idleCondition;
            CustomizedCheckpointKey = customizedCheckpointKey;
        }

        /// <summary> Continuation TTL in minutes. </summary>
        public object ContinuationTtlInMinutes { get; set; }
        /// <summary> Idle condition. </summary>
        public object IdleCondition { get; set; }
        /// <summary> Customized checkpoint key. </summary>
        public object CustomizedCheckpointKey { get; set; }
    }
}
