namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.streamPicture = new System.Windows.Forms.PictureBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.portC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopStream = new System.Windows.Forms.Button();
            this.startStream = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.clearText = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pbObstaculos = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.pbTemperatura = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.pbSonido = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.pbLuz = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.pbFuego = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.pbPropano = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.pbMetano = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.pbHumo = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnlazarJoystick = new System.Windows.Forms.Button();
            this.btnResetProgresBars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.streamPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // joystickTimer
            // 
            this.joystickTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // streamPicture
            // 
            this.streamPicture.Location = new System.Drawing.Point(6, 19);
            this.streamPicture.Name = "streamPicture";
            this.streamPicture.Size = new System.Drawing.Size(640, 480);
            this.streamPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.streamPicture.TabIndex = 0;
            this.streamPicture.TabStop = false;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(42, 42);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(48, 20);
            this.tb1.TabIndex = 2;
            this.tb1.Text = "192";
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dirección IP de Cámara de Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección IP del Vehículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IPv4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "IPv4";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(96, 42);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(48, 20);
            this.tb2.TabIndex = 2;
            this.tb2.Text = "168";
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(150, 42);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(48, 20);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "1";
            this.tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(204, 42);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(48, 20);
            this.tb4.TabIndex = 2;
            this.tb4.Text = "39";
            this.tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "192";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "168";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(204, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "177";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portC
            // 
            this.portC.Location = new System.Drawing.Point(265, 42);
            this.portC.Name = "portC";
            this.portC.Size = new System.Drawing.Size(48, 20);
            this.portC.TabIndex = 2;
            this.portC.Text = "4747";
            this.portC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopStream);
            this.groupBox1.Controls.Add(this.startStream);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.tb4);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.portC);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunicación";
            // 
            // stopStream
            // 
            this.stopStream.Location = new System.Drawing.Point(184, 122);
            this.stopStream.Name = "stopStream";
            this.stopStream.Size = new System.Drawing.Size(129, 32);
            this.stopStream.TabIndex = 4;
            this.stopStream.Text = "Detener Comunicación";
            this.stopStream.UseVisualStyleBackColor = true;
            this.stopStream.Click += new System.EventHandler(this.stopStream_Click);
            // 
            // startStream
            // 
            this.startStream.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startStream.Location = new System.Drawing.Point(42, 122);
            this.startStream.Name = "startStream";
            this.startStream.Size = new System.Drawing.Size(122, 32);
            this.startStream.TabIndex = 4;
            this.startStream.Text = "Iniciar Comunicación";
            this.startStream.UseVisualStyleBackColor = true;
            this.startStream.Click += new System.EventHandler(this.startStream_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Puerto";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(265, 87);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(48, 20);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "8888";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.output);
            this.groupBox2.Controls.Add(this.clearText);
            this.groupBox2.Location = new System.Drawing.Point(346, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 177);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Acciones";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(6, 17);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(173, 125);
            this.output.TabIndex = 7;
            this.output.Text = "";
            // 
            // clearText
            // 
            this.clearText.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearText.Location = new System.Drawing.Point(6, 148);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(173, 23);
            this.clearText.TabIndex = 4;
            this.clearText.Text = "Limpiar Ventana";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.streamPicture);
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 507);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Streaming";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.pbObstaculos);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.pbTemperatura);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pbSonido);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.pbLuz);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.pbFuego);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.pbPropano);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.pbMetano);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.pbHumo);
            this.groupBox4.Location = new System.Drawing.Point(676, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 689);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sensores";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Obstáculos";
            // 
            // pbObstaculos
            // 
            this.pbObstaculos.Location = new System.Drawing.Point(6, 384);
            this.pbObstaculos.Name = "pbObstaculos";
            this.pbObstaculos.Size = new System.Drawing.Size(308, 23);
            this.pbObstaculos.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Temperatura (10 - 50 C°)";
            // 
            // pbTemperatura
            // 
            this.pbTemperatura.Location = new System.Drawing.Point(6, 335);
            this.pbTemperatura.Name = "pbTemperatura";
            this.pbTemperatura.Size = new System.Drawing.Size(308, 23);
            this.pbTemperatura.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Presencia de Sonido";
            // 
            // pbSonido
            // 
            this.pbSonido.Location = new System.Drawing.Point(6, 287);
            this.pbSonido.Name = "pbSonido";
            this.pbSonido.Size = new System.Drawing.Size(308, 23);
            this.pbSonido.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Presencia de Luz";
            // 
            // pbLuz
            // 
            this.pbLuz.Location = new System.Drawing.Point(6, 239);
            this.pbLuz.Name = "pbLuz";
            this.pbLuz.Size = new System.Drawing.Size(308, 23);
            this.pbLuz.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Presencia de Fuego";
            // 
            // pbFuego
            // 
            this.pbFuego.Location = new System.Drawing.Point(6, 191);
            this.pbFuego.Name = "pbFuego";
            this.pbFuego.Size = new System.Drawing.Size(308, 23);
            this.pbFuego.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Presencia de Gas Propano";
            // 
            // pbPropano
            // 
            this.pbPropano.Location = new System.Drawing.Point(6, 143);
            this.pbPropano.Name = "pbPropano";
            this.pbPropano.Size = new System.Drawing.Size(308, 23);
            this.pbPropano.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Presencia de Gas Metano";
            // 
            // pbMetano
            // 
            this.pbMetano.Location = new System.Drawing.Point(6, 92);
            this.pbMetano.Name = "pbMetano";
            this.pbMetano.Size = new System.Drawing.Size(308, 23);
            this.pbMetano.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "%Humedad (0-100)";
            // 
            // pbHumo
            // 
            this.pbHumo.Location = new System.Drawing.Point(6, 45);
            this.pbHumo.Name = "pbHumo";
            this.pbHumo.Size = new System.Drawing.Size(308, 23);
            this.pbHumo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar Conexión UDP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeThread_Click);
            // 
            // btnEnlazarJoystick
            // 
            this.btnEnlazarJoystick.Location = new System.Drawing.Point(537, 93);
            this.btnEnlazarJoystick.Name = "btnEnlazarJoystick";
            this.btnEnlazarJoystick.Size = new System.Drawing.Size(132, 23);
            this.btnEnlazarJoystick.TabIndex = 9;
            this.btnEnlazarJoystick.Text = "Enlazar Joystick";
            this.btnEnlazarJoystick.UseVisualStyleBackColor = true;
            this.btnEnlazarJoystick.Click += new System.EventHandler(this.btnEnlazarJoystick_Click);
            // 
            // btnResetProgresBars
            // 
            this.btnResetProgresBars.Location = new System.Drawing.Point(537, 64);
            this.btnResetProgresBars.Name = "btnResetProgresBars";
            this.btnResetProgresBars.Size = new System.Drawing.Size(132, 23);
            this.btnResetProgresBars.TabIndex = 10;
            this.btnResetProgresBars.Text = "Resetear Sensores";
            this.btnResetProgresBars.UseVisualStyleBackColor = true;
            this.btnResetProgresBars.Click += new System.EventHandler(this.btnResetProgresBars_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1008, 713);
            this.Controls.Add(this.btnResetProgresBars);
            this.Controls.Add(this.btnEnlazarJoystick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Vehículo para el mapeo de un entorno sometido a desastres naturales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.streamPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.PictureBox streamPicture;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox portC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stopStream;
        private System.Windows.Forms.Button startStream;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pbMetano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbHumo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar pbPropano;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar pbTemperatura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pbSonido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar pbFuego;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar pbObstaculos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnlazarJoystick;
        private System.Windows.Forms.Button btnResetProgresBars;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar pbLuz;
    }
}

