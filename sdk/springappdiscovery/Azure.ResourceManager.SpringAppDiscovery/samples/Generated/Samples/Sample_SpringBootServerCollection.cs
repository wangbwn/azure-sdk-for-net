// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SpringAppDiscovery.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SpringAppDiscovery.Samples
{
    public partial class Sample_SpringBootServerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_SpringbootserversCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootservers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            SpringBootServerData data = new SpringBootServerData
            {
                Properties = new SpringBootServerProperties("thhuxocfyqpeluqcgnypi")
                {
                    Port = 10,
                    FqdnAndIPAddressList = { },
                    MachineArmId = new ResourceIdentifier("fvfkiapbqsprnbzczdfmuryknrna"),
                    TotalApps = 5,
                    SpringBootApps = 17,
                    Errors = { },
                },
            };
            ArmOperation<SpringBootServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, springbootserversName, data);
            SpringBootServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_SpringbootserversCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootservers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            SpringBootServerData data = new SpringBootServerData();
            ArmOperation<SpringBootServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, springbootserversName, data);
            SpringBootServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SpringbootserversGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootservers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            SpringBootServerResource result = await collection.GetAsync(springbootserversName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SpringbootserversGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootservers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            SpringBootServerResource result = await collection.GetAsync(springbootserversName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SpringbootserversListByResourceGroupMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootservers_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation and iterate over the result
            await foreach (SpringBootServerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SpringbootserversListByResourceGroupMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_ListByResourceGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootservers_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation and iterate over the result
            await foreach (SpringBootServerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SpringbootserversGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootservers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            bool result = await collection.ExistsAsync(springbootserversName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SpringbootserversGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootservers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            bool result = await collection.ExistsAsync(springbootserversName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SpringbootserversGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootservers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            NullableResponse<SpringBootServerResource> response = await collection.GetIfExistsAsync(springbootserversName);
            SpringBootServerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootServerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SpringbootserversGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootservers_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootservers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "etmdxomjncqvygm";
            string resourceGroupName = "rgspringbootservers";
            string siteName = "hlkrzldhyobavtabgpubtjbhlslnjmsvkthwcfboriwyxndacjypzbj";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootServerResource
            SpringBootServerCollection collection = springBootSite.GetSpringBootServers();

            // invoke the operation
            string springbootserversName = "zkarbqnwnxeozvjrkpdqmgnwedwgtwcmmyqwaijkn";
            NullableResponse<SpringBootServerResource> response = await collection.GetIfExistsAsync(springbootserversName);
            SpringBootServerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootServerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
