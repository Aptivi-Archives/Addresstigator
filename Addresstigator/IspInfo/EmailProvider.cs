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

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Addresstigator
{

	/// <summary>
	/// The E-mail provider (ISP) information
	/// </summary>
    [XmlRoot(ElementName = "emailProvider")]
    public class EmailProvider
    {
		/// <summary>
		/// The list of domains
		/// </summary>
		[XmlElement(ElementName = "domain")]
		public List<string> Domain { get; set; }

		/// <summary>
		/// The full name for the ISP mail server
		/// </summary>
		[XmlElement(ElementName = "displayName")]
		public string DisplayName { get; set; }

		/// <summary>
		/// The short name for the ISP mail server
		/// </summary>
		[XmlElement(ElementName = "displayShortName")]
		public string DisplayShortName { get; set; }

		/// <summary>
		/// List of incoming servers
		/// </summary>
		[XmlElement(ElementName = "incomingServer")]
		public List<IncomingServer> IncomingServer { get; set; }

		/// <summary>
		/// Outgoing server
		/// </summary>
		[XmlElement(ElementName = "outgoingServer")]
		public OutgoingServer OutgoingServer { get; set; }

		/// <summary>
		/// Documentation information
		/// </summary>
		[XmlElement(ElementName = "documentation")]
		public List<Documentation> Documentation { get; set; }

		/// <summary>
		/// The dominating domain
		/// </summary>
		[XmlAttribute(AttributeName = "id")]
		public string DominatingDomain { get; set; }
	}

}