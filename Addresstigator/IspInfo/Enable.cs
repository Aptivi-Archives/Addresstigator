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

using System.Xml.Serialization;

namespace Addresstigator
{

    /// <summary>
    /// The log-in server enablement instructions
    /// </summary>
    [XmlRoot(ElementName = "enable")]
    public class Enable
    {
        /// <summary>
        /// The instruction
        /// </summary>
        [XmlElement(ElementName = "instruction")]
        public string Instruction { get; set; }

        /// <summary>
        /// The URL to visit to enable login
        /// </summary>
        [XmlAttribute(AttributeName = "visiturl")]
        public string Visiturl { get; set; }
    }

}