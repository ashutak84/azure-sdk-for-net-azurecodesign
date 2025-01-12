// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A Class representing a MySqlFlexibleServerBackupV2 along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MySqlFlexibleServerBackupV2Resource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMySqlFlexibleServerBackupV2Resource method.
    /// Otherwise you can get one from its parent resource <see cref="MySqlFlexibleServerResource"/> using the GetMySqlFlexibleServerBackupV2 method.
    /// </summary>
    public partial class MySqlFlexibleServerBackupV2Resource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MySqlFlexibleServerBackupV2Resource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="backupName"> The backupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string backupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics;
        private readonly LongRunningBackupsRestOperations _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient;
        private readonly ClientDiagnostics _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics;
        private readonly LongRunningBackupRestOperations _mySqlFlexibleServerBackupV2LongRunningBackupRestClient;
        private readonly MySqlFlexibleServerBackupV2Data _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforMySQL/flexibleServers/backupsV2";

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerBackupV2Resource"/> class for mocking. </summary>
        protected MySqlFlexibleServerBackupV2Resource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerBackupV2Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MySqlFlexibleServerBackupV2Resource(ArmClient client, MySqlFlexibleServerBackupV2Data data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlFlexibleServerBackupV2Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MySqlFlexibleServerBackupV2Resource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mySqlFlexibleServerBackupV2LongRunningBackupsApiVersion);
            _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient = new LongRunningBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerBackupV2LongRunningBackupsApiVersion);
            _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mySqlFlexibleServerBackupV2LongRunningBackupApiVersion);
            _mySqlFlexibleServerBackupV2LongRunningBackupRestClient = new LongRunningBackupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlFlexibleServerBackupV2LongRunningBackupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MySqlFlexibleServerBackupV2Data Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get backup for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerBackupV2Resource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Resource.Get");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerBackupV2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get backup for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerBackupV2Resource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupsClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Resource.Get");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerBackupV2LongRunningBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlFlexibleServerBackupV2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create backup for a given server with specified backup name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackup_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating and exporting backup of the given server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MySqlFlexibleServerBackupV2Resource>> UpdateAsync(WaitUntil waitUntil, MySqlFlexibleServerBackupV2Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Resource.Update");
            scope.Start();
            try
            {
                var response = await _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerBackupV2Resource>(new MySqlFlexibleServerBackupV2OperationSource(Client), _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics, Pipeline, _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create backup for a given server with specified backup name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/backupsV2/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongRunningBackup_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlFlexibleServerBackupV2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating and exporting backup of the given server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MySqlFlexibleServerBackupV2Resource> Update(WaitUntil waitUntil, MySqlFlexibleServerBackupV2Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics.CreateScope("MySqlFlexibleServerBackupV2Resource.Update");
            scope.Start();
            try
            {
                var response = _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<MySqlFlexibleServerBackupV2Resource>(new MySqlFlexibleServerBackupV2OperationSource(Client), _mySqlFlexibleServerBackupV2LongRunningBackupClientDiagnostics, Pipeline, _mySqlFlexibleServerBackupV2LongRunningBackupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
