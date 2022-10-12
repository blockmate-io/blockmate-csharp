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
    public interface IAddressNameAndCategoryInfoApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get address name and category info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <returns>GetAddressNameInfo200Response</returns>
        GetAddressNameInfo200Response GetAddressNameInfo (string address, string chain);

        /// <summary>
        /// Get address name and category info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <returns>ApiResponse of GetAddressNameInfo200Response</returns>
        ApiResponse<GetAddressNameInfo200Response> GetAddressNameInfoWithHttpInfo (string address, string chain);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get address name and category info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GetAddressNameInfo200Response</returns>
        System.Threading.Tasks.Task<GetAddressNameInfo200Response> GetAddressNameInfoAsync (string address, string chain, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get address name and category info
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GetAddressNameInfo200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetAddressNameInfo200Response>> GetAddressNameInfoWithHttpInfoAsync (string address, string chain, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddressNameAndCategoryInfoApi : IAddressNameAndCategoryInfoApi
    {
        private Io.Blockmate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressNameAndCategoryInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressNameAndCategoryInfoApi(String basePath)
        {
            this.Configuration = new Io.Blockmate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Io.Blockmate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressNameAndCategoryInfoApi"/> class
        /// </summary>
        /// <returns></returns>
        public AddressNameAndCategoryInfoApi()
        {
            this.Configuration = Io.Blockmate.Client.Configuration.Default;

            ExceptionFactory = Io.Blockmate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressNameAndCategoryInfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddressNameAndCategoryInfoApi(Io.Blockmate.Client.Configuration configuration = null)
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
        /// Get address name and category info 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <returns>GetAddressNameInfo200Response</returns>
        public GetAddressNameInfo200Response GetAddressNameInfo (string address, string chain)
        {
             ApiResponse<GetAddressNameInfo200Response> localVarResponse = GetAddressNameInfoWithHttpInfo(address, chain);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get address name and category info 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <returns>ApiResponse of GetAddressNameInfo200Response</returns>
        public ApiResponse<GetAddressNameInfo200Response> GetAddressNameInfoWithHttpInfo (string address, string chain)
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling AddressNameAndCategoryInfoApi->GetAddressNameInfo");
            // verify the required parameter 'chain' is set
            if (chain == null)
                throw new ApiException(400, "Missing required parameter 'chain' when calling AddressNameAndCategoryInfoApi->GetAddressNameInfo");

            var localVarPath = "/v1/addressname/simple";
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

            if (address != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "address", address)); // query parameter
            if (chain != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "chain", chain)); // query parameter

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
                Exception exception = ExceptionFactory("GetAddressNameInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetAddressNameInfo200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GetAddressNameInfo200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetAddressNameInfo200Response)));
        }

        /// <summary>
        /// Get address name and category info 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of GetAddressNameInfo200Response</returns>
        public async System.Threading.Tasks.Task<GetAddressNameInfo200Response> GetAddressNameInfoAsync (string address, string chain, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<GetAddressNameInfo200Response> localVarResponse = await GetAddressNameInfoWithHttpInfoAsync(address, chain, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get address name and category info 
        /// </summary>
        /// <exception cref="Io.Blockmate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Address for wich name and category should be returned</param>
        /// <param name="chain">Blockchain identifier</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (GetAddressNameInfo200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetAddressNameInfo200Response>> GetAddressNameInfoWithHttpInfoAsync (string address, string chain, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'address' is set
            if (address == null)
                throw new ApiException(400, "Missing required parameter 'address' when calling AddressNameAndCategoryInfoApi->GetAddressNameInfo");
            // verify the required parameter 'chain' is set
            if (chain == null)
                throw new ApiException(400, "Missing required parameter 'chain' when calling AddressNameAndCategoryInfoApi->GetAddressNameInfo");

            var localVarPath = "/v1/addressname/simple";
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

            if (address != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "address", address)); // query parameter
            if (chain != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "chain", chain)); // query parameter

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
                Exception exception = ExceptionFactory("GetAddressNameInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetAddressNameInfo200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (GetAddressNameInfo200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetAddressNameInfo200Response)));
        }

    }
}
