// <copyright file="SpecificationsController.cs" company="APIMatic">
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
    /// SpecificationsController.
    /// </summary>
    public class SpecificationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificationsController"/> class.
        /// </summary>
        internal SpecificationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getCustomerSpecifications EndPoint.
        /// </summary>
        /// <param name="type">Optional parameter: Filter by `type`..</param>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="commerceType">Optional parameter: Filter by `commerceType`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <returns>Returns the Models.CustomerSpecificationPage response from the API call.</returns>
        public Models.CustomerSpecificationPage GetCustomerSpecifications(
                string type = null,
                string country = null,
                string commerceType = null,
                int? offset = 0,
                int? limit = 20)
            => CoreHelper.RunTask(GetCustomerSpecificationsAsync(type, country, commerceType, offset, limit));

        /// <summary>
        /// getCustomerSpecifications EndPoint.
        /// </summary>
        /// <param name="type">Optional parameter: Filter by `type`..</param>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="commerceType">Optional parameter: Filter by `commerceType`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerSpecificationPage response from the API call.</returns>
        public async Task<Models.CustomerSpecificationPage> GetCustomerSpecificationsAsync(
                string type = null,
                string country = null,
                string commerceType = null,
                int? offset = 0,
                int? limit = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerSpecificationPage>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/specifications/customers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("country", country))
                      .Query(_query => _query.Setup("commerceType", commerceType))
                      .Query(_query => _query.Setup("offset", (offset != null) ? offset : 0))
                      .Query(_query => _query.Setup("limit", (limit != null) ? limit : 20))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// getInstrumentSpecifications EndPoint.
        /// </summary>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="currency">Optional parameter: Filter by `currency`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <returns>Returns the Models.InstrumentSpecificationPage response from the API call.</returns>
        public Models.InstrumentSpecificationPage GetInstrumentSpecifications(
                string country = null,
                string currency = null,
                int? offset = 0,
                int? limit = 20)
            => CoreHelper.RunTask(GetInstrumentSpecificationsAsync(country, currency, offset, limit));

        /// <summary>
        /// getInstrumentSpecifications EndPoint.
        /// </summary>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="currency">Optional parameter: Filter by `currency`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InstrumentSpecificationPage response from the API call.</returns>
        public async Task<Models.InstrumentSpecificationPage> GetInstrumentSpecificationsAsync(
                string country = null,
                string currency = null,
                int? offset = 0,
                int? limit = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InstrumentSpecificationPage>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/specifications/instruments")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("country", country))
                      .Query(_query => _query.Setup("currency", currency))
                      .Query(_query => _query.Setup("offset", (offset != null) ? offset : 0))
                      .Query(_query => _query.Setup("limit", (limit != null) ? limit : 20))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// getInstrumentSpecification EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <returns>Returns the Models.InstrumentSpecification response from the API call.</returns>
        public Models.InstrumentSpecification GetInstrumentSpecification(
                string name)
            => CoreHelper.RunTask(GetInstrumentSpecificationAsync(name));

        /// <summary>
        /// getInstrumentSpecification EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InstrumentSpecification response from the API call.</returns>
        public async Task<Models.InstrumentSpecification> GetInstrumentSpecificationAsync(
                string name,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InstrumentSpecification>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/specifications/instruments/{name}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("name", name))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// getIdentityDocumentSpecifications EndPoint.
        /// </summary>
        /// <param name="type">Optional parameter: Filter by `type`..</param>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <returns>Returns the Models.IdentityDocumentSpecificationPage response from the API call.</returns>
        public Models.IdentityDocumentSpecificationPage GetIdentityDocumentSpecifications(
                string type = null,
                string country = null,
                int? offset = 0,
                int? limit = 20)
            => CoreHelper.RunTask(GetIdentityDocumentSpecificationsAsync(type, country, offset, limit));

        /// <summary>
        /// getIdentityDocumentSpecifications EndPoint.
        /// </summary>
        /// <param name="type">Optional parameter: Filter by `type`..</param>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IdentityDocumentSpecificationPage response from the API call.</returns>
        public async Task<Models.IdentityDocumentSpecificationPage> GetIdentityDocumentSpecificationsAsync(
                string type = null,
                string country = null,
                int? offset = 0,
                int? limit = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IdentityDocumentSpecificationPage>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/specifications/identityDocuments")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("country", country))
                      .Query(_query => _query.Setup("offset", (offset != null) ? offset : 0))
                      .Query(_query => _query.Setup("limit", (limit != null) ? limit : 20))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// getIdentityDocumentSpecification EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <returns>Returns the Models.IdentityDocumentSpecification response from the API call.</returns>
        public Models.IdentityDocumentSpecification GetIdentityDocumentSpecification(
                string name)
            => CoreHelper.RunTask(GetIdentityDocumentSpecificationAsync(name));

        /// <summary>
        /// getIdentityDocumentSpecification EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IdentityDocumentSpecification response from the API call.</returns>
        public async Task<Models.IdentityDocumentSpecification> GetIdentityDocumentSpecificationAsync(
                string name,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IdentityDocumentSpecification>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/specifications/identityDocuments/{name}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("name", name))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// getPaymentMethodSpecifications EndPoint.
        /// </summary>
        /// <param name="currency">Optional parameter: Filter by `currency`..</param>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <returns>Returns the Models.PaymentMethodSpecificationPage response from the API call.</returns>
        public Models.PaymentMethodSpecificationPage GetPaymentMethodSpecifications(
                string currency = null,
                string country = null,
                int? offset = 0,
                int? limit = 20)
            => CoreHelper.RunTask(GetPaymentMethodSpecificationsAsync(currency, country, offset, limit));

        /// <summary>
        /// getPaymentMethodSpecifications EndPoint.
        /// </summary>
        /// <param name="currency">Optional parameter: Filter by `currency`..</param>
        /// <param name="country">Optional parameter: Filter by `country`..</param>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is `0`..</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentMethodSpecificationPage response from the API call.</returns>
        public async Task<Models.PaymentMethodSpecificationPage> GetPaymentMethodSpecificationsAsync(
                string currency = null,
                string country = null,
                int? offset = 0,
                int? limit = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentMethodSpecificationPage>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/specifications/paymentMethods")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("currency", currency))
                      .Query(_query => _query.Setup("country", country))
                      .Query(_query => _query.Setup("offset", (offset != null) ? offset : 0))
                      .Query(_query => _query.Setup("limit", (limit != null) ? limit : 20))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// getPaymentMethodSpecification EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentMethodSpecification response from the API call.</returns>
        public Models.PaymentMethodSpecification GetPaymentMethodSpecification(
                string name)
            => CoreHelper.RunTask(GetPaymentMethodSpecificationAsync(name));

        /// <summary>
        /// getPaymentMethodSpecification EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentMethodSpecification response from the API call.</returns>
        public async Task<Models.PaymentMethodSpecification> GetPaymentMethodSpecificationAsync(
                string name,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentMethodSpecification>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/specifications/paymentMethods/{name}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("name", name))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ErrorsException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}