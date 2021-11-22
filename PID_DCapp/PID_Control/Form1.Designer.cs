
namespace PID_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_connect = new System.Windows.Forms.Button();
            this.cbb_Select_Com = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_setpoint = new System.Windows.Forms.TextBox();
            this.txt_kd = new System.Windows.Forms.TextBox();
            this.txt_ki = new System.Windows.Forms.TextBox();
            this.txt_kp = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_receive = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.BackColor = System.Drawing.SystemColors.Control;
            this.bt_connect.ForeColor = System.Drawing.Color.Lime;
            this.bt_connect.Location = new System.Drawing.Point(172, 43);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(109, 40);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = false;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // cbb_Select_Com
            // 
            this.cbb_Select_Com.FormattingEnabled = true;
            this.cbb_Select_Com.Location = new System.Drawing.Point(22, 43);
            this.cbb_Select_Com.Name = "cbb_Select_Com";
            this.cbb_Select_Com.Size = new System.Drawing.Size(134, 24);
            this.cbb_Select_Com.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lb_status);
            this.groupBox1.Controls.Add(this.cbb_Select_Com);
            this.groupBox1.Controls.Add(this.bt_connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONNECT";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(22, 100);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(141, 17);
            this.lb_status.TabIndex = 2;
            this.lb_status.Text = "STATUS: Disconnect";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_clear);
            this.groupBox2.Controls.Add(this.bt_send);
            this.groupBox2.Controls.Add(this.bt_reset);
            this.groupBox2.Controls.Add(this.bt_stop);
            this.groupBox2.Controls.Add(this.bt_start);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SYSTEM CONTROL";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(210, 100);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(146, 29);
            this.bt_clear.TabIndex = 11;
            this.bt_clear.Text = "Clear data";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(27, 100);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(146, 29);
            this.bt_send.TabIndex = 10;
            this.bt_send.Text = "Send PID";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(281, 43);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 40);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(154, 40);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(81, 40);
            this.bt_stop.TabIndex = 1;
            this.bt_stop.Text = "STOP";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(27, 41);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 39);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_setpoint);
            this.groupBox3.Controls.Add(this.txt_kd);
            this.groupBox3.Controls.Add(this.txt_ki);
            this.groupBox3.Controls.Add(this.txt_kp);
            this.groupBox3.Location = new System.Drawing.Point(764, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 145);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID PARAMETERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Setpoint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "KI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "KD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "KP";
            // 
            // txt_setpoint
            // 
            this.txt_setpoint.Location = new System.Drawing.Point(244, 76);
            this.txt_setpoint.Name = "txt_setpoint";
            this.txt_setpoint.Size = new System.Drawing.Size(100, 22);
            this.txt_setpoint.TabIndex = 3;
            // 
            // txt_kd
            // 
            this.txt_kd.Location = new System.Drawing.Point(59, 76);
            this.txt_kd.Name = "txt_kd";
            this.txt_kd.Size = new System.Drawing.Size(100, 22);
            this.txt_kd.TabIndex = 2;
            // 
            // txt_ki
            // 
            this.txt_ki.Location = new System.Drawing.Point(244, 30);
            this.txt_ki.Name = "txt_ki";
            this.txt_ki.Size = new System.Drawing.Size(100, 22);
            this.txt_ki.TabIndex = 1;
            // 
            // txt_kp
            // 
            this.txt_kp.Location = new System.Drawing.Point(59, 30);
            this.txt_kp.Name = "txt_kp";
            this.txt_kp.Size = new System.Drawing.Size(100, 22);
            this.txt_kp.TabIndex = 0;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.AllowDrop = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 166);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(910, 452);
            this.zedGraphControl1.TabIndex = 5;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // COM
            // 
            this.COM.BaudRate = 115200;
            this.COM.PortName = "Serial";
            this.COM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnCom);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_receive);
            this.groupBox4.Location = new System.Drawing.Point(930, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 219);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive Data";
            // 
            // txt_receive
            // 
            this.txt_receive.AllowDrop = true;
            this.txt_receive.Location = new System.Drawing.Point(11, 34);
            this.txt_receive.Multiline = true;
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_receive.Size = new System.Drawing.Size(211, 179);
            this.txt_receive.TabIndex = 0;
            this.txt_receive.TextChanged += new System.EventHandler(this.txt_receive_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_send);
            this.groupBox5.Location = new System.Drawing.Point(930, 399);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 219);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Send Data";
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(10, 21);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_send.Size = new System.Drawing.Size(212, 192);
            this.txt_send.TabIndex = 0;
            this.txt_send.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1170, 631);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PID CONTROL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.ComboBox cbb_Select_Com;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_setpoint;
        private System.Windows.Forms.TextBox txt_kd;
        private System.Windows.Forms.TextBox txt_ki;
        private System.Windows.Forms.TextBox txt_kp;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_receive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button bt_clear;
    }
}

