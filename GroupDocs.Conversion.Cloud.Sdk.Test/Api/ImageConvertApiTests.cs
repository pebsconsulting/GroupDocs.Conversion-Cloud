using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    public class ImageConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertToImage
        /// </summary>
        [Test]
        public void ConvertToImage()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToImageRequest
            {
                Settings = new ImageConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new ImageSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToImage(request);

            Assert.IsNotNull(response);
            Assert.That(() => response.Href.EndsWith(".jpg"));
        }

        /// <summary>
        /// Test ConvertToImageStream
        /// </summary>
        [Test]
        public void ConvertToImageStream()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToImageStreamRequest
            {
                Settings = new ImageConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new ImageSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToImageStream(request);

            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }
    }
}