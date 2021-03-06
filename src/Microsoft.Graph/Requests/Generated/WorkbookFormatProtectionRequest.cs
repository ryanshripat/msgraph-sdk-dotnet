// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkbookFormatProtectionRequest.
    /// </summary>
    public partial class WorkbookFormatProtectionRequest : BaseRequest, IWorkbookFormatProtectionRequest
    {
        /// <summary>
        /// Constructs a new WorkbookFormatProtectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookFormatProtectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookFormatProtection using POST.
        /// </summary>
        /// <param name="workbookFormatProtectionToCreate">The WorkbookFormatProtection to create.</param>
        /// <returns>The created WorkbookFormatProtection.</returns>
        public System.Threading.Tasks.Task<WorkbookFormatProtection> CreateAsync(WorkbookFormatProtection workbookFormatProtectionToCreate)
        {
            return this.CreateAsync(workbookFormatProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookFormatProtection using POST.
        /// </summary>
        /// <param name="workbookFormatProtectionToCreate">The WorkbookFormatProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookFormatProtection.</returns>
        public async System.Threading.Tasks.Task<WorkbookFormatProtection> CreateAsync(WorkbookFormatProtection workbookFormatProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookFormatProtection>(workbookFormatProtectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookFormatProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookFormatProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookFormatProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookFormatProtection.
        /// </summary>
        /// <returns>The WorkbookFormatProtection.</returns>
        public System.Threading.Tasks.Task<WorkbookFormatProtection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookFormatProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookFormatProtection.</returns>
        public async System.Threading.Tasks.Task<WorkbookFormatProtection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookFormatProtection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookFormatProtection using PATCH.
        /// </summary>
        /// <param name="workbookFormatProtectionToUpdate">The WorkbookFormatProtection to update.</param>
        /// <returns>The updated WorkbookFormatProtection.</returns>
        public System.Threading.Tasks.Task<WorkbookFormatProtection> UpdateAsync(WorkbookFormatProtection workbookFormatProtectionToUpdate)
        {
            return this.UpdateAsync(workbookFormatProtectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookFormatProtection using PATCH.
        /// </summary>
        /// <param name="workbookFormatProtectionToUpdate">The WorkbookFormatProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookFormatProtection.</returns>
        public async System.Threading.Tasks.Task<WorkbookFormatProtection> UpdateAsync(WorkbookFormatProtection workbookFormatProtectionToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookFormatProtection>(workbookFormatProtectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFormatProtectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFormatProtectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookFormatProtectionToInitialize">The <see cref="WorkbookFormatProtection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookFormatProtection workbookFormatProtectionToInitialize)
        {

        }
    }
}
