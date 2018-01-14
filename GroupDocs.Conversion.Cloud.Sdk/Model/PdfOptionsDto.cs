// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PdfOptionsDto.cs">
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
  /// Pdf options
  /// </summary>  
  public class PdfOptionsDto 
  {                       
        /// <summary>
        /// Set the pdf format of the converted document.
        /// </summary>
        /// <value>Set the pdf format of the converted document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PdfFormatEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum PdfA1A for "PdfA_1A"
            /// </summary>            
            PdfA1A,
            
            /// <summary>
            /// Enum PdfA1B for "PdfA_1B"
            /// </summary>            
            PdfA1B,
            
            /// <summary>
            /// Enum PdfA2A for "PdfA_2A"
            /// </summary>            
            PdfA2A,
            
            /// <summary>
            /// Enum PdfA3A for "PdfA_3A"
            /// </summary>            
            PdfA3A,
            
            /// <summary>
            /// Enum PdfA2B for "PdfA_2B"
            /// </summary>            
            PdfA2B,
            
            /// <summary>
            /// Enum PdfA2U for "PdfA_2U"
            /// </summary>            
            PdfA2U,
            
            /// <summary>
            /// Enum PdfA3B for "PdfA_3B"
            /// </summary>            
            PdfA3B,
            
            /// <summary>
            /// Enum PdfA3U for "PdfA_3U"
            /// </summary>            
            PdfA3U,
            
            /// <summary>
            /// Enum V13 for "v1_3"
            /// </summary>            
            V13,
            
            /// <summary>
            /// Enum V14 for "v1_4"
            /// </summary>            
            V14,
            
            /// <summary>
            /// Enum V15 for "v1_5"
            /// </summary>            
            V15,
            
            /// <summary>
            /// Enum V16 for "v1_6"
            /// </summary>            
            V16,
            
            /// <summary>
            /// Enum V17 for "v1_7"
            /// </summary>            
            V17,
            
            /// <summary>
            /// Enum PdfX1A for "PdfX_1A"
            /// </summary>            
            PdfX1A,
            
            /// <summary>
            /// Enum PdfX3 for "PdfX3"
            /// </summary>            
            PdfX3            
        }

        /// <summary>
        /// Set the pdf format of the converted document.
        /// </summary>
        public PdfFormatEnum? PdfFormat { get; set; }

        /// <summary>
        /// Remove Pdf-A Compliance
        /// </summary>  
        public bool? RemovePdfaCompliance { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfOptionsDto {\n");
          sb.Append("  PdfFormat: ").Append(this.PdfFormat).Append("\n");
          sb.Append("  RemovePdfaCompliance: ").Append(this.RemovePdfaCompliance).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
