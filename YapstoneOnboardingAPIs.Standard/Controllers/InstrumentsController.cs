// <copyright file="InstrumentsController.cs" company="APIMatic">
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
    /// InstrumentsController.
    /// </summary>
    public class InstrumentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentsController"/> class.
        /// </summary>
        internal InstrumentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve all Instruments.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <param name="customerId">Optional parameter: Filter by `customerId`..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <returns>Returns the Models.InstrumentPage response from the API call.</returns>
        public Models.InstrumentPage GetInstruments(
                int? offset = 0,
                int? limit = 20,
                string marketplaceId = null,
                string merchantId = null,
                string customerId = null,
                string correlationRefLabel = null,
                string correlationRefValue = null)
            => CoreHelper.RunTask(GetInstrumentsAsync(offset, limit, marketplaceId, merchantId, customerId, correlationRefLabel, correlationRefValue));

        /// <summary>
        /// Retrieve all Instruments.
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="marketplaceId">Optional parameter: Filter by `marketplaceId`..</param>
        /// <param name="merchantId">Optional parameter: Filter by `merchantId`..</param>
        /// <param name="customerId">Optional parameter: Filter by `customerId`..</param>
        /// <param name="correlationRefLabel">Optional parameter: Filter by `correlationRef.label`..</param>
        /// <param name="correlationRefValue">Optional parameter: Filter by `correlationRef.value`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InstrumentPage response from the API call.</returns>
        public async Task<Models.InstrumentPage> GetInstrumentsAsync(
                int? offset = 0,
                int? limit = 20,
                string marketplaceId = null,
                string merchantId = null,
                string customerId = null,
                string correlationRefLabel = null,
                string correlationRefValue = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InstrumentPage>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/instruments")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("offset", (offset != null) ? offset : 0))
                      .Query(_query => _query.Setup("limit", (limit != null) ? limit : 20))
                      .Query(_query => _query.Setup("marketplaceId", marketplaceId))
                      .Query(_query => _query.Setup("merchantId", merchantId))
                      .Query(_query => _query.Setup("customerId", customerId))
                      .Query(_query => _query.Setup("correlationRefLabel", correlationRefLabel))
                      .Query(_query => _query.Setup("correlationRefValue", correlationRefValue))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create an Instrument.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="metadata">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument CreateInstrument(
                Models.CreateInstrumentRequest request,
                string xYapStoneIdempotentKey = null,
                Dictionary<string, string> metadata = null)
            => CoreHelper.RunTask(CreateInstrumentAsync(request, xYapStoneIdempotentKey, metadata));

        /// <summary>
        /// Create an Instrument.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="metadata">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> CreateInstrumentAsync(
                Models.CreateInstrumentRequest request,
                string xYapStoneIdempotentKey = null,
                Dictionary<string, string> metadata = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Instrument>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/instruments")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Header(_header => _header.Setup("X-YapStone-IdempotentKey", xYapStoneIdempotentKey))
                      .Query(_query => _query.Setup("metadata", metadata))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Conflict", (_reason, _context) => new ErrorsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Retrieve an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument GetInstrument(
                string id)
            => CoreHelper.RunTask(GetInstrumentAsync(id));

        /// <summary>
        /// Retrieve an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> GetInstrumentAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Instrument>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/instruments/{id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Update an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument UpdateInstrument(
                string id,
                Models.UpdateInstrumentRequest request,
                string xYapStoneIdempotentKey = null)
            => CoreHelper.RunTask(UpdateInstrumentAsync(id, request, xYapStoneIdempotentKey));

        /// <summary>
        /// Update an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="xYapStoneIdempotentKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> UpdateInstrumentAsync(
                string id,
                Models.UpdateInstrumentRequest request,
                string xYapStoneIdempotentKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Instrument>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/instruments/{id}")
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
        /// Delete an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument DeleteInstrument(
                string id)
            => CoreHelper.RunTask(DeleteInstrumentAsync(id));

        /// <summary>
        /// Delete an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> DeleteInstrumentAsync(
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Instrument>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/instruments/{id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Request verification of an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public Models.Instrument VerifyInstrument(
                string id,
                Models.VerifyInstrumentRequest request)
            => CoreHelper.RunTask(VerifyInstrumentAsync(id, request));

        /// <summary>
        /// Request verification of an Instrument by id.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Instrument response from the API call.</returns>
        public async Task<Models.Instrument> VerifyInstrumentAsync(
                string id,
                Models.VerifyInstrumentRequest request,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Instrument>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/instruments/{id}/verification")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}