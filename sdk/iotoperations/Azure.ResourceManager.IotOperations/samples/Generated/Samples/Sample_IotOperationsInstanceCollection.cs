// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.IotOperations.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.IotOperations.Samples
{
    public partial class Sample_IotOperationsInstanceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_InstanceCreateOrUpdate()
        {
            // Generated from example definition: 2024-11-01/Instance_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IotOperationsInstanceResource
            IotOperationsInstanceCollection collection = resourceGroupResource.GetIotOperationsInstances();

            // invoke the operation
            string instanceName = "aio-instance";
            IotOperationsInstanceData data = new IotOperationsInstanceData(new AzureLocation("xvewadyhycrjpu"), new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsInstanceProperties(new SchemaRegistryRef(new ResourceIdentifier("/subscriptions/0000000-0000-0000-0000-000000000000/resourceGroups/resourceGroup123/providers/Microsoft.DeviceRegistry/schemaRegistries/resource-name123")))
                {
                    Description = "kpqtgocs",
                },
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities = { },
                },
                Tags = { },
            };
            ArmOperation<IotOperationsInstanceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, instanceName, data);
            IotOperationsInstanceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_InstanceGet()
        {
            // Generated from example definition: 2024-11-01/Instance_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IotOperationsInstanceResource
            IotOperationsInstanceCollection collection = resourceGroupResource.GetIotOperationsInstances();

            // invoke the operation
            string instanceName = "aio-instance";
            IotOperationsInstanceResource result = await collection.GetAsync(instanceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_InstanceListByResourceGroup()
        {
            // Generated from example definition: 2024-11-01/Instance_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IotOperationsInstanceResource
            IotOperationsInstanceCollection collection = resourceGroupResource.GetIotOperationsInstances();

            // invoke the operation and iterate over the result
            await foreach (IotOperationsInstanceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IotOperationsInstanceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_InstanceGet()
        {
            // Generated from example definition: 2024-11-01/Instance_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IotOperationsInstanceResource
            IotOperationsInstanceCollection collection = resourceGroupResource.GetIotOperationsInstances();

            // invoke the operation
            string instanceName = "aio-instance";
            bool result = await collection.ExistsAsync(instanceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_InstanceGet()
        {
            // Generated from example definition: 2024-11-01/Instance_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InstanceResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IotOperationsInstanceResource
            IotOperationsInstanceCollection collection = resourceGroupResource.GetIotOperationsInstances();

            // invoke the operation
            string instanceName = "aio-instance";
            NullableResponse<IotOperationsInstanceResource> response = await collection.GetIfExistsAsync(instanceName);
            IotOperationsInstanceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IotOperationsInstanceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
