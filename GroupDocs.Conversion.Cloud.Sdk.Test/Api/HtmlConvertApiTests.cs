using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    public class HtmlConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertToHtml
        /// </summary>
        [Test]
        public void ConvertToHtml()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToHtmlRequest
            {
                Settings = new HtmlConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new HtmlSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToHtml(request);

            Assert.IsNotNull(response);
            Assert.That(() => response.Href.EndsWith(".html"));
        }

        /// <summary>
        /// Test ConvertToHtmlStream
        /// </summary>
        [Test]
        public void ConvertToHtmlStream()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToHtmlStreamRequest
            {
                Settings = new HtmlConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new HtmlSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToHtmlStream(request);

            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }
    }
}