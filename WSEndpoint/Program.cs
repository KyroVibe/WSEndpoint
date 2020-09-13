using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using WebSocketSharp;
using WebSocketSharp.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WSEndpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var wssv = new WebSocketServer(IPAddress.Parse("127.0.0.1"), 8080);
            wssv.AddWebSocketService<WebSocketReceiver>("/wpilibws");

            wssv.Start();
            Console.ReadKey();
            wssv.Stop();
        }
    }

    public class WebSocketReceiver : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            // Console.WriteLine(e.Data);

            JObject a = JsonConvert.DeserializeObject<JObject>(e.Data);
            Console.WriteLine($"Type: {a["type"]}");

            // Send(msg);
        }
    }
}

/*while (!stream.DataAvailable)
                {
                    while (client.Available < 3)
                    {
                        // wait for enough bytes to be available
                    }

                    Byte[] bytes = new Byte[client.Available];

                    stream.Read(bytes, 0, bytes.Length);

                    //translate bytes of request to string
                    String data = Encoding.UTF8.GetString(bytes);
                    Console.WriteLine(data);

                    if (Regex.IsMatch(data, "^GET"))
                    {
                        const string eol = "\r\n"; // HTTP/1.1 defines the sequence CR LF as the end-of-line marker

                        Byte[] response = Encoding.UTF8.GetBytes("HTTP/1.1 101 Switching Protocols" + eol
                            + "Connection: Upgrade" + eol
                            + "Upgrade: websocket" + eol
                            + "Sec-WebSocket-Accept: " + Convert.ToBase64String(
                                System.Security.Cryptography.SHA1.Create().ComputeHash(
                                    Encoding.UTF8.GetBytes(
                                        new System.Text.RegularExpressions.Regex("Sec-WebSocket-Key: (.*)").Match(data).Groups[1].Value.Trim() + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"
                                    )
                                )
                            ) + eol
                            + eol);

                        stream.Write(response, 0, response.Length);
                    }
                    else
                    {

                    }
                }*/
