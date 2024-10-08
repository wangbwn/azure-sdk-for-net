// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Amazon RDS for SQL Server linked service. </summary>
    public partial class AmazonRdsForSqlServerLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="AmazonRdsForSqlServerLinkedService"/>. </summary>
        public AmazonRdsForSqlServerLinkedService()
        {
            LinkedServiceType = "AmazonRdsForSqlServer";
        }

        /// <summary> Initializes a new instance of <see cref="AmazonRdsForSqlServerLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="linkedServiceVersion"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> The name or network address of the instance of SQL Server to which to connect, used by recommended version. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> The name of the database, used by recommended version. Type: string (or Expression with resultType string). </param>
        /// <param name="encrypt"> Indicate whether TLS encryption is required for all data sent between the client and server, used by recommended version. Possible values are true/yes/mandatory, false/no/optional and strict. Type: string (or Expression with resultType string). </param>
        /// <param name="trustServerCertificate"> Indicate whether the channel will be encrypted while bypassing walking the certificate chain to validate trust, used by recommended version. Type: Boolean (or Expression with resultType boolean). </param>
        /// <param name="hostNameInCertificate"> The host name to use when validating the server certificate for the connection. When not specified, the server name from the Data Source is used for certificate validation, used by recommended version. Type: string (or Expression with resultType string). </param>
        /// <param name="applicationIntent"> The application workload type when connecting to a server, used by recommended version. Possible values are ReadOnly and ReadWrite. Type: string (or Expression with resultType string). </param>
        /// <param name="connectTimeout"> The length of time (in seconds) to wait for a connection to the server before terminating the attempt and generating an error, used by recommended version. Type: integer (or Expression with resultType integer). </param>
        /// <param name="connectRetryCount"> The number of re-connections attempted after identifying that there was an idle connection failure, used by recommended version. This must be an integer between 0 and 255. Type: integer (or Expression with resultType integer). </param>
        /// <param name="connectRetryInterval"> The amount of time (in seconds) between each re-connection attempt after identifying that there was an idle connection failure, used by recommended version. This must be an integer between 1 and 60. Type: integer (or Expression with resultType integer). </param>
        /// <param name="loadBalanceTimeout"> The minimum time, in seconds, for the connection to live in the connection pool before being destroyed, used by recommended version. Type: integer (or Expression with resultType integer). </param>
        /// <param name="commandTimeout"> The default wait time (in seconds) before terminating the attempt to execute a command and generating an error, used by recommended version. Type: integer (or Expression with resultType integer). </param>
        /// <param name="integratedSecurity"> Indicate whether User ID and Password are specified in the connection (when false) or whether the current Windows account credentials are used for authentication (when true), used by recommended version. Type: Boolean (or Expression with resultType boolean). </param>
        /// <param name="failoverPartner"> The name or address of the partner server to connect to if the primary server is down, used by recommended version. Type: string (or Expression with resultType string). </param>
        /// <param name="maxPoolSize"> The maximum number of connections allowed in the connection pool for this specific connection string, used by recommended version. Type: integer (or Expression with resultType integer). </param>
        /// <param name="minPoolSize"> The minimum number of connections allowed in the connection pool for this specific connection string, used by recommended version. Type: integer (or Expression with resultType integer). </param>
        /// <param name="multipleActiveResultSets"> When true, an application can maintain multiple active result sets (MARS). When false, an application must process or cancel all result sets from one batch before it can execute any other batch on that connection, used by recommended version. Type: Boolean (or Expression with resultType boolean). </param>
        /// <param name="multiSubnetFailover"> If your application is connecting to an AlwaysOn availability group (AG) on different subnets, setting MultiSubnetFailover=true provides faster detection of and connection to the (currently) active server, used by recommended version. Type: Boolean (or Expression with resultType boolean). </param>
        /// <param name="packetSize"> The size in bytes of the network packets used to communicate with an instance of server, used by recommended version. Type: integer (or Expression with resultType integer). </param>
        /// <param name="pooling"> Indicate whether the connection will be pooled or explicitly opened every time that the connection is requested, used by recommended version. Type: Boolean (or Expression with resultType boolean). </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="authenticationType"> The type used for authentication. Type: string. </param>
        /// <param name="userName"> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The on-premises Windows authentication password. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="alwaysEncryptedSettings"> Sql always encrypted properties. </param>
        internal AmazonRdsForSqlServerLinkedService(string linkedServiceType, string linkedServiceVersion, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> server, DataFactoryElement<string> database, DataFactoryElement<string> encrypt, DataFactoryElement<bool> trustServerCertificate, DataFactoryElement<string> hostNameInCertificate, DataFactoryElement<string> applicationIntent, DataFactoryElement<int> connectTimeout, DataFactoryElement<int> connectRetryCount, DataFactoryElement<int> connectRetryInterval, DataFactoryElement<int> loadBalanceTimeout, DataFactoryElement<int> commandTimeout, DataFactoryElement<bool> integratedSecurity, DataFactoryElement<string> failoverPartner, DataFactoryElement<int> maxPoolSize, DataFactoryElement<int> minPoolSize, DataFactoryElement<bool> multipleActiveResultSets, DataFactoryElement<bool> multiSubnetFailover, DataFactoryElement<int> packetSize, DataFactoryElement<bool> pooling, DataFactoryElement<string> connectionString, AmazonRdsForSqlAuthenticationType? authenticationType, DataFactoryElement<string> userName, DataFactorySecret password, string encryptedCredential, SqlAlwaysEncryptedProperties alwaysEncryptedSettings) : base(linkedServiceType, linkedServiceVersion, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            Database = database;
            Encrypt = encrypt;
            TrustServerCertificate = trustServerCertificate;
            HostNameInCertificate = hostNameInCertificate;
            ApplicationIntent = applicationIntent;
            ConnectTimeout = connectTimeout;
            ConnectRetryCount = connectRetryCount;
            ConnectRetryInterval = connectRetryInterval;
            LoadBalanceTimeout = loadBalanceTimeout;
            CommandTimeout = commandTimeout;
            IntegratedSecurity = integratedSecurity;
            FailoverPartner = failoverPartner;
            MaxPoolSize = maxPoolSize;
            MinPoolSize = minPoolSize;
            MultipleActiveResultSets = multipleActiveResultSets;
            MultiSubnetFailover = multiSubnetFailover;
            PacketSize = packetSize;
            Pooling = pooling;
            ConnectionString = connectionString;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            AlwaysEncryptedSettings = alwaysEncryptedSettings;
            LinkedServiceType = linkedServiceType ?? "AmazonRdsForSqlServer";
        }

        /// <summary> The name or network address of the instance of SQL Server to which to connect, used by recommended version. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> The name of the database, used by recommended version. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> Indicate whether TLS encryption is required for all data sent between the client and server, used by recommended version. Possible values are true/yes/mandatory, false/no/optional and strict. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Encrypt { get; set; }
        /// <summary> Indicate whether the channel will be encrypted while bypassing walking the certificate chain to validate trust, used by recommended version. Type: Boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> TrustServerCertificate { get; set; }
        /// <summary> The host name to use when validating the server certificate for the connection. When not specified, the server name from the Data Source is used for certificate validation, used by recommended version. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> HostNameInCertificate { get; set; }
        /// <summary> The application workload type when connecting to a server, used by recommended version. Possible values are ReadOnly and ReadWrite. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ApplicationIntent { get; set; }
        /// <summary> The length of time (in seconds) to wait for a connection to the server before terminating the attempt and generating an error, used by recommended version. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> ConnectTimeout { get; set; }
        /// <summary> The number of re-connections attempted after identifying that there was an idle connection failure, used by recommended version. This must be an integer between 0 and 255. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> ConnectRetryCount { get; set; }
        /// <summary> The amount of time (in seconds) between each re-connection attempt after identifying that there was an idle connection failure, used by recommended version. This must be an integer between 1 and 60. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> ConnectRetryInterval { get; set; }
        /// <summary> The minimum time, in seconds, for the connection to live in the connection pool before being destroyed, used by recommended version. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> LoadBalanceTimeout { get; set; }
        /// <summary> The default wait time (in seconds) before terminating the attempt to execute a command and generating an error, used by recommended version. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> CommandTimeout { get; set; }
        /// <summary> Indicate whether User ID and Password are specified in the connection (when false) or whether the current Windows account credentials are used for authentication (when true), used by recommended version. Type: Boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> IntegratedSecurity { get; set; }
        /// <summary> The name or address of the partner server to connect to if the primary server is down, used by recommended version. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FailoverPartner { get; set; }
        /// <summary> The maximum number of connections allowed in the connection pool for this specific connection string, used by recommended version. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> MaxPoolSize { get; set; }
        /// <summary> The minimum number of connections allowed in the connection pool for this specific connection string, used by recommended version. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> MinPoolSize { get; set; }
        /// <summary> When true, an application can maintain multiple active result sets (MARS). When false, an application must process or cancel all result sets from one batch before it can execute any other batch on that connection, used by recommended version. Type: Boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> MultipleActiveResultSets { get; set; }
        /// <summary> If your application is connecting to an AlwaysOn availability group (AG) on different subnets, setting MultiSubnetFailover=true provides faster detection of and connection to the (currently) active server, used by recommended version. Type: Boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> MultiSubnetFailover { get; set; }
        /// <summary> The size in bytes of the network packets used to communicate with an instance of server, used by recommended version. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> PacketSize { get; set; }
        /// <summary> Indicate whether the connection will be pooled or explicitly opened every time that the connection is requested, used by recommended version. Type: Boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> Pooling { get; set; }
        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> The type used for authentication. Type: string. </summary>
        public AmazonRdsForSqlAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> The on-premises Windows authentication password. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> Sql always encrypted properties. </summary>
        public SqlAlwaysEncryptedProperties AlwaysEncryptedSettings { get; set; }
    }
}
