using System.Text;  // Para Encoding
using System.Net.Sockets;    // Para NetworkStream
using S7.Net;
using Sharp7;
using InterfazImpresora.Datos;
using InterfazImpresora.Entidad;


namespace InterfazImpresora
{
    public partial class Form1 : Form
    {
        
        Plc plclab;
        TcpClient impresora;
        public static Stream stream;
        int Empezar = 16;
        public static Int64 lote;
        List<Int64> ListaCodigos;
        public static Int32 i_list;


        public Form1()
        {
            


            //Thread hiloCodigos = new Thread(new ThreadStart(GenerarCodigo));
            //hiloCodigos.Start();

            
            //hiloEstados.Join();
            InitializeComponent();


            if (!chkRemoto.Checked)
            {
                Start.Enabled = false;
                btnStop.Enabled = false;
            }

            if (!chkAutomatico.Checked)
            {
                btnOrden.Enabled = false;
            }
            if (!chkManual.Checked)
            {
                btnMotorAtras.Enabled = false;
                btnMotorAdelante.Enabled = false;
            }

            //plclab.Write("DB5.DBX4.2", false);

            i_list = 0;

        }

        private void btnEnviarImp_Click(object sender, EventArgs e)
        {
            //  ^0=MR1.MUL.1612345623.//primera posicion buffer
            // ^0=ETMUL1612345623.//editar impresora sin contador 
            Byte[] data = Encoding.ASCII.GetBytes("^0"+txtInstruccionImp.Text+ "\r\n");
            //data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);
        }

        private void btnConsultarImp_Click(object sender, EventArgs e)
        {
            Byte[] data = Encoding.ASCII.GetBytes("^0" + txtInstruccionImp.Text + "\r\n");
            //data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);

            data = new byte[256];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);
            txtRespuestaImp.Text = responseData;
        }

        private void btnCerrarImp_Click(object sender, EventArgs e)
        {
            stream.Close();
            impresora.Close();
        }


        private void BtEstado_Click(object sender, EventArgs e)
        {
            Byte[] data = Encoding.ASCII.GetBytes("^0" + "?RS" + "\r\n");
            //data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);

            data = new byte[256];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);
            txtRespuestaImp.Text = responseData;
        }



        private void btnCerrarPLC_Click(object sender, EventArgs e)
        {
            // poner para cerrar la conexion
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (plclab.IsConnected)
            {
                bool uscita = (bool)plclab.Read("DB5.DBX4.0");
                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.0", true);//Control de comando Start
                    Thread.Sleep(1000);
                    plclab.Write("DB5.DBX4.0", false);
                }

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (plclab.IsConnected)
            {
                bool uscita = (bool)plclab.Read("DB5.DBX4.1");
                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.1", true);  //control de comando Stop
                    Thread.Sleep(1000);
                    plclab.Write("DB5.DBX4.1", false);
                }

            }
        }

        private void chkRemoto_Click(object sender, EventArgs e)
        {
            if (chkRemoto.Checked)
            {
                Start.Enabled = true;
                btnStop.Enabled = true;
                bool uscita = (bool)plclab.Read("DB5.DBX4.3"); // control estado remoto / local

                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.3", true);
                }

            }
            else
            {
                Start.Enabled = false;
                btnStop.Enabled = false;
                plclab.Write("DB5.DBX4.3", false);
            }
        }


        private void chkAutomatico_Click(object sender, EventArgs e)
        {
            if (chkAutomatico.Checked)
            {
                chkManual.Enabled = false;
                btnOrden.Enabled = true;
                bool uscita = (bool)plclab.Read("DB5.DBX4.4"); // control estado remoto / local

                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.4", true);
                }

            }
            else
            {
                Start.Enabled = false;
                btnStop.Enabled = false;
                btnOrden.Enabled = false;
                plclab.Write("DB5.DBX4.4", false);
                chkManual.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX4.2"); // control estado remoto / local

            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX4.2", true);
            }
        }

        private void chkManual_Click(object sender, EventArgs e)
        {
            if (chkManual.Checked)
            {
                //Start.Enabled = true;
                chkAutomatico.Enabled = false;
                btnOrden.Enabled = false;
                plclab.Write("DB5.DBX4.2", false);
                btnMotorAtras.Enabled= true;
                btnMotorAdelante.Enabled= true;
                bool uscita = (bool)plclab.Read("DB5.DBX4.5"); // control estado  manual 

                if (uscita.Equals(false))
                {
                    plclab.Write("DB5.DBX4.5", true);
                }               
            }
            else
            {
                plclab.Write("DB5.DBX4.5", false);    
                chkAutomatico.Enabled = true;
                btnMotorAtras.Enabled = false;
                btnMotorAdelante.Enabled = false;
            }
        }

        private void btnMotorAtras_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX5.3");
            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX5.3", true);//Control de comando Motor Atras
                Thread.Sleep(3000);
                plclab.Write("DB5.DBX5.3", false);
            }
        }

        private void btnMotorAdelante_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX5.2");
            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX5.2", true);//Control de comando Motor Adelante
                Thread.Sleep(3000);
                plclab.Write("DB5.DBX5.2", false);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            bool uscita = (bool)plclab.Read("DB5.DBX4.7");
            if (uscita.Equals(false))
            {
                plclab.Write("DB5.DBX4.7", true);//Control de comando Motor Adelante
                Thread.Sleep(1000);
                plclab.Write("DB5.DBX4.7", false);
            }
            textBox1.Text = "";

        }
        private void GenerarCodigo ()
        {
            while (true)
            {
                String Taller = "Mul";
                int CodigoProducto = 16;
                String codigo = String.Empty;
                codigo = Taller + CodigoProducto.ToString();// + String.Format("{0:00000000}", Empezar);
                txtCodigoImpreso.Text = codigo;

                /**/
                Byte[] data = Encoding.ASCII.GetBytes("^0=ET"+codigo+".");
                data[data.Length - 1] = 13;
                stream.Write(data, 0, data.Length);

        
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            string estatus = btnOnOff.Text;
            if(estatus == "On")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!PO.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOnOff.Text = "Off";
            }else if(estatus == "Off")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!PF.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOnOff.Text = "On";
            }
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            string estatus = btnOpenClose.Text;
            if (estatus == "Open")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!NO.");//"^0!NO.");//Byron_se_desea generar error asd sobra
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOpenClose.Text = "Close";
            }
            else if (estatus == "Close")
            {
                Byte[] codigoImpresora = Encoding.ASCII.GetBytes("^0!NC.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnOpenClose.Text = "Open";
            }
        }

        private void btnGoStop_Click(object sender, EventArgs e)
        {
            Byte[] codigoImpresora;
            string estatus = btnGoStop.Text;
            if (estatus == "Go")
            {
                codigoImpresora = Encoding.ASCII.GetBytes("^0!GO.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnGoStop.Text = "Stop";
            }
            else if (estatus == "Stop")
            {
                codigoImpresora = Encoding.ASCII.GetBytes("^0!ST.");
                codigoImpresora[codigoImpresora.Length - 1] = 13;
                stream.Write(codigoImpresora, 0, codigoImpresora.Length);
                btnGoStop.Text = "Go";
            }

            Escribir_Estados_Impresora();

            codigoImpresora = Encoding.ASCII.GetBytes("^0=ETMul16.");
            codigoImpresora[codigoImpresora.Length - 1] = 13;
            stream.Write(codigoImpresora, 0, codigoImpresora.Length);
        }

        private void btnPreguntar_Click(object sender, EventArgs e)
        {
            //PreguntarEstados();
           

        }

        public void Escribir_Estados_Impresora()
        {
            Byte[] data = Encoding.ASCII.GetBytes("^0?RS.");
            data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);

            data = new byte[256];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);
            string[] estadoSensor = responseData.Split();

            try
            {
                if (estadoSensor[1] == "6")
                {
                    plclab.Write("DB5.DBX5.0", true);
              
                }
                else
                {
                    plclab.Write("DB5.DBX5.0", false);
                }

            }
            catch (Exception)
            {

            }
        }

        public void EscribirSensorImpresora()
        {
            while (true)
            {
                try
                {
                    Byte[] data = Encoding.ASCII.GetBytes("^0?EX.");
                    data[data.Length - 1] = 13;
                    stream.Write(data, 0, data.Length);

                    data = new byte[256];
                    String responseData = String.Empty;
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.ASCII.GetString(data, 0, bytes);
                    string[] estadoSensor = responseData.Split();

                    if (estadoSensor[4] == "1")
                    {
                        plclab.Write("DB5.DBX4.6", true);

                        Thread.Sleep(300);
                        SiguienteCodigo();
                        EscribirCodigoImpresoPlc();


                    }
                    else
                    {
                        plclab.Write("DB5.DBX4.6", false);
                    }
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }


        public string ConsultarCodigoImpresora()
        {
            Byte[] data = Encoding.ASCII.GetBytes("^0?ET\r\n");
            //data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);            

            data = new byte[256];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);

            data = Encoding.ASCII.GetBytes("^0?CC\r\n");
            //data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);

            data = new byte[256];
            bytes = stream.Read(data, 0, data.Length);
            responseData = responseData + Encoding.ASCII.GetString(data, 0, bytes);

            /* "^0=ETMul16\r^0=CC182\t0\t\r"  */

            string[] aux = responseData.Split('T');
            aux = aux[1].Split('\r');
            responseData = aux[0];
            aux = aux[1].Split('C');
            aux = aux[2].Split('\t');
            int aux2 = Convert.ToInt32(aux[0]);
            responseData = responseData + String.Format("{0:00000000}", aux2);
            //txtRespuestaImp.Text = responseData;
            //tecto de prueba
            return responseData;
        }

        
        public void EscribirCodigoImpresoPlc()
        {
            try
            {

                string mensaje = ConsultarCodigoImpresora();
                plclab.Write(DataType.DataBlock, 5, 264, mensaje);
                var lectura = (plclab.Read(DataType.DataBlock, 5, 8, varType: VarType.String, 13));

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void PreguntarEstados()
        {
            bool aux;
            /**/
            aux = (bool)plclab.Read("DB7.DBX4.0");
            if (aux == true)
            {
                textBox1.Text = textBox1.Text + "Paro de emergencia activo";
            }
            else
            {
                textBox1.Text = textBox1.Text + "";
            }
            /**/
            aux = (bool)plclab.Read("DB7.DBX4.1");
            if (aux == true)
            {
                textBox1.Text = textBox1.Text + "Fallo Variador";
            }
            else
            {
                textBox1.Text = textBox1.Text + "";
            }
            /**/
            aux = (bool)plclab.Read("DB7.DBX4.2");
            if (aux == true)
            {
                textBox1.Text = textBox1.Text + "Fallo de Impresora";
            }
            else
            {
                textBox1.Text = textBox1.Text + "";
            }
            /**/
            aux = (bool)plclab.Read("DB7.DBX4.3");
            if (aux == true)
            {
                textBox1.Text = textBox1.Text + "Camara offline";
            }
            else
            {
                textBox1.Text = textBox1.Text + "";
            }
            /* aux = obtenerParametro(modo auto ?)
             plc.read(db7.dbx+aux)
             */
            aux = ((bool)plclab.Read("DB7.DBX"+EParametro.Plc_Modo_Auto));
            //aux = (bool)plclab.Read("DB7.DBX4.4");
            if (aux == true)
            {
                textBox1.Text = textBox1.Text + "Codigo sin registro";
            }
            else
            {
                textBox1.Text = textBox1.Text + "";
            }
            /**/
            aux = (bool)plclab.Read("DB7.DBX4.5");
            if (aux == true)
            {
                textBox1.Text = textBox1.Text + "Codigo repetido";
            }
            else
            {
                textBox1.Text = textBox1.Text + "";
            }
            /**/
            aux = (bool)plclab.Read("DB7.DBX4.6");
            if (aux == true)
            {
                textBox1.Text = textBox1.Text + "Lectura erronea";
            }
            else
            {
                textBox1.Text = textBox1.Text + "";
            }
            /**/


        }


        private void btnConexionDb(object sender, EventArgs e)
        {
            //InterfazImpresora.Datos.ConexionBd.DbConexion();
            //ObtenerDb.ObtenerParametro("IpPlc");
            string Ip = EParametro.IpPlc;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                InterfazImpresora.Datos.ConexionBd.ArranqueDb();
                string ipPLC= EParametro.IpPlc;
                //string ipImpr =EParametro.IpImpresora;
                //int PuertoImp= int.Parse( EParametro.PuertoImp);
                //plclab = new Plc(CpuType.S71200,ipPLC, 0, 1);
                plclab = new Plc(CpuType.S71500,"10.253.1.6", 0, 1);

                plclab.Open();

                Thread hiloEstados = new Thread(new ThreadStart(EscribirSensorImpresora));
                hiloEstados.Start();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion" + ex.Message);
            }

        }

        private void BtImportarCodigos_Click(object sender, EventArgs e)
        {
            lote = Convert.ToInt64(listBox_OP.SelectedItem);
            ListaCodigos = Datos.ObtenerDb.ImportarCodigos(lote);
            listBox1.DataSource = ListaCodigos;
        }

        private void Bt_OP_Click(object sender, EventArgs e)
        {
            List<Int64> ListaOP = Datos.ObtenerDb.ImportarOP();
            listBox_OP.DataSource = ListaOP;
        }

        private void listBox_OP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lote = Convert.ToInt64(listBox_OP.SelectedItem);
        }

        private void SiguienteCodigo()
        {
            ////  ^0=MR1.MUL.1612345623.//primera posicion buffer
            //// ^0=ETMUL1612345623.//editar impresora sin contador
            string CodigoUnitario = txtCodigoImpreso.Text;
            //string CodigoActual = "PRU" + ListaCodigos[i_list].ToString();
            string CodigoActual = "PRU" + CodigoUnitario;
            string CodigoASCCI = "^0=ET" + CodigoActual + ".";
            Byte[] data = Encoding.ASCII.GetBytes(CodigoASCCI);

            //Thread.Sleep(100);
            data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);
            //Datos.ObtenerDb.ActualizarEstado(ListaCodigos[i_list].ToString());
            plclab.Write(DataType.DataBlock, 5, 264, CodigoActual);
            //LbCodigoActual.Text = CodigoActual;
            //tbxCodigoActual.Text = CodigoActual;
            ListaCodigos = Datos.ObtenerDb.ImportarCodigos(lote);
            listBox1.DataSource = ListaCodigos;

            if (ListaCodigos.Count()<=0)
            {
                MessageBox.Show("Finalizó impresión orden de produccion id "+lote);
            }
            i_list++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string CodigoASCCI = "^0=PR2	66000.";
            //Byte[] data = Encoding.ASCII.GetBytes(CodigoASCCI);

            ////Thread.Sleep(100);
            //data[data.Length - 1] = 13;
            //stream.Write(data, 0, data.Length);
            
        }

        public static void SetImpresora(int id_tipo_producto)
        {
            int retardo_um = 0;
            if (id_tipo_producto==13)
            {
                retardo_um = 12000;
            }
            else
            {
                retardo_um = 8000;

            }



            string CodigoASCCI = "^0=PR1	"+ retardo_um + ".";
            Byte[] data = Encoding.ASCII.GetBytes(CodigoASCCI);
            //Thread.Sleep(100);
            data[data.Length - 1] = 13;
            stream.Write(data, 0, data.Length);

        }

        private void BtTcpConnect_Click(object sender, EventArgs e)
        {
            Tcp.Connect(TbTcpIp.Text, Convert.ToInt32(TbTcpPort.Text));
        }

        private void TbTcpIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtSendTCP_Click(object sender, EventArgs e)
        {
            TbTcpReceive.Text=Tcp.SendRecieve(TbTcpSend.Text);

        }

        private void txtRespuestaImp_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtZebraLeerEstado_Click(object sender, EventArgs e)
        {
            TbZebraReceive.Text = Zebra.LeerEstado();
        }

        private void BtZebraMalfuncionamiento_Click(object sender, EventArgs e)
        {
            //Reportar en la base de datos bit mal funcionamientoo 

            System.Diagnostics.Process.Start("C:/Program Files/Google/Chrome/Application/chrome.exe", @"https://www.zebra.com/content/dam/zebra_new_ia/en-us/manuals/printers/industrial/zt400/zt400-ug-en.pdf#Load%20the%20Media");
        }

        private void BtZebraPrint_Click(object sender, EventArgs e)
        {
            Zebra.Print();
        }

        private void txtInstruccionImp_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void BtConectLeib_Click(object sender, EventArgs e)
        {
            string ipImpr = TbIpLeib.Text;
            int PuertoImp = int.Parse(TbPortLeib.Text);


            impresora = new TcpClient(ipImpr, PuertoImp);
            stream = impresora.GetStream();
        }

        private void BtDiscLeib_Click(object sender, EventArgs e)
        {
            impresora.Close();
            //impresora.Dispose();
        }

        private void BtUpdateCode_Click(object sender, EventArgs e)
        {
            SiguienteCodigo();
        }
    }
  
}

//Mul1600000025

