namespace Speed_tester
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
            this.info_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TCP_group = new System.Windows.Forms.GroupBox();
            this.UDP_group = new System.Windows.Forms.GroupBox();
            this.listen_button = new System.Windows.Forms.Button();
            this.port_input_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TCP_dataSize_textBox = new System.Windows.Forms.TextBox();
            this.TCP_totalDataSize_textBox = new System.Windows.Forms.TextBox();
            this.TCP_transTime_textBox = new System.Windows.Forms.TextBox();
            this.TCP_statsTime_textBox = new System.Windows.Forms.TextBox();
            this.TCP_transSpeed_textBox = new System.Windows.Forms.TextBox();
            this.TCP_loss_textBox = new System.Windows.Forms.TextBox();
            this.TCP_errorRate_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UDP_errorRate_textBox = new System.Windows.Forms.TextBox();
            this.UDP_loss_textBox = new System.Windows.Forms.TextBox();
            this.UDP_transSpeed_textBox = new System.Windows.Forms.TextBox();
            this.UDP_statsTime_textBox = new System.Windows.Forms.TextBox();
            this.UDP_transTime_textBox = new System.Windows.Forms.TextBox();
            this.UDP_totalDataSize_textBox = new System.Windows.Forms.TextBox();
            this.UDP_dataSize_textBox = new System.Windows.Forms.TextBox();
            this.info_group.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TCP_group.SuspendLayout();
            this.UDP_group.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_group
            // 
            this.info_group.Controls.Add(this.tableLayoutPanel2);
            this.info_group.Location = new System.Drawing.Point(3, 3);
            this.info_group.Name = "info_group";
            this.info_group.Size = new System.Drawing.Size(179, 247);
            this.info_group.TabIndex = 0;
            this.info_group.TabStop = false;
            this.info_group.Text = "info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.UDP_group, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.info_group, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TCP_group, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(125, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 253);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TCP_group
            // 
            this.TCP_group.Controls.Add(this.tableLayoutPanel3);
            this.TCP_group.Location = new System.Drawing.Point(188, 3);
            this.TCP_group.Name = "TCP_group";
            this.TCP_group.Size = new System.Drawing.Size(179, 247);
            this.TCP_group.TabIndex = 1;
            this.TCP_group.TabStop = false;
            this.TCP_group.Text = "TCP";
            // 
            // UDP_group
            // 
            this.UDP_group.Controls.Add(this.tableLayoutPanel4);
            this.UDP_group.Location = new System.Drawing.Point(373, 3);
            this.UDP_group.Name = "UDP_group";
            this.UDP_group.Size = new System.Drawing.Size(181, 247);
            this.UDP_group.TabIndex = 1;
            this.UDP_group.TabStop = false;
            this.UDP_group.Text = "UDP";
            // 
            // listen_button
            // 
            this.listen_button.Location = new System.Drawing.Point(313, 83);
            this.listen_button.Name = "listen_button";
            this.listen_button.Size = new System.Drawing.Size(369, 23);
            this.listen_button.TabIndex = 2;
            this.listen_button.Text = "Start listening";
            this.listen_button.UseVisualStyleBackColor = true;
            this.listen_button.Click += new System.EventHandler(this.listen_button_Click);
            // 
            // port_input_textBox
            // 
            this.port_input_textBox.Location = new System.Drawing.Point(190, 85);
            this.port_input_textBox.Name = "port_input_textBox";
            this.port_input_textBox.Size = new System.Drawing.Size(117, 20);
            this.port_input_textBox.TabIndex = 3;
            this.port_input_textBox.Text = "7777";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listen port:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Single data UDPsize[bytes]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 210);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.TCP_errorRate_textBox, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.TCP_loss_textBox, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.TCP_transSpeed_textBox, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TCP_statsTime_textBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TCP_transTime_textBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TCP_totalDataSize_textBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TCP_dataSize_textBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(169, 210);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total UDPsize [kbytes]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Transmission time [s]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stats calc time [ms]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Transmission speed [kb/s]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lost data [bytes]";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Error rate [%]";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCP_dataSize_textBox
            // 
            this.TCP_dataSize_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TCP_dataSize_textBox.Location = new System.Drawing.Point(3, 4);
            this.TCP_dataSize_textBox.Name = "TCP_dataSize_textBox";
            this.TCP_dataSize_textBox.ReadOnly = true;
            this.TCP_dataSize_textBox.Size = new System.Drawing.Size(163, 20);
            this.TCP_dataSize_textBox.TabIndex = 0;
            this.TCP_dataSize_textBox.Text = "0";
            this.TCP_dataSize_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TCP_totalDataSize_textBox
            // 
            this.TCP_totalDataSize_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TCP_totalDataSize_textBox.Location = new System.Drawing.Point(3, 33);
            this.TCP_totalDataSize_textBox.Name = "TCP_totalDataSize_textBox";
            this.TCP_totalDataSize_textBox.ReadOnly = true;
            this.TCP_totalDataSize_textBox.Size = new System.Drawing.Size(163, 20);
            this.TCP_totalDataSize_textBox.TabIndex = 1;
            this.TCP_totalDataSize_textBox.Text = "0";
            this.TCP_totalDataSize_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TCP_transTime_textBox
            // 
            this.TCP_transTime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TCP_transTime_textBox.Location = new System.Drawing.Point(3, 62);
            this.TCP_transTime_textBox.Name = "TCP_transTime_textBox";
            this.TCP_transTime_textBox.ReadOnly = true;
            this.TCP_transTime_textBox.Size = new System.Drawing.Size(163, 20);
            this.TCP_transTime_textBox.TabIndex = 2;
            this.TCP_transTime_textBox.Text = "0";
            this.TCP_transTime_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TCP_statsTime_textBox
            // 
            this.TCP_statsTime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TCP_statsTime_textBox.Location = new System.Drawing.Point(3, 91);
            this.TCP_statsTime_textBox.Name = "TCP_statsTime_textBox";
            this.TCP_statsTime_textBox.ReadOnly = true;
            this.TCP_statsTime_textBox.Size = new System.Drawing.Size(163, 20);
            this.TCP_statsTime_textBox.TabIndex = 3;
            this.TCP_statsTime_textBox.Text = "0";
            this.TCP_statsTime_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TCP_transSpeed_textBox
            // 
            this.TCP_transSpeed_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TCP_transSpeed_textBox.Location = new System.Drawing.Point(3, 120);
            this.TCP_transSpeed_textBox.Name = "TCP_transSpeed_textBox";
            this.TCP_transSpeed_textBox.ReadOnly = true;
            this.TCP_transSpeed_textBox.Size = new System.Drawing.Size(163, 20);
            this.TCP_transSpeed_textBox.TabIndex = 4;
            this.TCP_transSpeed_textBox.Text = "0";
            this.TCP_transSpeed_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TCP_loss_textBox
            // 
            this.TCP_loss_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TCP_loss_textBox.Location = new System.Drawing.Point(3, 149);
            this.TCP_loss_textBox.Name = "TCP_loss_textBox";
            this.TCP_loss_textBox.ReadOnly = true;
            this.TCP_loss_textBox.Size = new System.Drawing.Size(163, 20);
            this.TCP_loss_textBox.TabIndex = 5;
            this.TCP_loss_textBox.Text = "0";
            this.TCP_loss_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TCP_errorRate_textBox
            // 
            this.TCP_errorRate_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TCP_errorRate_textBox.Location = new System.Drawing.Point(3, 182);
            this.TCP_errorRate_textBox.Name = "TCP_errorRate_textBox";
            this.TCP_errorRate_textBox.ReadOnly = true;
            this.TCP_errorRate_textBox.Size = new System.Drawing.Size(163, 20);
            this.TCP_errorRate_textBox.TabIndex = 6;
            this.TCP_errorRate_textBox.Text = "0";
            this.TCP_errorRate_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.UDP_errorRate_textBox, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.UDP_loss_textBox, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.UDP_transSpeed_textBox, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.UDP_statsTime_textBox, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.UDP_transTime_textBox, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.UDP_totalDataSize_textBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.UDP_dataSize_textBox, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(169, 210);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // UDP_errorRate_textBox
            // 
            this.UDP_errorRate_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UDP_errorRate_textBox.Location = new System.Drawing.Point(3, 182);
            this.UDP_errorRate_textBox.Name = "UDP_errorRate_textBox";
            this.UDP_errorRate_textBox.ReadOnly = true;
            this.UDP_errorRate_textBox.Size = new System.Drawing.Size(163, 20);
            this.UDP_errorRate_textBox.TabIndex = 6;
            this.UDP_errorRate_textBox.Text = "0";
            this.UDP_errorRate_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UDP_loss_textBox
            // 
            this.UDP_loss_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UDP_loss_textBox.Location = new System.Drawing.Point(3, 149);
            this.UDP_loss_textBox.Name = "UDP_loss_textBox";
            this.UDP_loss_textBox.ReadOnly = true;
            this.UDP_loss_textBox.Size = new System.Drawing.Size(163, 20);
            this.UDP_loss_textBox.TabIndex = 5;
            this.UDP_loss_textBox.Text = "0";
            this.UDP_loss_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UDP_transSpeed_textBox
            // 
            this.UDP_transSpeed_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UDP_transSpeed_textBox.Location = new System.Drawing.Point(3, 120);
            this.UDP_transSpeed_textBox.Name = "UDP_transSpeed_textBox";
            this.UDP_transSpeed_textBox.ReadOnly = true;
            this.UDP_transSpeed_textBox.Size = new System.Drawing.Size(163, 20);
            this.UDP_transSpeed_textBox.TabIndex = 4;
            this.UDP_transSpeed_textBox.Text = "0";
            this.UDP_transSpeed_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UDP_statsTime_textBox
            // 
            this.UDP_statsTime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UDP_statsTime_textBox.Location = new System.Drawing.Point(3, 91);
            this.UDP_statsTime_textBox.Name = "UDP_statsTime_textBox";
            this.UDP_statsTime_textBox.ReadOnly = true;
            this.UDP_statsTime_textBox.Size = new System.Drawing.Size(163, 20);
            this.UDP_statsTime_textBox.TabIndex = 3;
            this.UDP_statsTime_textBox.Text = "0";
            this.UDP_statsTime_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UDP_transTime_textBox
            // 
            this.UDP_transTime_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UDP_transTime_textBox.Location = new System.Drawing.Point(3, 62);
            this.UDP_transTime_textBox.Name = "UDP_transTime_textBox";
            this.UDP_transTime_textBox.ReadOnly = true;
            this.UDP_transTime_textBox.Size = new System.Drawing.Size(163, 20);
            this.UDP_transTime_textBox.TabIndex = 2;
            this.UDP_transTime_textBox.Text = "0";
            this.UDP_transTime_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UDP_totalDataSize_textBox
            // 
            this.UDP_totalDataSize_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UDP_totalDataSize_textBox.Location = new System.Drawing.Point(3, 33);
            this.UDP_totalDataSize_textBox.Name = "UDP_totalDataSize_textBox";
            this.UDP_totalDataSize_textBox.ReadOnly = true;
            this.UDP_totalDataSize_textBox.Size = new System.Drawing.Size(163, 20);
            this.UDP_totalDataSize_textBox.TabIndex = 1;
            this.UDP_totalDataSize_textBox.Text = "0";
            this.UDP_totalDataSize_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UDP_dataSize_textBox
            // 
            this.UDP_dataSize_textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UDP_dataSize_textBox.Location = new System.Drawing.Point(3, 4);
            this.UDP_dataSize_textBox.Name = "UDP_dataSize_textBox";
            this.UDP_dataSize_textBox.ReadOnly = true;
            this.UDP_dataSize_textBox.Size = new System.Drawing.Size(163, 20);
            this.UDP_dataSize_textBox.TabIndex = 0;
            this.UDP_dataSize_textBox.Text = "0";
            this.UDP_dataSize_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_input_textBox);
            this.Controls.Add(this.listen_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Speed Tester";
            this.info_group.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TCP_group.ResumeLayout(false);
            this.UDP_group.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox info_group;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox UDP_group;
        private System.Windows.Forms.GroupBox TCP_group;
        private System.Windows.Forms.Button listen_button;
        private System.Windows.Forms.TextBox port_input_textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox TCP_errorRate_textBox;
        private System.Windows.Forms.TextBox TCP_loss_textBox;
        private System.Windows.Forms.TextBox TCP_transSpeed_textBox;
        private System.Windows.Forms.TextBox TCP_statsTime_textBox;
        private System.Windows.Forms.TextBox TCP_transTime_textBox;
        private System.Windows.Forms.TextBox TCP_totalDataSize_textBox;
        public System.Windows.Forms.TextBox TCP_dataSize_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox UDP_errorRate_textBox;
        private System.Windows.Forms.TextBox UDP_loss_textBox;
        private System.Windows.Forms.TextBox UDP_transSpeed_textBox;
        private System.Windows.Forms.TextBox UDP_statsTime_textBox;
        private System.Windows.Forms.TextBox UDP_transTime_textBox;
        private System.Windows.Forms.TextBox UDP_totalDataSize_textBox;
        private System.Windows.Forms.TextBox UDP_dataSize_textBox;
    }
}

