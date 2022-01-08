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
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Addresstigator
{
    /// <summary>
    /// Internet Service Provider server information
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// Gets the ISP configuration for the specified mail address
        /// </summary>
        /// <param name="address">The mail address to parse. Must include the ISP hostname.</param>
        /// <param name="beta">Whether to use the Thunderbird staging server</param>
        /// <returns>The ISP client config for specified mail address</returns>
        public static ClientConfig GetIspConfig(string address, bool staging = false)
        {
            // Database addresses
            string databaseAddress = "https://autoconfig.thunderbird.net/v1.1/";
            string stagingDatabaseAddress = "https://autoconfig-stage.thunderbird.net/v1.1/";

            // Get the final database address
            string hostName = new Uri($"mailto:{address}").Host;
            string finalDatabaseAddress = $"{databaseAddress}{hostName}";
            if (staging)
                finalDatabaseAddress = $"{stagingDatabaseAddress}{hostName}";

            // Apparently, the XML documents grabbed from the database don't have this below XML header
            StringBuilder xmlBuilder = new StringBuilder();
            xmlBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");

            // Get the XML document for the ISP
            WebClient client = new WebClient();
            xmlBuilder.AppendLine(client.DownloadString(finalDatabaseAddress));
            string xmlContent = xmlBuilder.ToString();

            // Get the client config
            ClientConfig clientConfig;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClientConfig), new XmlRootAttribute("clientConfig") { IsNullable = false });
            StringReader sr = new StringReader(xmlContent);
            clientConfig = (ClientConfig) xmlSerializer.Deserialize(sr);
            return clientConfig;
        }
    }
}
