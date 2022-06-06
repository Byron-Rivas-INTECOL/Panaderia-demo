using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazImpresora.Datos;
using InterfazImpresora.Entidad;
using System.Net.Sockets;


namespace InterfazImpresora.Entidad
{
    internal class Zebra
    {
        public static Datos.clienteTCP impresoraTCP = new clienteTCP();
        public static TcpClient impresoraTcp=new TcpClient();

        public static bool ValidarConeccion()
        {
            Periferco zebra = new();//Byron
            zebra.Port = Convert.ToInt32((EParametro.ZebraPort));
            zebra.Ip = EParametro.ZebraIp;

            if (impresoraTcp.Connected) zebra.En_error = false;


            try
            {
                if (!impresoraTcp.Connected)
                {
                    impresoraTcp.Connect(zebra.Ip, zebra.Port);
                    int port = Convert.ToInt32((EParametro.ZebraPort));
                    string ip = EParametro.ZebraIp;
                    impresoraTcp.Connect(ip,port);
                }

                if (impresoraTcp.Connected)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void Print() {
            if (ValidarConeccion())
            {

            }

            if (LeerEstado() == "Hay errores:\r\n\r\nPaused\r\n\r\nSin Advertencias")
            {
                Datos.Tcp.SendRecieve(E_imprimir_etiqueta.Contenido);
            }

            //Datos.Tcp.SendRecieve(GenerateZpl(InterfazImpresora.Datos.ObtenerDb.LeerCajasV2()));
        }
        public static string LeerEstado() {

            //Tcp.Connect("10.52.0.210", 9100);
            string recieveRaw = Tcp.SendRecieve("^XA~HQES^XZ");
            recieveRaw = recieveRaw.Replace(" ", string.Empty);
            recieveRaw = recieveRaw.Replace("\n", string.Empty);
            recieveRaw = recieveRaw.Replace("\r", string.Empty);
            recieveRaw = recieveRaw.Replace("\u0002", string.Empty);
            recieveRaw = recieveRaw.Replace("\u0003", string.Empty);

            var punteros = recieveRaw.IndexOf(":");
            var punteros2 = recieveRaw.LastIndexOf(":");

            string Errores = recieveRaw.Substring(punteros + 1, 17);
            string err = ValidarErrores(Errores);
            string Advertencias = recieveRaw.Substring(punteros2 + 1, 17);
            string adv = ValidarAdvertencias(Advertencias);

            string result = err + adv;

            return result;

        }

        private static string ValidarErrores(string errores)
        {
            string resp = string.Empty;
            if (errores.Substring(0, 1) == "0") resp = "Sin errores";
            else
            {
                resp = "Hay errores:\r\n\r\n";
                // Nibble 5
                switch (errores.Substring(12, 1))
                {
                    case "1":
                        resp += "Paused\r\n";
                        break;
                    case "2":
                        resp += "Retract Function timed out\r\n";
                        break;
                    case "4":
                        resp += "Black Mark Calibrate Error\r\n";
                        break;
                    case "8":
                        resp += "Black Mark not Found\r\n";
                        break;
                }
                // Nibble 4
                switch (errores.Substring(13, 1))
                {
                    case "1":
                        resp += "Paper Jam during Retract\r\n";
                        break;
                    case "2":
                        resp += "Presenter Not Running\r\n";
                        break;
                    case "4":
                        resp += "Paper Feed Error\r\n";
                        break;
                    case "8":
                        resp += "Clear Paper Path Failed\r\n";
                        break;
                }
                // Nibble 3
                switch (errores.Substring(14, 1))
                {
                    case "1":
                        resp += "Invalid Firmware Config\r\n";
                        break;
                    case "2":
                        resp += "Printhead Thermistor Open\r\n";
                        break;
                }
                // Nibble 2
                switch (errores.Substring(15, 1))
                {
                    case "1":
                        resp += "Printhead Over Temperature\r\n";
                        break;
                    case "2":
                        resp += "Motor Over Temperature\r\n";
                        break;
                    case "4":
                        resp += "Bad Printhead Element\r\n";
                        break;
                    case "8":
                        resp += "Printhead Detection Error\r\n";
                        break;
                }
                // Nibble 1
                switch (errores.Substring(16, 1))
                {
                    case "1":
                        resp += "Media Out\r\n";
                        break;
                    case "2":
                        resp += "Ribbon Out \r\n";
                        break;
                    case "4":
                        resp += "Head Open\r\n";
                        break;
                    case "8":
                        resp += "Cutter Fault\r\n";
                        break;
                }
            }
            return resp;
        }

        private static string ValidarAdvertencias(string advertencias)
        {
            string resp = string.Empty;
            if (advertencias.Substring(0, 1) == "0") resp = "\r\nSin Advertencias";
            else
            {
                resp = "\r\nHay advertencias:\r\n\r\n";
                // Nibble 3
                switch (advertencias.Substring(14, 1))
                {
                    case "1":
                        resp += "Sensor 5 (presenter)\r\n";
                        break;
                    case "2":
                        resp += "Sensor 6 (retract ready)\r\n";
                        break;
                    case "4":
                        resp += "Sensor 7 (in retract)\r\n";
                        break;
                    case "8":
                        resp += "Sensor 8 (at bin)\r\n";
                        break;
                }
                // Nibble 2
                switch (advertencias.Substring(15, 1))
                {
                    case "1":
                        resp += "Sensor 1 (Paper before head)\r\n";
                        break;
                    case "2":
                        resp += "Sensor 2 (Black mark)\r\n";
                        break;
                    case "4":
                        resp += "Sensor 3 (Paper after head)\r\n";
                        break;
                    case "8":
                        resp += "Sensor 4 (loop ready)\r\n";
                        break;
                }
                // Nibble 1
                switch (advertencias.Substring(16, 1))
                {
                    case "1":
                        resp += "Need to Calibrate Media\r\n";
                        break;
                    case "2":
                        resp += "Clean Printhead\r\n";
                        break;
                    case "4":
                        resp += "Replace Printhead\r\n";
                        break;
                    case "8":
                        resp += "Paper-near-end Sensor\r\n";
                        break;
                }
            }
            return resp;
        }


        public static string GenerateZpl(List<string> contenidoLb) { //obsoleto

            return ("^XA" +
            "^CI28" +

            "^FO20,10^XGE:LOGO.GRF^FS" +

            "^FT400,40^A0N,28,28^FH\\^FDINDUSTRIA MILITAR^FS" +
            "^FT350,70^A0N,28,28^FH\\^FDFABRICA ANTONIO RICAURTE^FS" +

            $"^FT10,120^A0N,28,28^FH\\^FDPRODUCTO: {contenidoLb[1]}^FS" +
            $"^FT10,160^A0N,28,28^FH\\^FDANO: {contenidoLb[2]}^FS" +
            //$"^FT10,220^A0N,56,56^FH\\^FDCAJA #: {contenidoLb[3]}{contenidoLb[4]}{reimpreso(contenidoLb[5])}^FS" +

            $"^FT10,260^A0N,28,28^FH\\^FDCANTIDAD: {contenidoLb[6]} XXX ^FS" +
            $"^FT10,300^A0N,28,28^FH\\^FDPESO NETO: {contenidoLb[7]} Kg^FS" +
            $"^FT10,340^A0N,28,28^FH\\^FDPESO BRUTO: {contenidoLb[8]} Kg^FS" +

            $"^FT400,340^A0N,28,28^FH\\^FDFECHA FABRICACION: {contenidoLb[9]}^FS" +
            $"^FT400,370^A0N,28,28^FH\\^FDFECHA VENCIMIENTO: {contenidoLb[10]}^FS" +

            "^FO550,90" +
            "^BXN,8,200,26,26" +
            $"^FDCOD{1000024}CAJA{12345678}FF{31/12/1999}FV{01/01/2999}^FS" +

            "^XZ");

        }

    }

    internal class Resultado
    {
    }
}
