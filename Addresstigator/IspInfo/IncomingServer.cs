/*
 * MIT License
 *
 * Copyright (c) 2021 - 2022 Aptivi
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
	/// The incoming server information (POP3 or IMAP)
	/// </summary>
	[XmlRoot(ElementName = "incomingServer")]
    public class IncomingServer
	{
		/// <summary>
		/// The hostname for the server
		/// </summary>
		[XmlElement(ElementName = "hostname")]
		public string Hostname { get; set; }

		/// <summary>
		/// The port for the server. Usually 995 or 993, depending on the server.
		/// </summary>
		[XmlElement(ElementName = "port")]
		public int Port { get; set; }

		/// <summary>
		/// The socket type. Usually SSL or STARTTLS
		/// </summary>
		[XmlElement(ElementName = "socketType")]
		public string SocketType { get; set; }

		/// <summary>
		/// The username indicator. Usually, it's set to %EMAILADDRESS%, which means the E-mail address placeholder.
		/// </summary>
		[XmlElement(ElementName = "username")]
		public string Username { get; set; }

		/// <summary>
		/// The authentication methods
		/// </summary>
		[XmlElement(ElementName = "authentication")]
		public List<string> Authentication { get; set; }

		/// <summary>
		/// The server type. Usually "imap" or "pop3"
		/// </summary>
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		/// <summary>
		/// POP3 server properties
		/// </summary>
		[XmlElement(ElementName = "pop3")]
		public Pop3 Pop3 { get; set; }
	}

}