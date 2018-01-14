// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ConversionApi.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Conversion.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using GroupDocs.Conversion.Cloud.Sdk.Api;
    using GroupDocs.Conversion.Cloud.Sdk.Internal;
    using GroupDocs.Conversion.Cloud.Sdk.Internal.RequestHandlers;
    using GroupDocs.Conversion.Cloud.Sdk.Model;
    using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Conversion for Cloud API.
    /// </summary>
    public class ConversionApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public ConversionApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ConversionApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Returns document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToCellsRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link ConvertToCells(ConvertToCellsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/cells";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Returns stream of document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToCellsStreamRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertToCellsStream(ConvertToCellsStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/cells/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }

        /// <summary>
        /// Returns document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToHtmlRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link ConvertToHtml(ConvertToHtmlRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/html";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Returns stream of document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToHtmlStreamRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertToHtmlStream(ConvertToHtmlStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/html/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }

        /// <summary>
        /// Returns document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToImageRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link ConvertToImage(ConvertToImageRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/image";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Returns stream of document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToImageStreamRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertToImageStream(ConvertToImageStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/image/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }

        /// <summary>
        /// Returns document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToPdfRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link ConvertToPdf(ConvertToPdfRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Returns stream of document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToPdfStreamRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertToPdfStream(ConvertToPdfStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/pdf/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }

        /// <summary>
        /// Returns document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToSlidesRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link ConvertToSlides(ConvertToSlidesRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/slides";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Returns stream of document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToSlidesStreamRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertToSlidesStream(ConvertToSlidesStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/slides/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }

        /// <summary>
        /// Returns document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToWordsRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link ConvertToWords(ConvertToWordsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/words";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Returns stream of document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertToWordsStreamRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream ConvertToWordsStream(ConvertToWordsStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/words/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }

        /// <summary>
        /// Retrieves all possible conversions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetAllPossibleConversionsRequest" /></param>
        /// <returns><see cref="List&lt;PossibleConversionResponse&gt;"/></returns>
        public List<PossibleConversionResponse> GetAllPossibleConversions(GetAllPossibleConversionsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (List<PossibleConversionResponse>)SerializationHelper.Deserialize(response, typeof(List<PossibleConversionResponse>));
            }

            return null;
        }

        /// <summary>
        /// Retrieves all possible conversions for the specified file type 
        /// </summary>
        /// <param name="request">Request. <see cref="GetPossibleConversionsForFileTypeRequest" /></param>
        /// <returns><see cref="PossibleConversionResponse"/></returns>
        public PossibleConversionResponse GetPossibleConversionsForFileType(GetPossibleConversionsForFileTypeRequest request)
        {
            // verify the required parameter 'extension' is set
            if (request.Extension == null) 
            {
                throw new ApiException(400, "Missing required parameter 'extension' when calling GetPossibleConversionsForFileType");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/{extension}/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "extension", request.Extension);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (PossibleConversionResponse)SerializationHelper.Deserialize(response, typeof(PossibleConversionResponse));
            }

            return null;
        }

        /// <summary>
        /// Retrieves all possible conversions for the specified document type. Document is passed in request body 
        /// </summary>
        /// <param name="request">Request. <see cref="PossibleConversionsForDocumentRequest" /></param>
        /// <returns><see cref="PossibleConversionResponse"/></returns>
        public PossibleConversionResponse PossibleConversionsForDocument(PossibleConversionsForDocumentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (PossibleConversionResponse)SerializationHelper.Deserialize(response, typeof(PossibleConversionResponse));
            }

            return null;
        }

        /// <summary>
        /// Returns document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="QuickConvertRequest" /></param>
        /// <returns><see cref="Link"/></returns>
        public Link QuickConvert(QuickConvertRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/quick";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (Link)SerializationHelper.Deserialize(response, typeof(Link));
            }

            return null;
        }

        /// <summary>
        /// Returns stream of document with the result of conversion 
        /// </summary>
        /// <param name="request">Request. <see cref="QuickConvertToStreamRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream QuickConvertToStream(QuickConvertToStreamRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/conversion/quick/stream";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.Settings); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
            }

            return null;
        }
    }
}
