// <copyright file="CustomersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YapstoneOnboardingAPIs.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;
    using YapstoneOnboardingAPIs.Standard;
    using YapstoneOnboardingAPIs.Standard.Authentication;
    using YapstoneOnboardingAPIs.Standard.Exceptions;
    using YapstoneOnboardingAPIs.Standard.Http.Client;
    using YapstoneOnboardingAPIs.Standard.Utilities;

    /// <summary>
    /// CustomersController.
    /// </summary>
    public class CustomersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        internal CustomersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve all Customers.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <returns>Returns the Models.CustomerPage response from the API call.</returns>
        public Models.CustomerPage GetCustomers(
                int? offset = 0,
                int? limit = 20,
                string correlationRefLabel = null,
                string correlationRefValue = null,
                string marketplaceId = null,
                string merchantId = null)
            => CoreHelper.RunTask(GetCustomersAsync(offset, limit, correlationRefLabel, correlationRefValue, marketplaceId, merchantId));

        /// <summary>
        /// Retrieve all Customers.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerPage response from the API call.</returns>
        public async Task<Models.CustomerPage> GetCustomersAsync(
                int? offset = 0,
                int? limit = 20,
                string correlationRefLabel = null,
                string correlationRefValue = null,
                string marketplaceId = null,
                string merchantId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerPage>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("offset", (offset != null) ? offset : 0))
                      .Query(_query => _query.Setup("limit", (limit != null) ? limit : 20))
                      .Query(_query => _query.Setup("correlationRefLabel", correlationRefLabel))
                      .Query(_query => _query.Setup("correlationRefValue", correlationRefValue))
                      .Query(_query => _query.Setup("marketplaceId", marketplaceId))
                      .Query(_query => _query.Setup("merchantId", merchantId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create a Customer.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer CreateCustomer(
                Models.CreateCustomerRequest request,
                string xYapStoneIdempotentKey = null)
            => CoreHelper.RunTask(CreateCustomerAsync(request, xYapStoneIdempotentKey));

        /// <summary>
        /// Create a Customer.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> CreateCustomerAsync(
                Models.CreateCustomerRequest request,
                string xYapStoneIdempotentKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Customer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Header(_header => _header.Setup("X-YapStone-IdempotentKey", xYapStoneIdempotentKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ErrorsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieve a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer GetCustomer(
                string id)
            => CoreHelper.RunTask(GetCustomerAsync(id));

        /// <summary>
        /// Retrieve a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> GetCustomerAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Customer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Update a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer UpdateCustomer(
                string id,
                Models.UpdateCustomerRequest request,
                string xYapStoneIdempotentKey = null)
            => CoreHelper.RunTask(UpdateCustomerAsync(id, request, xYapStoneIdempotentKey));

        /// <summary>
        /// Update a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> UpdateCustomerAsync(
                string id,
                Models.UpdateCustomerRequest request,
                string xYapStoneIdempotentKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Customer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/customers/{id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("X-YapStone-IdempotentKey", xYapStoneIdempotentKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ErrorsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer DeleteCustomer(
                string id)
            => CoreHelper.RunTask(DeleteCustomerAsync(id));

        /// <summary>
        /// Delete a Customer by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> DeleteCustomerAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Customer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/customers/{id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Perform verification of a Customers supplied details.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public Models.Customer VerifyCustomer(
                string id)
            => CoreHelper.RunTask(VerifyCustomerAsync(id));

        /// <summary>
        /// Perform verification of a Customers supplied details.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Customer response from the API call.</returns>
        public async Task<Models.Customer> VerifyCustomerAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Customer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers/{id}/verification")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken);
    }
}