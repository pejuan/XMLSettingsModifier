namespace XML_SettingsModifier
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
            this.bt_modify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_apikey = new System.Windows.Forms.TextBox();
            this.tb_token = new System.Windows.Forms.TextBox();
            this.tb_surveyName = new System.Windows.Forms.TextBox();
            this.tb_titlesContaining = new System.Windows.Forms.TextBox();
            this.dtp_datesprior = new System.Windows.Forms.DateTimePicker();
            this.dtp_datesafter = new System.Windows.Forms.DateTimePicker();
            this.sp_registrynumber = new System.Windows.Forms.NumericUpDown();
            this.sp_initialpage = new System.Windows.Forms.NumericUpDown();
            this.sp_endingpage = new System.Windows.Forms.NumericUpDown();
            this.sp_responsesperpage = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_nameGiven = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sp_registrynumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_initialpage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_endingpage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_responsesperpage)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_modify
            // 
            this.bt_modify.Location = new System.Drawing.Point(668, 600);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(75, 23);
            this.bt_modify.TabIndex = 3;
            this.bt_modify.Text = "Modify";
            this.bt_modify.UseVisualStyleBackColor = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dates Prior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dates After";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Survey Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Titles Containing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amount of registries";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Initial Page for responses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ending Page for responses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Responses per page";
            // 
            // tb_apikey
            // 
            this.tb_apikey.Location = new System.Drawing.Point(255, 115);
            this.tb_apikey.Name = "tb_apikey";
            this.tb_apikey.Size = new System.Drawing.Size(253, 20);
            this.tb_apikey.TabIndex = 5;
            this.tb_apikey.TextChanged += new System.EventHandler(this.tb_apikey_TextChanged);
            // 
            // tb_token
            // 
            this.tb_token.Location = new System.Drawing.Point(255, 149);
            this.tb_token.Multiline = true;
            this.tb_token.Name = "tb_token";
            this.tb_token.Size = new System.Drawing.Size(775, 104);
            this.tb_token.TabIndex = 5;
            // 
            // tb_surveyName
            // 
            this.tb_surveyName.Location = new System.Drawing.Point(255, 336);
            this.tb_surveyName.Name = "tb_surveyName";
            this.tb_surveyName.Size = new System.Drawing.Size(253, 20);
            this.tb_surveyName.TabIndex = 5;
            // 
            // tb_titlesContaining
            // 
            this.tb_titlesContaining.Location = new System.Drawing.Point(255, 375);
            this.tb_titlesContaining.Name = "tb_titlesContaining";
            this.tb_titlesContaining.Size = new System.Drawing.Size(144, 20);
            this.tb_titlesContaining.TabIndex = 5;
            // 
            // dtp_datesprior
            // 
            this.dtp_datesprior.Location = new System.Drawing.Point(255, 268);
            this.dtp_datesprior.Name = "dtp_datesprior";
            this.dtp_datesprior.Size = new System.Drawing.Size(200, 20);
            this.dtp_datesprior.TabIndex = 6;
            // 
            // dtp_datesafter
            // 
            this.dtp_datesafter.Location = new System.Drawing.Point(255, 295);
            this.dtp_datesafter.Name = "dtp_datesafter";
            this.dtp_datesafter.Size = new System.Drawing.Size(200, 20);
            this.dtp_datesafter.TabIndex = 7;
            // 
            // sp_registrynumber
            // 
            this.sp_registrynumber.Location = new System.Drawing.Point(255, 416);
            this.sp_registrynumber.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sp_registrynumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.sp_registrynumber.Name = "sp_registrynumber";
            this.sp_registrynumber.Size = new System.Drawing.Size(120, 20);
            this.sp_registrynumber.TabIndex = 8;
            // 
            // sp_initialpage
            // 
            this.sp_initialpage.Location = new System.Drawing.Point(255, 462);
            this.sp_initialpage.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sp_initialpage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sp_initialpage.Name = "sp_initialpage";
            this.sp_initialpage.Size = new System.Drawing.Size(120, 20);
            this.sp_initialpage.TabIndex = 8;
            this.sp_initialpage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sp_endingpage
            // 
            this.sp_endingpage.Location = new System.Drawing.Point(255, 506);
            this.sp_endingpage.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sp_endingpage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sp_endingpage.Name = "sp_endingpage";
            this.sp_endingpage.Size = new System.Drawing.Size(120, 20);
            this.sp_endingpage.TabIndex = 8;
            this.sp_endingpage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sp_responsesperpage
            // 
            this.sp_responsesperpage.Location = new System.Drawing.Point(255, 549);
            this.sp_responsesperpage.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sp_responsesperpage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sp_responsesperpage.Name = "sp_responsesperpage";
            this.sp_responsesperpage.Size = new System.Drawing.Size(120, 20);
            this.sp_responsesperpage.TabIndex = 8;
            this.sp_responsesperpage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(175, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(774, 36);
            this.label11.TabIndex = 9;
            this.label11.Text = "SURVEY MONKEY IMPLEMENTATION XML MODIFIER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(381, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Value of -1 indicates ALL REGISTRIES";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 600);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Name of files generated";
            // 
            // tb_nameGiven
            // 
            this.tb_nameGiven.Location = new System.Drawing.Point(255, 593);
            this.tb_nameGiven.Name = "tb_nameGiven";
            this.tb_nameGiven.Size = new System.Drawing.Size(305, 20);
            this.tb_nameGiven.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 661);
            this.Controls.Add(this.tb_nameGiven);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sp_responsesperpage);
            this.Controls.Add(this.sp_endingpage);
            this.Controls.Add(this.sp_initialpage);
            this.Controls.Add(this.sp_registrynumber);
            this.Controls.Add(this.dtp_datesafter);
            this.Controls.Add(this.dtp_datesprior);
            this.Controls.Add(this.tb_token);
            this.Controls.Add(this.tb_titlesContaining);
            this.Controls.Add(this.tb_surveyName);
            this.Controls.Add(this.tb_apikey);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_modify);
            this.Name = "Form1";
            this.Text = "XML MODIFIER";
            ((System.ComponentModel.ISupportInitialize)(this.sp_registrynumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_initialpage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_endingpage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_responsesperpage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_modify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_apikey;
        private System.Windows.Forms.TextBox tb_token;
        private System.Windows.Forms.TextBox tb_surveyName;
        private System.Windows.Forms.TextBox tb_titlesContaining;
        private System.Windows.Forms.DateTimePicker dtp_datesprior;
        private System.Windows.Forms.DateTimePicker dtp_datesafter;
        private System.Windows.Forms.NumericUpDown sp_registrynumber;
        private System.Windows.Forms.NumericUpDown sp_initialpage;
        private System.Windows.Forms.NumericUpDown sp_endingpage;
        private System.Windows.Forms.NumericUpDown sp_responsesperpage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_nameGiven;
    }
}

