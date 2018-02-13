// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.XmsErrorResponses
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PetOperations operations.
    /// </summary>
    public partial class PetOperations : IServiceOperations<XMSErrorResponseExtensions>, IPetOperations
    {
        /// <summary>
        /// Initializes a new instance of the PetOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public PetOperations(XMSErrorResponseExtensions client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the XMSErrorResponseExtensions
        /// </summary>
        public XMSErrorResponseExtensions Client { get; private set; }

        /// <summary>
        /// Gets pets by id.
        /// </summary>
        /// <param name='petId'>
        /// pet id
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="T:Microsoft.Rest.RestException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<Pet>> GetPetByIdWithHttpMessagesAsync(string petId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (petId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "petId");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("petId", petId);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetPetById", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "errorStatusCodes/Pets/{petId}/GetPet").ToString();
            _url = _url.Replace("{petId}", System.Uri.EscapeDataString(petId));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if ((int)_statusCode != 200 && (int)_statusCode != 202)
            {
                try
                {
                    switch((int)_statusCode)
                    {
                        case 400:
                            await Handle400ErrorResponseForGetPetById(_httpRequest, _httpResponse);
                            break;
                        case 404:
                            await Handle404ErrorResponseForGetPetById(_httpRequest, _httpResponse);
                            break;
                        case 501:
                            await Handle501ErrorResponseForGetPetById(_httpRequest, _httpResponse);
                            break;
                        default:
                            await HandleDefaultErrorResponseForGetPetById(_httpRequest, _httpResponse, (int)_statusCode);
                            break;
                    }
                }
                catch(RestException ex)
                {
                    if (_shouldTrace)
                    {
                        ServiceClientTracing.Error(_invocationId, ex);
                    }
                    throw;
                }
            }
            // Create Result
            var _result = new HttpOperationResponse<Pet>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                string _responseContent = null;
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Pet>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Handle 400 errors
        /// </summary>
        /// <exception cref="T:Microsoft.Rest.RestException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task Handle400ErrorResponseForGetPetById(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse)
        {
            await HandleErrorResponseWithKnownTypeForGetPetById<string>(_httpRequest, _httpResponse, 400);
        }

        /// <summary>
        /// Handle 404 errors
        /// </summary>
        /// <exception cref="NotFoundErrorBaseException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task Handle404ErrorResponseForGetPetById(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse)
        {
            await HandleErrorResponseForGetPetById<NotFoundErrorBase>(_httpRequest, _httpResponse, 404, Client.DeserializationSettings);
        }

        /// <summary>
        /// Handle 501 errors
        /// </summary>
        /// <exception cref="T:Microsoft.Rest.RestException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task Handle501ErrorResponseForGetPetById(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse)
        {
            await HandleErrorResponseWithKnownTypeForGetPetById<int>(_httpRequest, _httpResponse, 501);
        }

        /// <summary>
        /// Handle other unhandled status codes
        /// </summary>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForGetPetById(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseWithKnownTypeForGetPetById<string>(_httpRequest, _httpResponse, statusCode);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForGetPetById(int statusCode)
        {
            return string.Format("Operation GetPetById returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle responses where error model is a known primary type
        /// Creates a RestException object and throws it
        /// </summary>
        /// <exception cref="T:Microsoft.Rest.RestException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleErrorResponseWithKnownTypeForGetPetById<T>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            string _responseContent = null;
            var ex = new RestException<T>(GetErrorMessageForGetPetById(statusCode))
                            {
                                HttpStatusCode = statusCode
                            };
            if (_httpResponse.Content != null)
            {
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<T>(_responseContent);
                    ex.Body = errorResponseModel;
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
            }
            else
            {
                _responseContent = string.Empty;
            }

            ex.Request = new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString());
            ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
            throw ex;
        }
        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForGetPetById<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IRestErrorModel
        {
            string errorMessage = GetErrorMessageForGetPetById(statusCode);
            string _responseContent = null;
            if (_httpResponse.Content != null)
            {
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                    if(errorResponseModel!=null)
                    {
                        errorResponseModel.CreateAndThrowException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent), statusCode);
                    }
                    else
                    {
                        throw new RestException<V>(errorMessage)
                            {
                                Request = new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()),
                                Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent),
                                HttpStatusCode = statusCode
                            };
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                    throw new RestException<V>(errorMessage)
                        {
                            Request = new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()),
                            Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent),
                            HttpStatusCode = statusCode
                        };
                }
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

        /// <summary>
        /// Asks pet to do something
        /// </summary>
        /// <param name='whatAction'>
        /// what action the pet should do
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="PetActionErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<PetAction>> DoSomethingWithHttpMessagesAsync(string whatAction, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (whatAction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "whatAction");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("whatAction", whatAction);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "DoSomething", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "errorStatusCodes/Pets/doSomething/{whatAction}").ToString();
            _url = _url.Replace("{whatAction}", System.Uri.EscapeDataString(whatAction));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if ((int)_statusCode != 200)
            {
                try
                {
                    switch((int)_statusCode)
                    {
                        case 500:
                            await Handle500ErrorResponseForDoSomething(_httpRequest, _httpResponse);
                            break;
                        default:
                            await HandleDefaultErrorResponseForDoSomething(_httpRequest, _httpResponse, (int)_statusCode);
                            break;
                    }
                }
                catch(RestException ex)
                {
                    if (_shouldTrace)
                    {
                        ServiceClientTracing.Error(_invocationId, ex);
                    }
                    throw;
                }
            }
            // Create Result
            var _result = new HttpOperationResponse<PetAction>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                string _responseContent = null;
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<PetAction>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Handle 500 errors
        /// </summary>
        /// <exception cref="PetActionErrorException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task Handle500ErrorResponseForDoSomething(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse)
        {
            await HandleErrorResponseForDoSomething<PetActionError>(_httpRequest, _httpResponse, 500, Client.DeserializationSettings);
        }

        /// <summary>
        /// Handle other unhandled status codes
        /// </summary>
        /// <exception cref="PetActionErrorException">
        /// Deserialize error body returned by the operation
        /// </exception>
        private async Task HandleDefaultErrorResponseForDoSomething(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode)
        {
            await HandleErrorResponseForDoSomething<PetActionError>(_httpRequest, _httpResponse, statusCode, Client.DeserializationSettings);
        }

        /// <summary>
        /// Method that generates error message for status code
        /// </summary>
        private string GetErrorMessageForDoSomething(int statusCode)
        {
            return string.Format("Operation DoSomething returned status code: '{0}'", statusCode);
        }

        /// <summary>
        /// Handle error responses, deserialize errors of types V and throw exceptions of type T
        /// </summary>
        private async Task HandleErrorResponseForDoSomething<V>(HttpRequestMessage _httpRequest, HttpResponseMessage _httpResponse, int statusCode, JsonSerializerSettings deserializationSettings)
            where V : IRestErrorModel
        {
            string errorMessage = GetErrorMessageForDoSomething(statusCode);
            string _responseContent = null;
            if (_httpResponse.Content != null)
            {
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var errorResponseModel = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<V>(_responseContent, deserializationSettings);
                    if(errorResponseModel!=null)
                    {
                        errorResponseModel.CreateAndThrowException(errorMessage, new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()), new HttpResponseMessageWrapper(_httpResponse, _responseContent), statusCode);
                    }
                    else
                    {
                        throw new RestException<V>(errorMessage)
                            {
                                Request = new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()),
                                Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent),
                                HttpStatusCode = statusCode
                            };
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                    throw new RestException<V>(errorMessage)
                        {
                            Request = new HttpRequestMessageWrapper(_httpRequest, _httpRequest.Content.AsString()),
                            Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent),
                            HttpStatusCode = statusCode
                        };
                }
            }
            _httpRequest.Dispose();
            if (_httpResponse != null)
            {
                _httpResponse.Dispose();
            }
        }

    }
}