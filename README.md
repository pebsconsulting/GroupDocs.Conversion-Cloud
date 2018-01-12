# GroupDocs.Conversion for Cloud SDKs
This folder contains SDKs for [GroupDocs.Conversion for Cloud](https://products.groupdocs.cloud/conversion/cloud) for various platforms.

# Currently Available SDKs

Directory | Description
--------- | -----------
[.NET SDK](SDKs/NET) | GroupDocs.Conversion for Cloud .NET SDK

To use these SDKs, you will need App SID and App Key which can be looked up at [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud) (free registration in GroupDocs Cloud is required for this).

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Conversion.Cloud.Sdk;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud/ (free registration is required).
            var configuration = new Configuration
            {
                AppSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };

            var apiInstance = new ConversionApi(configuration);

            try
            {
                var request = new GetAllPossibleConversionsRequest();

                // Get supported file formats
                var response = ConversionApi.GetAllPossibleConversions(request);

                foreach (var entry in response)
                {
                   Debug.Print(string.Format("{0}: {1}", entry.SourceFileType,
                        string.Join(",", entry.PossibleConversions));
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversionApi.GetAllPossibleConversions: " + e.Message);
            }
        }
    }
}
```

# Licensing
All GroupDocs.Conversion for Cloud SDKs are licensed under [MIT License](LICENSE).

# Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/conversion/cloud)
+ [**Documentation**](https://docs.groupdocs.cloud/display/conversioncloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/conversion)
+ [**Blog**](https://blog.groupdocs.cloud/category/groupdocs-products/groupdocs-conversion-product-family)