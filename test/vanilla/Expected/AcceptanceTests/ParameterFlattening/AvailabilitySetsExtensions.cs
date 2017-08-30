// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsParameterFlattening
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AvailabilitySets.
    /// </summary>
    public static partial class AvailabilitySetsExtensions
    {
            /// <summary>
            /// Updates the tags for an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='avset'>
            /// The name of the storage availability set.
            /// </param>
            /// <param name='tags'>
            /// A set of tags. A description about the set of tags.
            /// </param>
            public static void Update(this IAvailabilitySets operations, string resourceGroupName, string avset, IDictionary<string, string> tags)
            {
                operations.UpdateAsync(resourceGroupName, avset, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the tags for an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='avset'>
            /// The name of the storage availability set.
            /// </param>
            /// <param name='tags'>
            /// A set of tags. A description about the set of tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IAvailabilitySets operations, string resourceGroupName, string avset, IDictionary<string, string> tags, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, avset, tags, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}