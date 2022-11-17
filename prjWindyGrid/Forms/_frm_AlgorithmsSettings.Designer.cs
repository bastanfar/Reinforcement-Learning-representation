namespace prjWindyGrid
{
    partial class _frm_AlgorithmsSettings
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBox_ShowFirstEpisode = new System.Windows.Forms.CheckBox();
            this.txt_Show_Periode = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Max_Num_of_Episodes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Show_Periode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Max_Num_of_Episodes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(89, 176);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(184, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBox_ShowFirstEpisode
            // 
            this.checkBox_ShowFirstEpisode.AutoSize = true;
            this.checkBox_ShowFirstEpisode.Checked = true;
            this.checkBox_ShowFirstEpisode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowFirstEpisode.Location = new System.Drawing.Point(25, 136);
            this.checkBox_ShowFirstEpisode.Name = "checkBox_ShowFirstEpisode";
            this.checkBox_ShowFirstEpisode.Size = new System.Drawing.Size(279, 17);
            this.checkBox_ShowFirstEpisode.TabIndex = 4;
            this.checkBox_ShowFirstEpisode.Text = "Show first Episode (the first episode may be very long)";
            this.checkBox_ShowFirstEpisode.UseVisualStyleBackColor = true;
            // 
            // txt_Show_Periode
            // 
            this.txt_Show_Periode.Location = new System.Drawing.Point(201, 89);
            this.txt_Show_Periode.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_Show_Periode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_Show_Periode.Name = "txt_Show_Periode";
            this.txt_Show_Periode.Size = new System.Drawing.Size(83, 20);
            this.txt_Show_Periode.TabIndex = 3;
            this.txt_Show_Periode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Show_Periode.ThousandsSeparator = true;
            this.txt_Show_Periode.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Show Episodes by this Periode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum Number of Episodes:";
            // 
            // txt_Max_Num_of_Episodes
            // 
            this.txt_Max_Num_of_Episodes.Location = new System.Drawing.Point(201, 20);
            this.txt_Max_Num_of_Episodes.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.txt_Max_Num_of_Episodes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_Max_Num_of_Episodes.Name = "txt_Max_Num_of_Episodes";
            this.txt_Max_Num_of_Episodes.Size = new System.Drawing.Size(83, 20);
            this.txt_Max_Num_of_Episodes.TabIndex = 2;
            this.txt_Max_Num_of_Episodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Max_Num_of_Episodes.ThousandsSeparator = true;
            this.txt_Max_Num_of_Episodes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_Max_Num_of_Episodes.ValueChanged += new System.EventHandler(this.txt_Max_Num_of_Episodes_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insert a number between 10 and 20000";
            // 
            // _frm_AlgorithmsSettings
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(345, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Max_Num_of_Episodes);
            this.Controls.Add(this.txt_Show_Periode);
            this.Controls.Add(this.checkBox_ShowFirstEpisode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_frm_AlgorithmsSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Algorithms\' Settings";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Show_Periode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Max_Num_of_Episodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.CheckBox checkBox_ShowFirstEpisode;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown txt_Show_Periode;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown txt_Max_Num_of_Episodes;
        private System.Windows.Forms.Label label3;
    }
}