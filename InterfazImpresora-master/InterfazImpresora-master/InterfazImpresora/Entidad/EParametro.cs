using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazImpresora.Datos;

namespace InterfazImpresora.Entidad
{
    class EParametro
    {
        public static string IpPlc = ObtenerDb.ObtenerParametro("IpPlc");
        public static string IpImpresora = ObtenerDb.ObtenerParametro("IpImpresora");
        public static string Plc_Pistilos = ObtenerDb.ObtenerParametro("Plc_Pistilos");
        public static string Plc_Start_Remoto =  (ObtenerDb.ObtenerParametro("Plc_Start_Remoto"));
        public static string Plc_Stop_Remoto =  (ObtenerDb.ObtenerParametro("Plc_Stop_Remoto"));
        public static string Plc_Confir_Orden_Prod =  (ObtenerDb.ObtenerParametro("Plc_Confir_Orden_Prod"));
        public static string Plc_Remoto_Local	=  (ObtenerDb.ObtenerParametro("Plc_Remoto-Local"));
        public static string Plc_Modo_Auto =  (ObtenerDb.ObtenerParametro("Plc_Modo_Auto"));
        public static string Plc_Modo_Manual =  (ObtenerDb.ObtenerParametro("Plc_Modo_Manual"));
        public static string Plc_Confir_Cod_Impreso =  (ObtenerDb.ObtenerParametro("Plc_Confir_Cod_Impreso"));
        public static string Plc_Reset_Alarmas =  (ObtenerDb.ObtenerParametro("Plc_Reset_Alarmas"));
        public static string Plc_Impresora_Ok =  (ObtenerDb.ObtenerParametro("Plc_Impresora_Ok"));
        public static string Plc_Motor_Manual =  (ObtenerDb.ObtenerParametro("Plc_Motor_Manual"));
        public static string Plc_Jog_Motor_Adelante =  (ObtenerDb.ObtenerParametro("Plc_Jog_Motor_Adelante"));
        public static string Plc_Jog_Motor_Atras =  (ObtenerDb.ObtenerParametro("Plc_Jog_Motor_Atras"));
        public static string Plc_Disparo_Cam =  (ObtenerDb.ObtenerParametro("Plc_Disparo_Cam"));
        public static string Plc_Codigo_Impreso = ObtenerDb.ObtenerParametro("Plc_Codigo_Impreso");
        public static string Plc_Referencia_Empaque = (ObtenerDb.ObtenerParametro("Plc_Referencia_Empaque"));
        public static string Plc_Codigos_Imp	=	ObtenerDb.ObtenerParametro("Plc_Codigos_Imp"); //en plc es un Array[0..12]
        public static string PuertoImp =  (ObtenerDb.ObtenerParametro("PuertoImp"));
        public static string ZebraIp =  (ObtenerDb.ObtenerParametro("ZebraIP"));
        public static string ZebraPort =  (ObtenerDb.ObtenerParametro("ZebraPort"));
        public static string Leib1Ip =  "10.52.0.25";//(ObtenerDb.ObtenerParametro("ZebraIP"));
        public static string Leib1Port = "1900";//(ObtenerDb.ObtenerParametro("ZebraPort"));
    }
    class E_imprimir_etiqueta {
        public static List<string> Variables=InterfazImpresora.Datos.ObtenerDb.LeerCajas();
        public static string Contenido = LimpiarContenido(Variables);

        private static string LimpiarContenido(List<String> variables)
        {
            string ContenidoLimpio=variables[variables.Count-1];

            for (int i = 1; i < variables.Count; i++)
            {
                

                if (i==5)//condicional reimpreso
                {
                    ContenidoLimpio = ContenidoLimpio.Replace("{Variables[5]}", reimpreso(variables[i]));
                }
                else if (i==9 || i ==10)
                {
                    string[] aux_fecha = variables[i].ToString().Split(' ');

                    //aux_fecha=aux_fecha.Split(' ',1);
                    ContenidoLimpio = ContenidoLimpio.Replace("{Variables[" + i + "]}", aux_fecha[0]);
                }
                else ContenidoLimpio = ContenidoLimpio.Replace("{Variables[" + i + "]}", variables[i]);

            }
            return ContenidoLimpio;
        }

            
//("^XA" +
//"^CI28" +

//"^FO20,10^XGE:LOGO.GRF^FS" +

//"^FT400,40^A0N,28,28^FH\\^FDINDUSTRIA MILITAR^FS" +
//"^FT350,70^A0N,28,28^FH\\^FDFABRICA ANTONIO RICAURTE^FS" +

//$"^FT10,120^A0N,28,28^FH\\^FDPRODUCTO: {Variables[1]}^FS" +
//$"^FT10,160^A0N,28,28^FH\\^FDANO: {Variables[2]}^FS" +
//$"^FT10,220^A0N,56,56^FH\\^FDCAJA #: {Variables[3]}{Variables[4]}{reimpreso(Variables[5])}^FS" +

//$"^FT10,260^A0N,28,28^FH\\^FDCANTIDAD: {Variables[6]} XXX ^FS" +
//$"^FT10,300^A0N,28,28^FH\\^FDPESO NETO: {Variables[7]} Kg^FS" +
//$"^FT10,340^A0N,28,28^FH\\^FDPESO BRUTO: {Variables[8]} Kg^FS" +

//$"^FT400,340^A0N,28,28^FH\\^FDFECHA FABRICACION: {Variables[9]}^FS" +
//$"^FT400,370^A0N,28,28^FH\\^FDFECHA VENCIMIENTO: {Variables[10]}^FS" +

//"^FO550,90" +
//"^BXN,8,200,26,26" +
//$"^FDCOD{1000024}CAJA{12345678}FF{31 / 12 / 1999}FV{01 / 01 / 2999}^FS" +

//"^XZ");
        private static string reimpreso(string r)
        {
            if (r == "True") return "R";
            else return "";
        }
    }
}
