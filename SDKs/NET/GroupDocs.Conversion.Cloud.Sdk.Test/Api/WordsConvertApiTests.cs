using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using GroupDocs.Conversion.Cloud.Sdk.Test.Internal;
using NUnit.Framework;

namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    public class WordsConvertApiTests : BaseApiTest
    {
        /// <summary>
        /// Test ConvertToWords
        /// </summary>
        [Test]
        public void ConvertToWords()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToWordsRequest
            {
                Settings = new WordsConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new WordsSaveOptionsDto
                    {
                        ConvertFileType = WordsSaveOptionsDto.ConvertFileTypeEnum.Doc
                    }
                }
            };

            var response = ConversionApi.ConvertToWords(request);

            Assert.IsNotNull(response);
            Assert.That(() => response.Href.EndsWith(".doc"));
        }

        /// <summary>
        /// Test ConverToWordsStream
        /// </summary>
        [Test]
        public void ConvertToWordsStream()
        {
            var file = TestFiles.OnePageDocx;

            var request = new ConvertToWordsStreamRequest
            {
                Settings = new WordsConversionSettings
                {
                    SourceFile = ToConversionFileInfo(file),
                    Options = new WordsSaveOptionsDto()
                }
            };

            var response = ConversionApi.ConvertToWordsStream(request);

            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }
    }
}