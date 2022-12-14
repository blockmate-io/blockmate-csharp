/*
 * Blockmate
 *
 * Blockmate API OpenAPI documentation
 *
 * The version of the OpenAPI document: 0.0.2
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
    public interface IExchangeRateInfoApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get current exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <returns>List<ExchangeRate></returns>
        List<ExchangeRate> GetCurrentExchangeRate (string pairs);

        /// <summary>
        /// Get current exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <returns>ApiResponse of List<ExchangeRate></returns>
        ApiResponse<List<ExchangeRate>> GetCurrentExchangeRateWithHttpInfo (string pairs);
        /// <summary>
        /// Get historical exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <returns>List<ExchangeRate></returns>
        List<ExchangeRate> GetHistoricalExchangeRate (string pair, string days);

        /// <summary>
        /// Get historical exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <returns>ApiResponse of List<ExchangeRate></returns>
        ApiResponse<List<ExchangeRate>> GetHistoricalExchangeRateWithHttpInfo (string pair, string days);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get current exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<ExchangeRate></returns>
        System.Threading.Tasks.Task<List<ExchangeRate>> GetCurrentExchangeRateAsync (string pairs, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get current exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;ExchangeRate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ExchangeRate>>> GetCurrentExchangeRateWithHttpInfoAsync (string pairs, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get historical exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<ExchangeRate></returns>
        System.Threading.Tasks.Task<List<ExchangeRate>> GetHistoricalExchangeRateAsync (string pair, string days, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get historical exchange rate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;ExchangeRate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ExchangeRate>>> GetHistoricalExchangeRateWithHttpInfoAsync (string pair, string days, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExchangeRateInfoApi : IExchangeRateInfoApi
    {
        private Io.Blockmate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExchangeRateInfoApi(String basePath)
        {
            this.Configuration = new Io.Blockmate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Io.Blockmate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateInfoApi"/> class
        /// </summary>
        /// <returns></returns>
        public ExchangeRateInfoApi()
        {
            this.Configuration = Io.Blockmate.Client.Configuration.Default;

            ExceptionFactory = Io.Blockmate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRateInfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExchangeRateInfoApi(Io.Blockmate.Client.Configuration configuration = null)
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
        /// Get current exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <returns>List<ExchangeRate></returns>
        public List<ExchangeRate> GetCurrentExchangeRate (string pairs)
        {
             ApiResponse<List<ExchangeRate>> localVarResponse = GetCurrentExchangeRateWithHttpInfo(pairs);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get current exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <returns>ApiResponse of List<ExchangeRate></returns>
        public ApiResponse<List<ExchangeRate>> GetCurrentExchangeRateWithHttpInfo (string pairs)
        {
            // verify the required parameter 'pairs' is set
            if (pairs == null)
                throw new ApiException(400, "Missing required parameter 'pairs' when calling ExchangeRateInfoApi->GetCurrentExchangeRate");

            var localVarPath = "/v1/exchangerate/current";
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

            if (pairs != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pairs", pairs)); // query parameter

            // authentication (ProjectJWT) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
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
                Exception exception = ExceptionFactory("GetCurrentExchangeRate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ExchangeRate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ExchangeRate>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExchangeRate>)));
        }

        /// <summary>
        /// Get current exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<ExchangeRate></returns>
        public async System.Threading.Tasks.Task<List<ExchangeRate>> GetCurrentExchangeRateAsync (string pairs, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<ExchangeRate>> localVarResponse = await GetCurrentExchangeRateWithHttpInfoAsync(pairs, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get current exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pairs">Currency pairs for which exchange rate should be returned (max 20 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;ExchangeRate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ExchangeRate>>> GetCurrentExchangeRateWithHttpInfoAsync (string pairs, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'pairs' is set
            if (pairs == null)
                throw new ApiException(400, "Missing required parameter 'pairs' when calling ExchangeRateInfoApi->GetCurrentExchangeRate");

            var localVarPath = "/v1/exchangerate/current";
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

            if (pairs != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pairs", pairs)); // query parameter

            // authentication (ProjectJWT) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
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
                Exception exception = ExceptionFactory("GetCurrentExchangeRate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ExchangeRate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ExchangeRate>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExchangeRate>)));
        }

        /// <summary>
        /// Get historical exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <returns>List<ExchangeRate></returns>
        public List<ExchangeRate> GetHistoricalExchangeRate (string pair, string days)
        {
             ApiResponse<List<ExchangeRate>> localVarResponse = GetHistoricalExchangeRateWithHttpInfo(pair, days);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get historical exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <returns>ApiResponse of List<ExchangeRate></returns>
        public ApiResponse<List<ExchangeRate>> GetHistoricalExchangeRateWithHttpInfo (string pair, string days)
        {
            // verify the required parameter 'pair' is set
            if (pair == null)
                throw new ApiException(400, "Missing required parameter 'pair' when calling ExchangeRateInfoApi->GetHistoricalExchangeRate");
            // verify the required parameter 'days' is set
            if (days == null)
                throw new ApiException(400, "Missing required parameter 'days' when calling ExchangeRateInfoApi->GetHistoricalExchangeRate");

            var localVarPath = "/v1/exchangerate/history";
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

            if (pair != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (days != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "days", days)); // query parameter

            // authentication (ProjectJWT) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
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
                Exception exception = ExceptionFactory("GetHistoricalExchangeRate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ExchangeRate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ExchangeRate>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExchangeRate>)));
        }

        /// <summary>
        /// Get historical exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<ExchangeRate></returns>
        public async System.Threading.Tasks.Task<List<ExchangeRate>> GetHistoricalExchangeRateAsync (string pair, string days, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<ExchangeRate>> localVarResponse = await GetHistoricalExchangeRateWithHttpInfoAsync(pair, days, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get historical exchange rate 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Currency pair for which exchange rates should be returned</param>
        /// <param name="days">Historical dates for which exchange rates should be returned (max 40 per request)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;ExchangeRate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ExchangeRate>>> GetHistoricalExchangeRateWithHttpInfoAsync (string pair, string days, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'pair' is set
            if (pair == null)
                throw new ApiException(400, "Missing required parameter 'pair' when calling ExchangeRateInfoApi->GetHistoricalExchangeRate");
            // verify the required parameter 'days' is set
            if (days == null)
                throw new ApiException(400, "Missing required parameter 'days' when calling ExchangeRateInfoApi->GetHistoricalExchangeRate");

            var localVarPath = "/v1/exchangerate/history";
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

            if (pair != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (days != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "days", days)); // query parameter

            // authentication (ProjectJWT) required
            // http bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
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
                Exception exception = ExceptionFactory("GetHistoricalExchangeRate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ExchangeRate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ExchangeRate>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExchangeRate>)));
        }

    }
}
