﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace PID_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // -------------------Event---------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //bt_clear.Enabled = false;
            bt_reset.Enabled = false;
            bt_send.Enabled = false;
            bt_start.Enabled = false;
            bt_stop.Enabled = false;
            txt_kp.Enabled = false;
            txt_ki.Enabled = false;
            txt_kd.Enabled = false;
            txt_setpoint.Enabled = false;
            txt_send.Enabled = false;
            txt_receive.Enabled = false;

            // creat Graph           
            zedGraphControl1.GraphPane.Title.Text = "Đồ thị hiển thị đáp ứng";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "Time(s)";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Position";
            RollingPointPairList list = new RollingPointPairList(99999);
            LineItem curve = zedGraphControl1.GraphPane.AddCurve("Position", list, Color.Red, SymbolType.None);
            zedGraphControl1.GraphPane.XAxis.Scale.Min = 0;
            zedGraphControl1.GraphPane.XAxis.Scale.Max = 100;
            zedGraphControl1.GraphPane.XAxis.Scale.MinorStep = 0.03;
            zedGraphControl1.GraphPane.XAxis.Scale.MajorStep = 3;
            zedGraphControl1.GraphPane.YAxis.Scale.Min = -1000;
            zedGraphControl1.GraphPane.YAxis.Scale.Max = 1000;
            zedGraphControl1.GraphPane.AxisChange();

       
    }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            if(bt_connect.Text == "Connect")
            {
                COM.PortName = cbb_Select_Com.Text;
                COM.Open();
                bt_connect.Text = "Disconnect";
                bt_connect.ForeColor = Color.Red;
                lb_status.Text = "STATUS: Connect";
                txt_receive.Text += "Serial port " + cbb_Select_Com.Text + " opened " + " \n" ;
                bt_clear.Enabled = true;
                bt_reset.Enabled = true;
                bt_send.Enabled = true;
                bt_start.Enabled = true;
                bt_stop.Enabled = true;
                txt_kp.Enabled = true;
                txt_ki.Enabled = true;
                txt_kd.Enabled = true;
                txt_setpoint.Enabled = true;
                txt_send.Enabled = true;
                txt_receive.Enabled = true;
            }
            else if(bt_connect.Text == "Disconnect")
            {
                COM.Close();
                bt_connect.Text = "Connect";
                bt_connect.ForeColor = Color.Lime;
                lb_status.Text = "STATUS: Disconnect";
                txt_receive.Text += "Serial port " + cbb_Select_Com.Text + " closed \n";
                bt_clear.Enabled = false;
                bt_reset.Enabled = false;
                bt_send.Enabled = false;
                bt_start.Enabled = false;
                bt_stop.Enabled = false;
                txt_kp.Enabled = false;
                txt_ki.Enabled = false;
                txt_kd.Enabled = false;
                txt_setpoint.Enabled = false;
                txt_send.Enabled = false;
                txt_receive.Enabled = false;
            }
        }
        private int check_mode = 5;
        private void bt_start_Click(object sender, EventArgs e)
        {
            txbuff = "0 0 1 \n";
            COM.Write(txbuff);
            
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            txbuff = "0 1 0 \n";
            COM.Write(txbuff);
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txbuff = "0 2 0 \n";
            check_mode = 5;
            COM.Write(txbuff);
        }
           

        int intlen = 0;
        float t_samp = 0.03F;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if(intlen != ports.Length)
            {
                intlen = ports.Length;
                cbb_Select_Com.Items.Clear();
                for (int j = 0; j < intlen; j++)
                {
                    cbb_Select_Com.Items.Add(ports[j]);
                }

            }
            // test graph
            realtime += 0.03;
            position += 50;
            DrawGraph();

        }


        string txbuff;
        string rxbuff;
        private void bt_send_Click(object sender, EventArgs e)
        {
            txbuff = "1" + " " + txt_kp.Text + " " + txt_ki.Text + " " + txt_kd.Text + " " + txt_setpoint.Text + " \n";
            COM.Write(txbuff);
        }

        private void processrxbuffer(object sender, EventArgs e)
        {
            rxdata = rxbuff.Split(' ');
            if (rxdata[0] == "0")
            {
                position = Convert.ToDouble(rxdata[1]);
                u_control = Convert.ToDouble(rxdata[2]);
                txt_receive.Text += "\n U Control is " + rxdata[2] + " \n";
                txt_receive.Text += "\n Position is " + rxdata[1] + " \n";

            }
            // rxdata[0] == "1" de xac nhan mode trong truong hop can phat trien sau nay
            else if (rxdata[0] == "2")
            {
                txt_send.Text += "Parameter KP is " + rxdata[1] + " \n";
                txt_send.Text += "Parameter KI is " + rxdata[2] + " \n";
                txt_send.Text += "Parameter KD is " + rxdata[3] + " \n";
                txt_send.Text += "Parameter Setpoint is " + rxdata[4] + " \n";

            }
            //rxdata[4] + '\n'; 
        }

        private void OnCom(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxbuff = COM.ReadLine();
            this.Invoke(new EventHandler(processrxbuffer));
        }
        string[] rxdata;
        double position, u_control;    
        private void bt_clear_Click(object sender, EventArgs e)
        {
            txt_receive.Text = "";
            txt_send.Text = "";
        }

        //--------------------Func----------------------
        
        private void DrawGraph()
        {


            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;

            IPointListEdit list = curve.Points as IPointListEdit;
            list.Add(realtime, position);
            
            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (realtime > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = realtime + xScale.MajorStep;
                xScale.Min = xScale.Max - 30;
            }

            // Tự động Scale theo trục y
            if (position > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = position + yScale.MajorStep;
            }
            else if (position < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = position - yScale.MajorStep;
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

        //------------Properties------------------------
        private double realtime = 0;
               

    }
}
