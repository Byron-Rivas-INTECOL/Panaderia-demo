using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace InterfazImpresora.Datos
{
    class clienteTCP
    {
        public string ip { get; set; }
        public int port { get; set; }
        public TcpClient cliente { get; set; }
    }
    internal class Tcp
    {
        public static Stream stream2;
        public static TcpClient tcpClient;
        


        public static void Connect(string ip, int port) {

            try
            {
                tcpClient = new TcpClient(ip, port);
                stream2 = tcpClient.GetStream();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion" + ex.Message);
            }

        }

        public static void Send(string text2send)
        {
            //  ^0=MR1.MUL.1612345623.//primera posicion buffer
            // ^0=ETMUL1612345623.//editar impresora sin contador 
            Byte [] data = Encoding.ASCII.GetBytes(text2send);
            data[data.Length - 1] = 13;
            stream2.Write(data, 0, data.Length);
        }
        public static string SendRecieve(string text2send)
        {
            try
            {

                //  ^0=MR1.MUL.1612345623.//primera posicion buffer
                // ^0=ETMUL1612345623.//editar impresora sin contador 
                Byte[] data = Encoding.ASCII.GetBytes(text2send);
                //data[data.Length - 1] = 13;
                stream2.Write(data, 0, data.Length);


                data = new byte[1000000];
                String responseData = String.Empty;
                Int32 bytes = stream2.Read(data, 0, data.Length);
                responseData = Encoding.ASCII.GetString(data, 0, bytes);
                return responseData;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
