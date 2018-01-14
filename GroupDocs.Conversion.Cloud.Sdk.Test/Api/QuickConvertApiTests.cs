using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    public class QuickConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test QuickConvert
        /// </summary>
        [Test]
        public void QuickConvert()
        {
            var file = TestFiles.OnePageDocx;

            var request = new QuickConvertRequest
            {
                Settings = new QuickConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Format = "jpg"
                }
            };

            var response = ConversionApi.QuickConvert(request);

            Assert.IsNotNull(response);
            Assert.That(() => response.Href.EndsWith(".jpg"));
        }

        /// <summary>
        /// Test QuickConvertToStream
        /// </summary>
        [Test]
        public void QuickConvertToStream()
        {
            var file = TestFiles.OnePageDocx;

            var request = new QuickConvertToStreamRequest
            {
                Settings = new QuickConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Format = "jpg"
                }
            };

            var response = ConversionApi.QuickConvertToStream(request);

            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }
    }
}