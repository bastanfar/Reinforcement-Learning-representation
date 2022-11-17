namespace prjWindyGrid
{
    partial class _frm_AnimationSettings
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
            this.txtDelay = new System.Windows.Forms.NumericUpDown();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Flash = new System.Windows.Forms.CheckBox();
            this.checkBox_Maintain_Footprint = new System.Windows.Forms.CheckBox();
            this.checkBox_Show = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(207, 47);
            this.txtDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(75, 20);
            this.txtDelay.TabIndex = 0;
            this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(175, 216);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(79, 216);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delay between actions (movements)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insert a number between 10 and 1000";
            // 
            // checkBox_Flash
            // 
            this.checkBox_Flash.AutoSize = true;
            this.checkBox_Flash.Checked = true;
            this.checkBox_Flash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Flash.Location = new System.Drawing.Point(23, 117);
            this.checkBox_Flash.Name = "checkBox_Flash";
            this.checkBox_Flash.Size = new System.Drawing.Size(177, 17);
            this.checkBox_Flash.TabIndex = 3;
            this.checkBox_Flash.Text = "Flash when reached to the Goal";
            this.checkBox_Flash.UseVisualStyleBackColor = true;
            // 
            // checkBox_Maintain_Footprint
            // 
            this.checkBox_Maintain_Footprint.AutoSize = true;
            this.checkBox_Maintain_Footprint.Checked = true;
            this.checkBox_Maintain_Footprint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Maintain_Footprint.Location = new System.Drawing.Point(23, 89);
            this.checkBox_Maintain_Footprint.Name = "checkBox_Maintain_Footprint";
            this.checkBox_Maintain_Footprint.Size = new System.Drawing.Size(203, 17);
            this.checkBox_Maintain_Footprint.TabIndex = 3;
            this.checkBox_Maintain_Footprint.Text = "Maitain the path through Start to Goal";
            this.checkBox_Maintain_Footprint.UseVisualStyleBackColor = true;
            // 
            // checkBox_Show
            // 
            this.checkBox_Show.AutoSize = true;
            this.checkBox_Show.Checked = true;
            this.checkBox_Show.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Show.Location = new System.Drawing.Point(16, 17);
            this.checkBox_Show.Name = "checkBox_Show";
            this.checkBox_Show.Size = new System.Drawing.Size(111, 17);
            this.checkBox_Show.TabIndex = 3;
            this.checkBox_Show.Text = "Show the episode";
            this.checkBox_Show.UseVisualStyleBackColor = true;
            this.checkBox_Show.CheckedChanged += new System.EventHandler(this.checkBox_Show_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.checkBox_Maintain_Footprint);
            this.groupBox.Controls.Add(this.txtDelay);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.checkBox_Flash);
            this.groupBox.Location = new System.Drawing.Point(16, 44);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(297, 158);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // _frm_AnimationSettings
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(328, 250);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.checkBox_Show);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_frm_AnimationSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Animation Settings";
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown txtDelay;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox checkBox_Flash;
        public System.Windows.Forms.CheckBox checkBox_Maintain_Footprint;
        public System.Windows.Forms.CheckBox checkBox_Show;
        private System.Windows.Forms.GroupBox groupBox;

    }
}