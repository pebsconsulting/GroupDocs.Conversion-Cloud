// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImageSaveOptionsDto.cs">
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

namespace GroupDocs.Conversion.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Image save options
  /// </summary>  
  public class ImageSaveOptionsDto : SaveOptionsBaseDto 
  {                       
        /// <summary>
        /// The desired file type to which the input document should be converted to
        /// </summary>
        /// <value>The desired file type to which the input document should be converted to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConvertFileTypeEnum
        { 
            /// <summary>
            /// Enum Tiff for "Tiff"
            /// </summary>            
            Tiff,
            
            /// <summary>
            /// Enum Tif for "Tif"
            /// </summary>            
            Tif,
            
            /// <summary>
            /// Enum Jpg for "Jpg"
            /// </summary>            
            Jpg,
            
            /// <summary>
            /// Enum Jpeg for "Jpeg"
            /// </summary>            
            Jpeg,
            
            /// <summary>
            /// Enum Png for "Png"
            /// </summary>            
            Png,
            
            /// <summary>
            /// Enum Gif for "Gif"
            /// </summary>            
            Gif,
            
            /// <summary>
            /// Enum Bmp for "Bmp"
            /// </summary>            
            Bmp,
            
            /// <summary>
            /// Enum Ico for "Ico"
            /// </summary>            
            Ico,
            
            /// <summary>
            /// Enum Psd for "Psd"
            /// </summary>            
            Psd,
            
            /// <summary>
            /// Enum Webp for "Webp"
            /// </summary>            
            Webp,
            
            /// <summary>
            /// Enum Svg for "Svg"
            /// </summary>            
            Svg            
        }

        /// <summary>
        /// The desired file type to which the input document should be converted to
        /// </summary>
        public ConvertFileTypeEnum? ConvertFileType { get; set; }

        /// <summary>
        /// Desired image width after conversion
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Desired image height after conversion
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// If true, the input firstly is converted to PDF and after that to desired format
        /// </summary>  
        public bool? UsePdf { get; set; }

        /// <summary>
        /// Desired image horizontal resolution after conversion. The default resolution is the resolution of the input file or 96dpi
        /// </summary>  
        public int? HorizontalResolution { get; set; }

        /// <summary>
        /// Desired image vertical resolution after conversion. The default resolution is the resolution of the input file or 96dpi
        /// </summary>  
        public int? VerticalResolution { get; set; }

        /// <summary>
        /// Desired image quality when converting to Jpeg. The value must be between 0 and 100. The default value is 100.
        /// </summary>  
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Tiff specific convert options
        /// </summary>  
        public TiffOptionsDto TiffOptions { get; set; }

        /// <summary>
        /// Psd specific convert options
        /// </summary>  
        public PsdOptionsDto PsdOptions { get; set; }

        /// <summary>
        /// Webp specific convert options
        /// </summary>  
        public WebpOptionsDto WebpOptions { get; set; }

        /// <summary>
        /// Convert to grayscale image
        /// </summary>  
        public bool? Grayscale { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImageSaveOptionsDto {\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  UsePdf: ").Append(this.UsePdf).Append("\n");
          sb.Append("  ConvertFileType: ").Append(this.ConvertFileType).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  TiffOptions: ").Append(this.TiffOptions).Append("\n");
          sb.Append("  PsdOptions: ").Append(this.PsdOptions).Append("\n");
          sb.Append("  WebpOptions: ").Append(this.WebpOptions).Append("\n");
          sb.Append("  Grayscale: ").Append(this.Grayscale).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
