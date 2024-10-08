// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerDatabaseRestorePoint.
/// </summary>
public partial class SqlServerDatabaseRestorePoint : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The earliest time to which this database can be restored.
    /// </summary>
    public BicepValue<DateTimeOffset> EarliestRestoreOn { get => _earliestRestoreOn; }
    private readonly BicepValue<DateTimeOffset> _earliestRestoreOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Resource location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The time the backup was taken.
    /// </summary>
    public BicepValue<DateTimeOffset> RestorePointCreatedOn { get => _restorePointCreatedOn; }
    private readonly BicepValue<DateTimeOffset> _restorePointCreatedOn;

    /// <summary>
    /// The label of restore point for backup request by user.
    /// </summary>
    public BicepValue<string> RestorePointLabel { get => _restorePointLabel; }
    private readonly BicepValue<string> _restorePointLabel;

    /// <summary>
    /// The type of restore point.
    /// </summary>
    public BicepValue<RestorePointType> RestorePointType { get => _restorePointType; }
    private readonly BicepValue<RestorePointType> _restorePointType;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlDatabase> _parent;

    /// <summary>
    /// Creates a new SqlServerDatabaseRestorePoint.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerDatabaseRestorePoint.</param>
    /// <param name="resourceVersion">Version of the SqlServerDatabaseRestorePoint.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SqlServerDatabaseRestorePoint(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/servers/databases/restorePoints", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _earliestRestoreOn = BicepValue<DateTimeOffset>.DefineProperty(this, "EarliestRestoreOn", ["properties", "earliestRestoreDate"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _restorePointCreatedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "RestorePointCreatedOn", ["properties", "restorePointCreationDate"], isOutput: true);
        _restorePointLabel = BicepValue<string>.DefineProperty(this, "RestorePointLabel", ["properties", "restorePointLabel"], isOutput: true);
        _restorePointType = BicepValue<RestorePointType>.DefineProperty(this, "RestorePointType", ["properties", "restorePointType"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SqlServerDatabaseRestorePoint.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerDatabaseRestorePoint.</param>
    /// <param name="resourceVersion">Version of the SqlServerDatabaseRestorePoint.</param>
    /// <returns>The existing SqlServerDatabaseRestorePoint resource.</returns>
    public static SqlServerDatabaseRestorePoint FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
