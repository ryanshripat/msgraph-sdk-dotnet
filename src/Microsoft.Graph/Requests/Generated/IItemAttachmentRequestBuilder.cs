// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IItemAttachmentRequestBuilder.
    /// </summary>
    public partial interface IItemAttachmentRequestBuilder : IAttachmentRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IItemAttachmentRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IItemAttachmentRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Item.
        /// </summary>
        /// <returns>The <see cref="IOutlookItemRequestBuilder"/>.</returns>
        IOutlookItemRequestBuilder Item { get; }
    
    }
}
