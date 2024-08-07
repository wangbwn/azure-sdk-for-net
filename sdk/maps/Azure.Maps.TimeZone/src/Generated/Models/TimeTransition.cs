// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Maps.TimeZone
{
    /// <summary> The TimeTransition. </summary>
    public partial class TimeTransition
    {
        /// <summary> Initializes a new instance of <see cref="TimeTransition"/>. </summary>
        internal TimeTransition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TimeTransition"/>. </summary>
        /// <param name="tag"> Tag property. </param>
        /// <param name="standardOffset"> StandardOffset property. </param>
        /// <param name="daylightSavings"> DaylightSavings property. </param>
        /// <param name="utcStart"> Start date, start time for this transition period. </param>
        /// <param name="utcEnd"> End date, end time for this transition period. </param>
        internal TimeTransition(string tag, string standardOffset, string daylightSavings, DateTimeOffset? utcStart, DateTimeOffset? utcEnd)
        {
            Tag = tag;
            StandardOffset = standardOffset;
            DaylightSavings = daylightSavings;
            UtcStart = utcStart;
            UtcEnd = utcEnd;
        }

        /// <summary> Tag property. </summary>
        public string Tag { get; }
        /// <summary> StandardOffset property. </summary>
        public string StandardOffset { get; }
        /// <summary> DaylightSavings property. </summary>
        public string DaylightSavings { get; }
        /// <summary> Start date, start time for this transition period. </summary>
        public DateTimeOffset? UtcStart { get; }
        /// <summary> End date, end time for this transition period. </summary>
        public DateTimeOffset? UtcEnd { get; }
    }
}
