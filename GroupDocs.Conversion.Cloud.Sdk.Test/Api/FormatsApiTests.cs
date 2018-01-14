namespace GroupDocs.Conversion.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

    public class FormatsApiTests : BaseApiTest
    {
        /// <summary>
        /// Test GetSupportedFileFormats
        /// </summary>
        [Test]
        public void GetSupportedFileFormatsTest()
        {
            var request = new GetAllPossibleConversionsRequest();

            var response = ConversionApi.GetAllPossibleConversions(request);

            Assert.IsTrue(response.Count > 0);
            foreach (var entry in response)
            {
                Assert.IsNotEmpty(entry.SourceFileType);
                Assert.IsNotEmpty(entry.PossibleConversions);
            }
        }
    }
}