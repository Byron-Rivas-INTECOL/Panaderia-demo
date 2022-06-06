using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net; //Sharp7 funciono

namespace InterfazImpresora.Entidad
{
    class Comun
    {
    }

    class Resultado<T> //where T : struct//Byron_generic_class
    {
        public T Data { get; set; }
        public string error_msg { get; set; }
        public bool error { get; set; }
    }

    class Data<T>
    {
        T data{ get; set; }
    }

    class Periferco
    {
        public int Tipo_periferico { get; set; }//[S7-PLC,Leibinger,Zebra]
        public bool En_error {get; set; }
        public string Error {get; set; }
        public bool Conectado {get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public CpuType Cpu { get; set; }
        public int Rack { get; set; }
        public int Slot { get; set; }

    }


}
