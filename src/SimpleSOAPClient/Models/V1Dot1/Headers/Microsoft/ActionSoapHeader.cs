#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 Jo�o Sim�es
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion
namespace SimpleSOAPClient.Models.V1Dot1.Headers.Microsoft
{
    using System.Xml.Serialization;

    /// <summary>
    /// The Microsoft Action SOAP Header
    /// </summary>
    [XmlRoot("Action", Namespace = Constant.Namespace.ComMicrosoftSchemasWs200505AddressingNone)]
    public class ActionSoapHeader : SoapHeader
    {
        /// <summary>
        /// The header action content
        /// </summary>
        [XmlText]
        public string Action { get; set; }
    }
}