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

using Terminal = System.Console;

namespace Addresstigator.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the ISP config
            ClientConfig config = Tools.GetIspConfig(args[0]);

            // Show brief information
            Terminal.WriteLine($"Display name: {config.EmailProvider.DisplayName}");
            Terminal.WriteLine($"Dominating domain: {config.EmailProvider.DominatingDomain}");
            Terminal.WriteLine("--------------------");

            // Show incoming server information
            foreach (IncomingServer server in config.EmailProvider.IncomingServer)
            {
                Terminal.WriteLine($"Server hostname: {server.Hostname}");
                Terminal.WriteLine($"Server port: {server.Port}");
                Terminal.WriteLine($"Server type: {server.Type}");
                Terminal.WriteLine($"Server socket type: {server.SocketType}");
                Terminal.WriteLine($"Server username placeholder: {server.Username}");
            }
            Terminal.WriteLine("--------------------");

            // Show outgoing server information
            Terminal.WriteLine($"Server hostname: {config.EmailProvider.OutgoingServer.Hostname}");
            Terminal.WriteLine($"Server port: {config.EmailProvider.OutgoingServer.Port}");
            Terminal.WriteLine($"Server type: {config.EmailProvider.OutgoingServer.Type}");
            Terminal.WriteLine($"Server socket type: {config.EmailProvider.OutgoingServer.SocketType}");
            Terminal.WriteLine($"Server username placeholder: {config.EmailProvider.OutgoingServer.Username}");
            Terminal.WriteLine("--------------------");
        }
    }
}
