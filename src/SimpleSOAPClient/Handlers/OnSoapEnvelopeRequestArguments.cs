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
namespace SimpleSOAPClient.Handlers
{
    using System;
    using Models;

    /// <summary>
    /// The SOAP Handler arguments for <see cref="ISoapHandler.OnSoapEnvelopeRequest"/> method.
    /// </summary>
    public sealed class OnSoapEnvelopeRequestArguments : SoapHandlerArguments
    {
        private SoapEnvelope _envelopeV1Dot1;
        private Models.V1_2.SoapEnvelope _envelopeV1Dot2;

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="envelope">The SOAP envelope version 1.1</param>
        /// <param name="url">The SOAP service url</param>
        /// <param name="action">The SOAP action</param>
        /// <param name="trackingId">An optional tracking id</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public OnSoapEnvelopeRequestArguments(SoapEnvelope envelope, string url, string action, Guid? trackingId = null)
            : base(url, action, trackingId)
        {
            if (envelope == null) throw new ArgumentNullException(nameof(envelope));

            _envelopeV1Dot1 = envelope;
        }
        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="envelope">The SOAP envelope version 1.2</param>
        /// <param name="url">The SOAP service url</param>
        /// <param name="action">The SOAP action</param>
        /// <param name="trackingId">An optional tracking id</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public OnSoapEnvelopeRequestArguments(Models.V1_2.SoapEnvelope envelope, string url, string action, Guid? trackingId = null)
            : base(url, action, trackingId)
        {
            if (envelope == null) throw new ArgumentNullException(nameof(envelope));

            _envelopeV1Dot2 = envelope;
        }

        /// <summary>
        /// The SOAP Envelope to be serialized
        /// </summary>
        public SoapEnvelope EnvelopeV1Dot1
        {
            get { return _envelopeV1Dot1; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                _envelopeV1Dot1 = value;
            }
        }

        /// <summary>
        /// The SOAP Envelope version 1.2 to be serialized
        /// </summary>
        public Models.V1_2.SoapEnvelope EnvelopeV1Dot2
        {
            get { return _envelopeV1Dot2; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                _envelopeV1Dot2 = value;
            }
        }
    }
}