/*
 * MIT License
 *
 * Copyright (c) 2021 - 2022 EoflaOE and its companies
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */

using System;
using System.Xml.Serialization;

namespace Addresstigator
{

	/// <summary>
	/// Client configuration parameters
	/// </summary>
    [XmlRoot(ElementName = "clientConfig")]
    public class ClientConfig
    {
		/// <summary>
		/// The E-mail provider (ISP) information
		/// </summary>
		[XmlElement(ElementName = "emailProvider")]
		public EmailProvider EmailProvider { get; set; }

		/// <summary>
		/// The OAuth2 information for the ISP's mail server
		/// </summary>
		[XmlElement(ElementName = "oAuth2")]
		public OAuth2 OAuth2 { get; set; }

		/// <summary>
		/// The log-in server enablement instructions
		/// </summary>
		[XmlElement(ElementName = "enable")]
		public Enable Enable { get; set; }

		/// <summary>
		/// The webmail configuration
		/// </summary>
		[XmlElement(ElementName = "webMail")]
		public WebMail WebMail { get; set; }
	}

}