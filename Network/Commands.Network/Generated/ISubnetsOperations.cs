// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// SubnetsOperations operations.
    /// </summary>
    public partial interface ISubnetsOperations
    {
        /// <summary>
        /// The delete subnet operation deletes the specified subnet.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkName, string subnetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The delete subnet operation deletes the specified subnet.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkName, string subnetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get subnet operation retreives information about the specified
        /// subnet.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet.
        /// </param>
        /// <param name='expand'>
        /// expand references resources.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Subnet>> GetWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkName, string subnetName, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put Subnet operation creates/updates a subnet in thespecified
        /// virtual network
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet.
        /// </param>
        /// <param name='subnetParameters'>
        /// Parameters supplied to the create/update Subnet operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Subnet>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put Subnet operation creates/updates a subnet in thespecified
        /// virtual network
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet.
        /// </param>
        /// <param name='subnetParameters'>
        /// Parameters supplied to the create/update Subnet operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Subnet>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List subnets opertion retrieves all the subnets in a virtual
        /// network.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkName'>
        /// The name of the virtual network.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Subnet>>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualNetworkName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List subnets opertion retrieves all the subnets in a virtual
        /// network.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Subnet>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
