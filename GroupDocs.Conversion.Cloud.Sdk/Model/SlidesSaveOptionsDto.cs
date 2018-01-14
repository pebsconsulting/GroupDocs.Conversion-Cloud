// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SlidesSaveOptionsDto.cs">
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
  /// Slides save options
  /// </summary>  
  public class SlidesSaveOptionsDto : SaveOptionsBaseDto 
  {                       
        /// <summary>
        /// The desired file type to which the input document should be converted to
        /// </summary>
        /// <value>The desired file type to which the input document should be converted to</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConvertFileTypeEnum
        { 
            /// <summary>
            /// Enum Ppt for "Ppt"
            /// </summary>            
            Ppt,
            
            /// <summary>
            /// Enum Pps for "Pps"
            /// </summary>            
            Pps,
            
            /// <summary>
            /// Enum Pptx for "Pptx"
            /// </summary>            
            Pptx,
            
            /// <summary>
            /// Enum Ppsx for "Ppsx"
            /// </summary>            
            Ppsx,
            
            /// <summary>
            /// Enum Odp for "Odp"
            /// </summary>            
            Odp,
            
            /// <summary>
            /// Enum Otp for "Otp"
            /// </summary>            
            Otp            
        }

        /// <summary>
        /// The desired file type to which the input document should be converted to
        /// </summary>
        public ConvertFileTypeEnum? ConvertFileType { get; set; }

        /// <summary>
        /// Set this property if you want to protect the converted document with a password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SlidesSaveOptionsDto {\n");
          sb.Append("  ConvertFileType: ").Append(this.ConvertFileType).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
