// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SaveOptionsBaseDto.cs">
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
  /// Base options class
  /// </summary>  
  public class SaveOptionsBaseDto 
  {                       
        /// <summary>
        /// Start conversion from PageNumber page
        /// </summary>  
        public int? PageNumber { get; set; }

        /// <summary>
        /// Number of pages to convert
        /// </summary>  
        public int? NumPagesToConvert { get; set; }

        /// <summary>
        /// Convert specific pages. The list contains the page indexes of the pages to be converted
        /// </summary>  
        public List<int?> ConvertPages { get; set; }

        /// <summary>
        /// Watermark specific options
        /// </summary>  
        public WatermarkOptionsDto WatermarkOptions { get; set; }

        /// <summary>
        /// Show grid lines when converting Excel files
        /// </summary>  
        public bool? ShowGridLines { get; set; }

        /// <summary>
        /// Show hidden sheets when converting Excel files
        /// </summary>  
        public bool? ShowHiddenSheets { get; set; }

        /// <summary>
        /// Hide markup and track changes for Word documents
        /// </summary>  
        public bool? HideWordTrackedChanges { get; set; }

        /// <summary>
        /// CAD specific convert options
        /// </summary>  
        public CadOptionsDto CadOptions { get; set; }

        /// <summary>
        /// Hide annotations in Pdf documents
        /// </summary>  
        public bool? HidePdfAnnotations { get; set; }

        /// <summary>
        /// Hide comments during conversion if the source format support comments
        /// </summary>  
        public bool? HideComments { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveOptionsBaseDto {\n");
          sb.Append("  PageNumber: ").Append(this.PageNumber).Append("\n");
          sb.Append("  NumPagesToConvert: ").Append(this.NumPagesToConvert).Append("\n");
          sb.Append("  ConvertPages: ").Append(this.ConvertPages).Append("\n");
          sb.Append("  WatermarkOptions: ").Append(this.WatermarkOptions).Append("\n");
          sb.Append("  ShowGridLines: ").Append(this.ShowGridLines).Append("\n");
          sb.Append("  ShowHiddenSheets: ").Append(this.ShowHiddenSheets).Append("\n");
          sb.Append("  HideWordTrackedChanges: ").Append(this.HideWordTrackedChanges).Append("\n");
          sb.Append("  CadOptions: ").Append(this.CadOptions).Append("\n");
          sb.Append("  HidePdfAnnotations: ").Append(this.HidePdfAnnotations).Append("\n");
          sb.Append("  HideComments: ").Append(this.HideComments).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
