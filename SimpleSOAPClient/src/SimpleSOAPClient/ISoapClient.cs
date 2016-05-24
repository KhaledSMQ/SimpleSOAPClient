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
namespace SimpleSOAPClient
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Handlers;
    using Models;

    public interface ISoapClient
    {
        /// <summary>
        /// Handler collection that can manipulate the <see cref="SoapEnvelope"/>
        /// before serialization.
        /// </summary>
        ICollection<Action<ISoapClient, IRequestEnvelopeHandlerData>> RequestEnvelopeHandlers { get; }

        /// <summary>
        /// Handler collection that can manipulate the generated XML string.
        /// </summary>
        ICollection<Action<ISoapClient, IRequestRawHandlerData>> RequestRawHandlers { get; }

        /// <summary>
        /// Handler collection that can manipulate the <see cref="SoapEnvelope"/> returned
        /// by the SOAP Endpoint.
        /// </summary>
        ICollection<Action<ISoapClient, IResponseEnvelopeHandlerData>> ResponseEnvelopeHandlers { get; }

        /// <summary>
        /// Handler collection that can manipulate the returned string before deserialization.
        /// </summary>
        ICollection<Action<ISoapClient, IResponseRawHandlerData>> ResponseRawHandlers { get; }

        /// <summary>
        /// Indicates if the XML declaration should be removed from the
        /// serialized SOAP Envelopes
        /// </summary>
        bool RemoveXmlDeclaration { get; set; }

        /// <summary>
        /// Sends the given <see cref="SoapEnvelope"/> into the specified url.
        /// </summary>
        /// <param name="url">The url that will receive the request</param>
        /// <param name="action">The SOAP action beeing performed</param>
        /// <param name="requestEnvelope">The <see cref="SoapEnvelope"/> to be sent</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>A task to be awaited for the result</returns>
        /// <exception cref="ArgumentNullException"></exception>
        Task<SoapEnvelope> SendAsync(
            string url, string action, SoapEnvelope requestEnvelope, CancellationToken ct = default(CancellationToken));

        /// <summary>
        /// Sends the given <see cref="SoapEnvelope"/> into the specified url.
        /// </summary>
        /// <param name="url">The url that will receive the request</param>
        /// <param name="action">The SOAP Action beeing performed</param>
        /// <param name="requestEnvelope">The <see cref="SoapEnvelope"/> to be sent</param>
        /// <returns>The resulting <see cref="SoapEnvelope"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        SoapEnvelope Send(string url, string action, SoapEnvelope requestEnvelope);
    }
}