// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a device life cycle event (DeviceCreated, DeviceDeleted). </summary>
    public partial class DeviceLifeCycleEventProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceLifeCycleEventProperties"/>. </summary>
        /// <param name="deviceId"> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = `@` ; $ '. </param>
        /// <param name="hubName"> Name of the IoT Hub where the device was created or deleted. </param>
        /// <param name="twin"> Information about the device twin, which is the cloud representation of application device metadata. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/>, <paramref name="hubName"/> or <paramref name="twin"/> is null. </exception>
        internal DeviceLifeCycleEventProperties(string deviceId, string hubName, DeviceTwinInfo twin)
        {
            Argument.AssertNotNull(deviceId, nameof(deviceId));
            Argument.AssertNotNull(hubName, nameof(hubName));
            Argument.AssertNotNull(twin, nameof(twin));

            DeviceId = deviceId;
            HubName = hubName;
            Twin = twin;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceLifeCycleEventProperties"/>. </summary>
        /// <param name="deviceId"> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = `@` ; $ '. </param>
        /// <param name="hubName"> Name of the IoT Hub where the device was created or deleted. </param>
        /// <param name="twin"> Information about the device twin, which is the cloud representation of application device metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceLifeCycleEventProperties(string deviceId, string hubName, DeviceTwinInfo twin, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeviceId = deviceId;
            HubName = hubName;
            Twin = twin;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceLifeCycleEventProperties"/> for deserialization. </summary>
        internal DeviceLifeCycleEventProperties()
        {
        }

        /// <summary> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = `@` ; $ '. </summary>
        public string DeviceId { get; }
        /// <summary> Name of the IoT Hub where the device was created or deleted. </summary>
        public string HubName { get; }
        /// <summary> Information about the device twin, which is the cloud representation of application device metadata. </summary>
        public DeviceTwinInfo Twin { get; }
    }
}
