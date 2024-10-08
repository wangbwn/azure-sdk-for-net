// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> State of the public network access. </summary>
    public readonly partial struct MonitorWorkspacePublicNetworkAccess : IEquatable<MonitorWorkspacePublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspacePublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorWorkspacePublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> The public network access is enabled. </summary>
        public static MonitorWorkspacePublicNetworkAccess Enabled { get; } = new MonitorWorkspacePublicNetworkAccess(EnabledValue);
        /// <summary> The public network access is disabled. </summary>
        public static MonitorWorkspacePublicNetworkAccess Disabled { get; } = new MonitorWorkspacePublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="MonitorWorkspacePublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(MonitorWorkspacePublicNetworkAccess left, MonitorWorkspacePublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorWorkspacePublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(MonitorWorkspacePublicNetworkAccess left, MonitorWorkspacePublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorWorkspacePublicNetworkAccess"/>. </summary>
        public static implicit operator MonitorWorkspacePublicNetworkAccess(string value) => new MonitorWorkspacePublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorWorkspacePublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorWorkspacePublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
