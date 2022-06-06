namespace InterfazImpresora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEnviarImp = new System.Windows.Forms.Button();
            this.txtInstruccionImp = new System.Windows.Forms.TextBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnCerrarImp = new System.Windows.Forms.Button();
            this.txtRespuestaImp = new System.Windows.Forms.TextBox();
            this.btnConsultarImp = new System.Windows.Forms.Button();
            this.btnCerrarPLC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRemoto = new System.Windows.Forms.CheckBox();
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrden = new System.Windows.Forms.Button();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMotorAtras = new System.Windows.Forms.Button();
            this.btnMotorAdelante = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoImpreso = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.btnGoStop = new System.Windows.Forms.Button();
            this.btnPreguntar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Bt_OP = new System.Windows.Forms.Button();
            this.listBox_OP = new System.Windows.Forms.ListBox();
            this.BtImportarCodigos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TbPortLeib = new System.Windows.Forms.TextBox();
            this.BtConectLeib = new System.Windows.Forms.Button();
            this.BtDiscLeib = new System.Windows.Forms.Button();
            this.TbIpLeib = new System.Windows.Forms.TextBox();
            this.BtEstado = new System.Windows.Forms.Button();
            this.tbxCodigoActual = new System.Windows.Forms.TextBox();
            this.LbCodigoActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtTcpConnect = new System.Windows.Forms.Button();
            this.BtSendTCP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbTcpPort = new System.Windows.Forms.TextBox();
            this.TbTcpIp = new System.Windows.Forms.TextBox();
            this.TbTcpReceive = new System.Windows.Forms.TextBox();
            this.TbTcpSend = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BtZebraPrint = new System.Windows.Forms.Button();
            this.BtZebraMalfuncionamiento = new System.Windows.Forms.Button();
            this.TbZebraReceive = new System.Windows.Forms.TextBox();
            this.BtZebraLeerEstado = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtUpdateCode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviarImp
            // 
            this.btnEnviarImp.Location = new System.Drawing.Point(110, 233);
            this.btnEnviarImp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnviarImp.Name = "btnEnviarImp";
            this.btnEnviarImp.Size = new System.Drawing.Size(86, 31);
            this.btnEnviarImp.TabIndex = 0;
            this.btnEnviarImp.Text = "Enviar";
            this.btnEnviarImp.UseVisualStyleBackColor = true;
            this.btnEnviarImp.Click += new System.EventHandler(this.btnEnviarImp_Click);
            // 
            // txtInstruccionImp
            // 
            this.txtInstruccionImp.Location = new System.Drawing.Point(104, 186);
            this.txtInstruccionImp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInstruccionImp.Name = "txtInstruccionImp";
            this.txtInstruccionImp.Size = new System.Drawing.Size(276, 27);
            this.txtInstruccionImp.TabIndex = 3;
            this.txtInstruccionImp.TabStop = false;
            this.txtInstruccionImp.TextChanged += new System.EventHandler(this.txtInstruccionImp_TextChanged);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(18, 190);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(80, 20);
            this.lblInstruccion.TabIndex = 6;
            this.lblInstruccion.Text = "Instruccion";
            // 
            // btnCerrarImp
            // 
            this.btnCerrarImp.Location = new System.Drawing.Point(295, 233);
            this.btnCerrarImp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrarImp.Name = "btnCerrarImp";
            this.btnCerrarImp.Size = new System.Drawing.Size(86, 31);
            this.btnCerrarImp.TabIndex = 8;
            this.btnCerrarImp.Text = "Cerrar";
            this.btnCerrarImp.UseVisualStyleBackColor = true;
            this.btnCerrarImp.Click += new System.EventHandler(this.btnCerrarImp_Click);
            // 
            // txtRespuestaImp
            // 
            this.txtRespuestaImp.Location = new System.Drawing.Point(18, 273);
            this.txtRespuestaImp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRespuestaImp.Multiline = true;
            this.txtRespuestaImp.Name = "txtRespuestaImp";
            this.txtRespuestaImp.ReadOnly = true;
            this.txtRespuestaImp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaImp.Size = new System.Drawing.Size(363, 101);
            this.txtRespuestaImp.TabIndex = 9;
            this.txtRespuestaImp.TextChanged += new System.EventHandler(this.txtRespuestaImp_TextChanged);
            // 
            // btnConsultarImp
            // 
            this.btnConsultarImp.Location = new System.Drawing.Point(203, 233);
            this.btnConsultarImp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarImp.Name = "btnConsultarImp";
            this.btnConsultarImp.Size = new System.Drawing.Size(86, 31);
            this.btnConsultarImp.TabIndex = 12;
            this.btnConsultarImp.Text = "Consultar";
            this.btnConsultarImp.UseVisualStyleBackColor = true;
            this.btnConsultarImp.Click += new System.EventHandler(this.btnConsultarImp_Click);
            // 
            // btnCerrarPLC
            // 
            this.btnCerrarPLC.Location = new System.Drawing.Point(593, 48);
            this.btnCerrarPLC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrarPLC.Name = "btnCerrarPLC";
            this.btnCerrarPLC.Size = new System.Drawing.Size(86, 31);
            this.btnCerrarPLC.TabIndex = 16;
            this.btnCerrarPLC.Text = "Cerrar";
            this.btnCerrarPLC.UseVisualStyleBackColor = true;
            this.btnCerrarPLC.Click += new System.EventHandler(this.btnCerrarPLC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "LEIBINGER IP-Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "PLC";
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Location = new System.Drawing.Point(484, 165);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(86, 31);
            this.Start.TabIndex = 22;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Location = new System.Drawing.Point(484, 205);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 31);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONTROL BANDA";
            // 
            // chkRemoto
            // 
            this.chkRemoto.AutoSize = true;
            this.chkRemoto.Location = new System.Drawing.Point(682, 170);
            this.chkRemoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRemoto.Name = "chkRemoto";
            this.chkRemoto.Size = new System.Drawing.Size(84, 24);
            this.chkRemoto.TabIndex = 25;
            this.chkRemoto.Text = "Remoto";
            this.chkRemoto.UseVisualStyleBackColor = true;
            this.chkRemoto.Click += new System.EventHandler(this.chkRemoto_Click);
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.Location = new System.Drawing.Point(682, 209);
            this.chkAutomatico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(109, 24);
            this.chkAutomatico.TabIndex = 26;
            this.chkAutomatico.Text = "Automático";
            this.chkAutomatico.UseVisualStyleBackColor = true;
            this.chkAutomatico.Click += new System.EventHandler(this.chkAutomatico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "CONDICIONES DE ARRANQUE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrden.Location = new System.Drawing.Point(593, 348);
            this.btnOrden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(86, 31);
            this.btnOrden.TabIndex = 28;
            this.btnOrden.Text = "Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Location = new System.Drawing.Point(682, 242);
            this.chkManual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(80, 24);
            this.chkManual.TabIndex = 29;
            this.chkManual.Text = "Manual";
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.Click += new System.EventHandler(this.chkManual_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "CONTROL MOTOR MANUAL";
            // 
            // btnMotorAtras
            // 
            this.btnMotorAtras.BackColor = System.Drawing.Color.White;
            this.btnMotorAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotorAtras.Image = global::InterfazImpresora.Properties.Resources.izquierda;
            this.btnMotorAtras.Location = new System.Drawing.Point(93, 423);
            this.btnMotorAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMotorAtras.Name = "btnMotorAtras";
            this.btnMotorAtras.Size = new System.Drawing.Size(86, 44);
            this.btnMotorAtras.TabIndex = 31;
            this.btnMotorAtras.UseVisualStyleBackColor = false;
            this.btnMotorAtras.Click += new System.EventHandler(this.btnMotorAtras_Click);
            // 
            // btnMotorAdelante
            // 
            this.btnMotorAdelante.BackColor = System.Drawing.Color.White;
            this.btnMotorAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotorAdelante.Image = global::InterfazImpresora.Properties.Resources.derecho;
            this.btnMotorAdelante.Location = new System.Drawing.Point(214, 423);
            this.btnMotorAdelante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMotorAdelante.Name = "btnMotorAdelante";
            this.btnMotorAdelante.Size = new System.Drawing.Size(86, 44);
            this.btnMotorAdelante.TabIndex = 32;
            this.btnMotorAdelante.UseVisualStyleBackColor = false;
            this.btnMotorAdelante.Click += new System.EventHandler(this.btnMotorAdelante_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::InterfazImpresora.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(593, 489);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 55);
            this.btnReset.TabIndex = 33;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "ALARMA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 450);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 27);
            this.textBox1.TabIndex = 35;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 135);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(89, 20);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Text = "Consecutivo";
            // 
            // txtCodigoImpreso
            // 
            this.txtCodigoImpreso.Location = new System.Drawing.Point(129, 131);
            this.txtCodigoImpreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoImpreso.Name = "txtCodigoImpreso";
            this.txtCodigoImpreso.Size = new System.Drawing.Size(134, 27);
            this.txtCodigoImpreso.TabIndex = 37;
            // 
            // btnOnOff
            // 
            this.btnOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOff.Location = new System.Drawing.Point(37, 79);
            this.btnOnOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(86, 31);
            this.btnOnOff.TabIndex = 38;
            this.btnOnOff.Text = "On";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenClose.Location = new System.Drawing.Point(129, 79);
            this.btnOpenClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(86, 31);
            this.btnOpenClose.TabIndex = 39;
            this.btnOpenClose.Text = "Open";
            this.btnOpenClose.UseVisualStyleBackColor = true;
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // btnGoStop
            // 
            this.btnGoStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoStop.Location = new System.Drawing.Point(223, 79);
            this.btnGoStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGoStop.Name = "btnGoStop";
            this.btnGoStop.Size = new System.Drawing.Size(86, 31);
            this.btnGoStop.TabIndex = 40;
            this.btnGoStop.Text = "Go";
            this.btnGoStop.UseVisualStyleBackColor = true;
            this.btnGoStop.Click += new System.EventHandler(this.btnGoStop_Click);
            // 
            // btnPreguntar
            // 
            this.btnPreguntar.Location = new System.Drawing.Point(713, 489);
            this.btnPreguntar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreguntar.Name = "btnPreguntar";
            this.btnPreguntar.Size = new System.Drawing.Size(86, 31);
            this.btnPreguntar.TabIndex = 41;
            this.btnPreguntar.Text = "?";
            this.btnPreguntar.UseVisualStyleBackColor = true;
            this.btnPreguntar.Click += new System.EventHandler(this.btnPreguntar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 595);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.Bt_OP);
            this.tabPage2.Controls.Add(this.listBox_OP);
            this.tabPage2.Controls.Add(this.BtImportarCodigos);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orden de produccion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bt_OP
            // 
            this.Bt_OP.Location = new System.Drawing.Point(643, 112);
            this.Bt_OP.Name = "Bt_OP";
            this.Bt_OP.Size = new System.Drawing.Size(142, 56);
            this.Bt_OP.TabIndex = 3;
            this.Bt_OP.Text = "Importar ordenes de produccion";
            this.Bt_OP.UseVisualStyleBackColor = true;
            this.Bt_OP.Click += new System.EventHandler(this.Bt_OP_Click);
            // 
            // listBox_OP
            // 
            this.listBox_OP.ItemHeight = 20;
            this.listBox_OP.Location = new System.Drawing.Point(77, 84);
            this.listBox_OP.Name = "listBox_OP";
            this.listBox_OP.Size = new System.Drawing.Size(490, 104);
            this.listBox_OP.TabIndex = 2;
            this.listBox_OP.SelectedIndexChanged += new System.EventHandler(this.listBox_OP_SelectedIndexChanged);
            // 
            // BtImportarCodigos
            // 
            this.BtImportarCodigos.Location = new System.Drawing.Point(643, 354);
            this.BtImportarCodigos.Name = "BtImportarCodigos";
            this.BtImportarCodigos.Size = new System.Drawing.Size(142, 29);
            this.BtImportarCodigos.TabIndex = 1;
            this.BtImportarCodigos.Text = "Importar codigos";
            this.BtImportarCodigos.UseVisualStyleBackColor = true;
            this.BtImportarCodigos.Click += new System.EventHandler(this.BtImportarCodigos_Click);
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(77, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(490, 244);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtUpdateCode);
            this.tabPage1.Controls.Add(this.TbPortLeib);
            this.tabPage1.Controls.Add(this.BtConectLeib);
            this.tabPage1.Controls.Add(this.BtDiscLeib);
            this.tabPage1.Controls.Add(this.TbIpLeib);
            this.tabPage1.Controls.Add(this.BtEstado);
            this.tabPage1.Controls.Add(this.tbxCodigoActual);
            this.tabPage1.Controls.Add(this.LbCodigoActual);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCerrarPLC);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnPreguntar);
            this.tabPage1.Controls.Add(this.btnEnviarImp);
            this.tabPage1.Controls.Add(this.Start);
            this.tabPage1.Controls.Add(this.btnGoStop);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.txtInstruccionImp);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblInstruccion);
            this.tabPage1.Controls.Add(this.chkRemoto);
            this.tabPage1.Controls.Add(this.btnOpenClose);
            this.tabPage1.Controls.Add(this.chkAutomatico);
            this.tabPage1.Controls.Add(this.btnCerrarImp);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtRespuestaImp);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnOnOff);
            this.tabPage1.Controls.Add(this.btnOrden);
            this.tabPage1.Controls.Add(this.btnConsultarImp);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.chkManual);
            this.tabPage1.Controls.Add(this.txtCodigoImpreso);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnMotorAtras);
            this.tabPage1.Controls.Add(this.btnMotorAdelante);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TbPortLeib
            // 
            this.TbPortLeib.Location = new System.Drawing.Point(221, 29);
            this.TbPortLeib.Name = "TbPortLeib";
            this.TbPortLeib.Size = new System.Drawing.Size(53, 27);
            this.TbPortLeib.TabIndex = 50;
            this.TbPortLeib.Text = "9100";
            // 
            // BtConectLeib
            // 
            this.BtConectLeib.Location = new System.Drawing.Point(280, 27);
            this.BtConectLeib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtConectLeib.Name = "BtConectLeib";
            this.BtConectLeib.Size = new System.Drawing.Size(86, 31);
            this.BtConectLeib.TabIndex = 48;
            this.BtConectLeib.Text = "Conectar";
            this.BtConectLeib.UseVisualStyleBackColor = true;
            this.BtConectLeib.Click += new System.EventHandler(this.BtConectLeib_Click);
            // 
            // BtDiscLeib
            // 
            this.BtDiscLeib.Location = new System.Drawing.Point(372, 27);
            this.BtDiscLeib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtDiscLeib.Name = "BtDiscLeib";
            this.BtDiscLeib.Size = new System.Drawing.Size(99, 31);
            this.BtDiscLeib.TabIndex = 49;
            this.BtDiscLeib.Text = "Desconectar";
            this.BtDiscLeib.UseVisualStyleBackColor = true;
            this.BtDiscLeib.Click += new System.EventHandler(this.BtDiscLeib_Click);
            // 
            // TbIpLeib
            // 
            this.TbIpLeib.Location = new System.Drawing.Point(134, 29);
            this.TbIpLeib.Name = "TbIpLeib";
            this.TbIpLeib.Size = new System.Drawing.Size(81, 27);
            this.TbIpLeib.TabIndex = 47;
            this.TbIpLeib.Text = "10.253.1.5";
            // 
            // BtEstado
            // 
            this.BtEstado.Location = new System.Drawing.Point(315, 79);
            this.BtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtEstado.Name = "BtEstado";
            this.BtEstado.Size = new System.Drawing.Size(86, 31);
            this.BtEstado.TabIndex = 46;
            this.BtEstado.Text = "Estado";
            this.BtEstado.UseVisualStyleBackColor = true;
            this.BtEstado.Click += new System.EventHandler(this.BtEstado_Click);
            // 
            // tbxCodigoActual
            // 
            this.tbxCodigoActual.Location = new System.Drawing.Point(237, 501);
            this.tbxCodigoActual.Name = "tbxCodigoActual";
            this.tbxCodigoActual.Size = new System.Drawing.Size(125, 27);
            this.tbxCodigoActual.TabIndex = 45;
            // 
            // LbCodigoActual
            // 
            this.LbCodigoActual.AutoSize = true;
            this.LbCodigoActual.Location = new System.Drawing.Point(166, 506);
            this.LbCodigoActual.Name = "LbCodigoActual";
            this.LbCodigoActual.Size = new System.Drawing.Size(37, 20);
            this.LbCodigoActual.TabIndex = 44;
            this.LbCodigoActual.Text = " null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ultima impresion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 42;
            this.button1.Text = "ConexionDb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnConexionDb);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtTcpConnect);
            this.tabPage3.Controls.Add(this.BtSendTCP);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.TbTcpPort);
            this.tabPage3.Controls.Add(this.TbTcpIp);
            this.tabPage3.Controls.Add(this.TbTcpReceive);
            this.tabPage3.Controls.Add(this.TbTcpSend);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(871, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tcp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtTcpConnect
            // 
            this.BtTcpConnect.Location = new System.Drawing.Point(81, 124);
            this.BtTcpConnect.Name = "BtTcpConnect";
            this.BtTcpConnect.Size = new System.Drawing.Size(94, 29);
            this.BtTcpConnect.TabIndex = 7;
            this.BtTcpConnect.Text = "Conectar";
            this.BtTcpConnect.UseVisualStyleBackColor = true;
            this.BtTcpConnect.Click += new System.EventHandler(this.BtTcpConnect_Click);
            // 
            // BtSendTCP
            // 
            this.BtSendTCP.Location = new System.Drawing.Point(81, 298);
            this.BtSendTCP.Name = "BtSendTCP";
            this.BtSendTCP.Size = new System.Drawing.Size(94, 29);
            this.BtSendTCP.TabIndex = 6;
            this.BtSendTCP.Text = "Send";
            this.BtSendTCP.UseVisualStyleBackColor = true;
            this.BtSendTCP.Click += new System.EventHandler(this.BtSendTCP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "IP";
            // 
            // TbTcpPort
            // 
            this.TbTcpPort.Location = new System.Drawing.Point(81, 225);
            this.TbTcpPort.Name = "TbTcpPort";
            this.TbTcpPort.Size = new System.Drawing.Size(125, 27);
            this.TbTcpPort.TabIndex = 3;
            this.TbTcpPort.Text = "9100";
            // 
            // TbTcpIp
            // 
            this.TbTcpIp.Location = new System.Drawing.Point(81, 192);
            this.TbTcpIp.Name = "TbTcpIp";
            this.TbTcpIp.Size = new System.Drawing.Size(125, 27);
            this.TbTcpIp.TabIndex = 2;
            this.TbTcpIp.Text = "10.52.0.210";
            this.TbTcpIp.TextChanged += new System.EventHandler(this.TbTcpIp_TextChanged);
            // 
            // TbTcpReceive
            // 
            this.TbTcpReceive.Enabled = false;
            this.TbTcpReceive.Location = new System.Drawing.Point(263, 271);
            this.TbTcpReceive.Multiline = true;
            this.TbTcpReceive.Name = "TbTcpReceive";
            this.TbTcpReceive.Size = new System.Drawing.Size(605, 288);
            this.TbTcpReceive.TabIndex = 1;
            // 
            // TbTcpSend
            // 
            this.TbTcpSend.Location = new System.Drawing.Point(263, 3);
            this.TbTcpSend.Multiline = true;
            this.TbTcpSend.Name = "TbTcpSend";
            this.TbTcpSend.Size = new System.Drawing.Size(605, 262);
            this.TbTcpSend.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.BtZebraPrint);
            this.tabPage4.Controls.Add(this.BtZebraMalfuncionamiento);
            this.tabPage4.Controls.Add(this.TbZebraReceive);
            this.tabPage4.Controls.Add(this.BtZebraLeerEstado);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(871, 562);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Zebra";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // BtZebraPrint
            // 
            this.BtZebraPrint.Location = new System.Drawing.Point(489, 353);
            this.BtZebraPrint.Name = "BtZebraPrint";
            this.BtZebraPrint.Size = new System.Drawing.Size(94, 29);
            this.BtZebraPrint.TabIndex = 7;
            this.BtZebraPrint.Text = "Imprimir";
            this.BtZebraPrint.UseVisualStyleBackColor = true;
            this.BtZebraPrint.Click += new System.EventHandler(this.BtZebraPrint_Click);
            // 
            // BtZebraMalfuncionamiento
            // 
            this.BtZebraMalfuncionamiento.Location = new System.Drawing.Point(473, 251);
            this.BtZebraMalfuncionamiento.Name = "BtZebraMalfuncionamiento";
            this.BtZebraMalfuncionamiento.Size = new System.Drawing.Size(129, 73);
            this.BtZebraMalfuncionamiento.TabIndex = 6;
            this.BtZebraMalfuncionamiento.Text = "Reportar Mal Funcionamiento";
            this.BtZebraMalfuncionamiento.UseVisualStyleBackColor = true;
            this.BtZebraMalfuncionamiento.Click += new System.EventHandler(this.BtZebraMalfuncionamiento_Click);
            // 
            // TbZebraReceive
            // 
            this.TbZebraReceive.Location = new System.Drawing.Point(124, 80);
            this.TbZebraReceive.Multiline = true;
            this.TbZebraReceive.Name = "TbZebraReceive";
            this.TbZebraReceive.Size = new System.Drawing.Size(308, 313);
            this.TbZebraReceive.TabIndex = 1;
            // 
            // BtZebraLeerEstado
            // 
            this.BtZebraLeerEstado.Location = new System.Drawing.Point(489, 192);
            this.BtZebraLeerEstado.Name = "BtZebraLeerEstado";
            this.BtZebraLeerEstado.Size = new System.Drawing.Size(94, 29);
            this.BtZebraLeerEstado.TabIndex = 0;
            this.BtZebraLeerEstado.Text = "LeerEstado";
            this.BtZebraLeerEstado.UseVisualStyleBackColor = true;
            this.BtZebraLeerEstado.Click += new System.EventHandler(this.BtZebraLeerEstado_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtUpdateCode
            // 
            this.BtUpdateCode.Location = new System.Drawing.Point(276, 127);
            this.BtUpdateCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtUpdateCode.Name = "BtUpdateCode";
            this.BtUpdateCode.Size = new System.Drawing.Size(125, 31);
            this.BtUpdateCode.TabIndex = 51;
            this.BtUpdateCode.Text = "Enviar código";
            this.BtUpdateCode.UseVisualStyleBackColor = true;
            this.BtUpdateCode.Click += new System.EventHandler(this.BtUpdateCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 619);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEnviarImp;
        private TextBox txtInstruccionImp;
        private Label lblInstruccion;
        private Button btnCerrarImp;
        private TextBox txtRespuestaImp;
        private Button btnConsultarImp;
        private Button btnCerrarPLC;
        private Label label2;
        private Label label3;
        private Button Start;
        private Button btnStop;
        private Label label4;
        private CheckBox chkRemoto;
        private CheckBox chkAutomatico;
        private Label label5;
        private Button btnOrden;
        private CheckBox chkManual;
        private Label label6;
        private Button btnMotorAtras;
        private Button btnMotorAdelante;
        private Button btnReset;
        private Label label7;
        private TextBox textBox1;
        private Label lblCodigo;
        private TextBox txtCodigoImpreso;
        private Button btnOnOff;
        private Button btnOpenClose;
        private Button btnGoStop;
        private Button btnPreguntar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Button BtImportarCodigos;
        private Button Bt_OP;
        private ListBox listBox_OP;
        private Label LbCodigoActual;
        private Label label1;
        private Button button1;
        private TextBox tbxCodigoActual;
        private Button button2;
        private TabPage tabPage3;
        private Button BtSendTCP;
        private Label label9;
        private Label label8;
        private TextBox TbTcpPort;
        private TextBox TbTcpIp;
        private TextBox TbTcpReceive;
        private TextBox TbTcpSend;
        private Button BtTcpConnect;
        private TabPage tabPage4;
        private TextBox TbZebraReceive;
        private Button BtZebraLeerEstado;
        private Button BtZebraMalfuncionamiento;
        private Button BtZebraPrint;
        private System.Windows.Forms.Timer timer1;
        private Button BtEstado;
        private TextBox TbIpLeib;
        private Button BtConectLeib;
        private Button BtDiscLeib;
        private TextBox TbPortLeib;
        private Button BtUpdateCode;
    }
}