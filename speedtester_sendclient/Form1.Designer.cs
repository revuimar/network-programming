namespace speedtester_sendclient
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
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.add_adress_button = new System.Windows.Forms.Button();
            this.port_selector = new System.Windows.Forms.NumericUpDown();
            this.address_list_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.size_track_bar = new System.Windows.Forms.TrackBar();
            this.console_box = new System.Windows.Forms.TextBox();
            this.writer = new TextBoxWriter(console_box);
            this.transission_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.del_all_button = new System.Windows.Forms.Button();
            this.nagle_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.port_selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_track_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(208, 127);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(100, 20);
            this.address_textbox.TabIndex = 0;
            this.address_textbox.Text = "127.0.0.1";
            // 
            // add_adress_button
            // 
            this.add_adress_button.Location = new System.Drawing.Point(475, 125);
            this.add_adress_button.Name = "add_adress_button";
            this.add_adress_button.Size = new System.Drawing.Size(75, 23);
            this.add_adress_button.TabIndex = 1;
            this.add_adress_button.Text = "Add";
            this.add_adress_button.UseVisualStyleBackColor = true;
            this.add_adress_button.Click += new System.EventHandler(this.add_adress_button_Click);
            // 
            // port_selector
            // 
            this.port_selector.Location = new System.Drawing.Point(334, 127);
            this.port_selector.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_selector.Name = "port_selector";
            this.port_selector.Size = new System.Drawing.Size(120, 20);
            this.port_selector.TabIndex = 2;
            this.port_selector.Value = new decimal(new int[] {
            7777,
            0,
            0,
            0});
            // 
            // address_list_combo
            // 
            this.address_list_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.address_list_combo.FormattingEnabled = true;
            this.address_list_combo.Location = new System.Drawing.Point(208, 175);
            this.address_list_combo.Name = "address_list_combo";
            this.address_list_combo.Size = new System.Drawing.Size(121, 21);
            this.address_list_combo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Addres List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Payload size:";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(308, 218);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(19, 13);
            this.size_label.TabIndex = 10;
            this.size_label.Text = "50";
            // 
            // size_track_bar
            // 
            this.size_track_bar.LargeChange = 50;
            this.size_track_bar.Location = new System.Drawing.Point(208, 239);
            this.size_track_bar.Maximum = 65000;
            this.size_track_bar.Minimum = 1;
            this.size_track_bar.Name = "size_track_bar";
            this.size_track_bar.Size = new System.Drawing.Size(342, 45);
            this.size_track_bar.TabIndex = 11;
            this.size_track_bar.TickFrequency = 5000;
            this.size_track_bar.Value = 50;
            this.size_track_bar.Scroll += new System.EventHandler(this.size_track_bar_Scroll);
            // 
            // console_box
            // 
            this.console_box.Location = new System.Drawing.Point(208, 325);
            this.console_box.Multiline = true;
            this.console_box.Name = "console_box";
            this.console_box.ReadOnly = true;
            this.console_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console_box.Size = new System.Drawing.Size(342, 100);
            this.console_box.TabIndex = 6;
            // 
            // transission_button
            // 
            this.transission_button.Location = new System.Drawing.Point(208, 285);
            this.transission_button.Name = "transission_button";
            this.transission_button.Size = new System.Drawing.Size(342, 23);
            this.transission_button.TabIndex = 13;
            this.transission_button.Text = "Start Transmission";
            this.transission_button.UseVisualStyleBackColor = true;
            this.transission_button.Click += new System.EventHandler(this.transission_button_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(346, 174);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(70, 23);
            this.del_button.TabIndex = 14;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // del_all_button
            // 
            this.del_all_button.Location = new System.Drawing.Point(422, 174);
            this.del_all_button.Name = "del_all_button";
            this.del_all_button.Size = new System.Drawing.Size(70, 23);
            this.del_all_button.TabIndex = 15;
            this.del_all_button.Text = "Delete All";
            this.del_all_button.UseVisualStyleBackColor = true;
            this.del_all_button.Click += new System.EventHandler(this.del_all_button_Click);
            // 
            // nagle_checkBox
            // 
            this.nagle_checkBox.AutoSize = true;
            this.nagle_checkBox.Location = new System.Drawing.Point(355, 217);
            this.nagle_checkBox.Name = "nagle_checkBox";
            this.nagle_checkBox.Size = new System.Drawing.Size(99, 17);
            this.nagle_checkBox.TabIndex = 16;
            this.nagle_checkBox.Text = "Nagle algorithm";
            this.nagle_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nagle_checkBox);
            this.Controls.Add(this.del_all_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.transission_button);
            this.Controls.Add(this.console_box);
            this.Controls.Add(this.size_track_bar);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address_list_combo);
            this.Controls.Add(this.port_selector);
            this.Controls.Add(this.add_adress_button);
            this.Controls.Add(this.address_textbox);
            this.Name = "Form1";
            this.Text = "Speed Tester Client";
            ((System.ComponentModel.ISupportInitialize)(this.port_selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_track_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBoxWriter writer;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button add_adress_button;
        private System.Windows.Forms.NumericUpDown port_selector;
        private System.Windows.Forms.ComboBox address_list_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.TrackBar size_track_bar;
        private System.Windows.Forms.TextBox console_box;
        private System.Windows.Forms.Button transission_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button del_all_button;
        private System.Windows.Forms.CheckBox nagle_checkBox;
    }
}

