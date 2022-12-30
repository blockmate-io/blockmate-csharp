/*
 * Blockmate
 *
 * Blockmate API OpenAPI documentation
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Io.Blockmate.Client;
using Io.Blockmate.Model;

namespace Io.Blockmate.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyticsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get analytics focused on gaming
        /// </summary>
        /// <remarks>
        /// Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <returns>GetAnalytics200Response</returns>
        GetAnalytics200Response GetAnalytics (string accountProvider, string accountId);

        /// <summary>
        /// Get analytics focused on gaming
        /// </summary>
        /// <remarks>
        /// Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <returns>ApiResponse of GetAnalytics200Response</returns>
        ApiResponse<GetAnalytics200Response> GetAnalyticsWithHttpInfo (string accountProvider, string accountId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get analytics focused on gaming
        /// </summary>
        /// <remarks>
        /// Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GetAnalytics200Response</returns>
        System.Threading.Tasks.Task<GetAnalytics200Response> GetAnalyticsAsync (string accountProvider, string accountId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get analytics focused on gaming
        /// </summary>
        /// <remarks>
        /// Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GetAnalytics200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetAnalytics200Response>> GetAnalyticsWithHttpInfoAsync (string accountProvider, string accountId, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AnalyticsApi : IAnalyticsApi
    {
        private Io.Blockmate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnalyticsApi(String basePath)
        {
            this.Configuration = new Io.Blockmate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Io.Blockmate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsApi"/> class
        /// </summary>
        /// <returns></returns>
        public AnalyticsApi()
        {
            this.Configuration = Io.Blockmate.Client.Configuration.Default;

            ExceptionFactory = Io.Blockmate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnalyticsApi(Io.Blockmate.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Io.Blockmate.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Io.Blockmate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Io.Blockmate.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Io.Blockmate.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get analytics focused on gaming Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <returns>GetAnalytics200Response</returns>
        public GetAnalytics200Response GetAnalytics (string accountProvider, string accountId)
        {
             ApiResponse<GetAnalytics200Response> localVarResponse = GetAnalyticsWithHttpInfo(accountProvider, accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get analytics focused on gaming Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <returns>ApiResponse of GetAnalytics200Response</returns>
        public ApiResponse<GetAnalytics200Response> GetAnalyticsWithHttpInfo (string accountProvider, string accountId)
        {
            // verify the required parameter 'accountProvider' is set
            if (accountProvider == null)
                throw new ApiException(400, "Missing required parameter 'accountProvider' when calling AnalyticsApi->GetAnalytics");
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling AnalyticsApi->GetAnalytics");

            var localVarPath = "/v1/analytics/{account_provider}/account/{account_id}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountProvider != null) localVarPathParams.Add("account_provider", this.Configuration.ApiClient.ParameterToString(accountProvider)); // path parameter
            if (accountId != null) localVarPathParams.Add("account_id", this.Configuration.ApiClient.ParameterToString(accountId)); // path parameter

            // authentication (UserJWT) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAnalytics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetAnalytics200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GetAnalytics200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetAnalytics200Response)));
        }

        /// <summary>
        /// Get analytics focused on gaming Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GetAnalytics200Response</returns>
        public async System.Threading.Tasks.Task<GetAnalytics200Response> GetAnalyticsAsync (string accountProvider, string accountId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<GetAnalytics200Response> localVarResponse = await GetAnalyticsWithHttpInfoAsync(accountProvider, accountId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get analytics focused on gaming Get analytics focused on gaming. All empty values are omitted from the response. Values are recalculated once per day.
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountProvider">URL value from account_providers method</param>
        /// <param name="accountId">Account ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GetAnalytics200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetAnalytics200Response>> GetAnalyticsWithHttpInfoAsync (string accountProvider, string accountId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'accountProvider' is set
            if (accountProvider == null)
                throw new ApiException(400, "Missing required parameter 'accountProvider' when calling AnalyticsApi->GetAnalytics");
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling AnalyticsApi->GetAnalytics");

            var localVarPath = "/v1/analytics/{account_provider}/account/{account_id}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountProvider != null) localVarPathParams.Add("account_provider", this.Configuration.ApiClient.ParameterToString(accountProvider)); // path parameter
            if (accountId != null) localVarPathParams.Add("account_id", this.Configuration.ApiClient.ParameterToString(accountId)); // path parameter

            // authentication (UserJWT) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAnalytics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetAnalytics200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GetAnalytics200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetAnalytics200Response)));
        }

    }
}
