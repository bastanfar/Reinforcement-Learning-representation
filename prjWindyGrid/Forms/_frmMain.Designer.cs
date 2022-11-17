namespace prjWindyGrid
{
    partial class _frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnu_Context_StartGoal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_SetStartHere = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SetGoalHere = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus_Help = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.aboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_RestartProg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgGrid = new System.Windows.Forms.DataGridView();
            this.dgWind = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Start_MC = new System.Windows.Forms.Button();
            this.btn_StartTD__QL = new System.Windows.Forms.Button();
            this.btn_Start_TD_Sarsa = new System.Windows.Forms.Button();
            this.groupBox_Results = new System.Windows.Forms.GroupBox();
            this.btn_Results = new System.Windows.Forms.Button();
            this.btn_Export_Data = new System.Windows.Forms.Button();
            this.groupBox_GridSettings = new System.Windows.Forms.GroupBox();
            this.btn_AcceptGridProperties = new System.Windows.Forms.Button();
            this.txtGoalPoint = new System.Windows.Forms.TextBox();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGridCols = new System.Windows.Forms.NumericUpDown();
            this.txtGridRows = new System.Windows.Forms.NumericUpDown();
            this._panel_Controls = new System.Windows.Forms.Panel();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.btn_AlgrorithmSetting = new System.Windows.Forms.Button();
            this.btn_AnimSettinsa = new System.Windows.Forms.Button();
            this.lbl_Left = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.txtWind = new System.Windows.Forms.NumericUpDown();
            this._panel_WindyGrid = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lblEpisodeLength = new System.Windows.Forms.Label();
            this.lblEpisode_ALL = new System.Windows.Forms.Label();
            this.prgrssBar_All = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.prgrssBar_EpisodeLength = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_M2 = new System.Windows.Forms.Label();
            this.lbl_M1 = new System.Windows.Forms.Label();
            this.lbl_Algorithm_Parameters = new System.Windows.Forms.Label();
            this.mnu_Context_StartGoal.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWind)).BeginInit();
            this.groupBox_Operation.SuspendLayout();
            this.groupBox_Results.SuspendLayout();
            this.groupBox_GridSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGridCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGridRows)).BeginInit();
            this._panel_Controls.SuspendLayout();
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWind)).BeginInit();
            this._panel_WindyGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Context_StartGoal
            // 
            this.mnu_Context_StartGoal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_SetStartHere,
            this.mnu_SetGoalHere});
            this.mnu_Context_StartGoal.Name = "menu1";
            this.mnu_Context_StartGoal.ShowImageMargin = false;
            this.mnu_Context_StartGoal.Size = new System.Drawing.Size(121, 48);
            // 
            // mnu_SetStartHere
            // 
            this.mnu_SetStartHere.Name = "mnu_SetStartHere";
            this.mnu_SetStartHere.Size = new System.Drawing.Size(120, 22);
            this.mnu_SetStartHere.Text = "Set Start Here";
            this.mnu_SetStartHere.ToolTipText = "Click to set this cell as Start";
            this.mnu_SetStartHere.Click += new System.EventHandler(this.mnu_SetStartHere_Click);
            // 
            // mnu_SetGoalHere
            // 
            this.mnu_SetGoalHere.Name = "mnu_SetGoalHere";
            this.mnu_SetGoalHere.Size = new System.Drawing.Size(120, 22);
            this.mnu_SetGoalHere.Text = "Set Goal Here";
            this.mnu_SetGoalHere.ToolTipText = "Click to set this cell as Goal";
            this.mnu_SetGoalHere.Click += new System.EventHandler(this.mnu_SetGoalHere_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus_Help,
            this.lblStatusPosition,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 640);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus_Help
            // 
            this.lblStatus_Help.AutoSize = false;
            this.lblStatus_Help.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.lblStatus_Help.Name = "lblStatus_Help";
            this.lblStatus_Help.Size = new System.Drawing.Size(600, 17);
            this.lblStatus_Help.Text = " Define your own settings for the Grid or Click Ok";
            this.lblStatus_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusPosition
            // 
            this.lblStatusPosition.AutoSize = false;
            this.lblStatusPosition.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblStatusPosition.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblStatusPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatusPosition.Name = "lblStatusPosition";
            this.lblStatusPosition.Size = new System.Drawing.Size(50, 17);
            this.lblStatusPosition.Text = "     ";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgramToolStripMenuItem,
            this.btn_RestartProg});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(58, 20);
            this.toolStripSplitButton1.Text = "Action";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            this.aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            this.aboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutTheProgramToolStripMenuItem.Text = "About the Program";
            this.aboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutTheProgramToolStripMenuItem_Click);
            // 
            // btn_RestartProg
            // 
            this.btn_RestartProg.Name = "btn_RestartProg";
            this.btn_RestartProg.Size = new System.Drawing.Size(176, 22);
            this.btn_RestartProg.Text = "Restart Program";
            this.btn_RestartProg.Click += new System.EventHandler(this.btn_RestartProg_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // dgGrid
            // 
            this.dgGrid.AllowUserToAddRows = false;
            this.dgGrid.AllowUserToDeleteRows = false;
            this.dgGrid.AllowUserToResizeColumns = false;
            this.dgGrid.AllowUserToResizeRows = false;
            this.dgGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgGrid.ColumnHeadersHeight = 30;
            this.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgGrid.ColumnHeadersVisible = false;
            this.dgGrid.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgGrid.Location = new System.Drawing.Point(38, 3);
            this.dgGrid.MultiSelect = false;
            this.dgGrid.Name = "dgGrid";
            this.dgGrid.ReadOnly = true;
            this.dgGrid.RowHeadersVisible = false;
            this.dgGrid.RowHeadersWidth = 30;
            this.dgGrid.RowTemplate.Height = 40;
            this.dgGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgGrid.ShowCellErrors = false;
            this.dgGrid.ShowEditingIcon = false;
            this.dgGrid.ShowRowErrors = false;
            this.dgGrid.Size = new System.Drawing.Size(540, 353);
            this.dgGrid.TabIndex = 0;
            this.dgGrid.TabStop = false;
            this.dgGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGrid_CellDoubleClick);
            this.dgGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGrid_CellMouseLeave);
            this.dgGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgGrid_CellMouseMove);
            this.dgGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgGrid_CellMouseUp);
            // 
            // dgWind
            // 
            this.dgWind.AllowUserToAddRows = false;
            this.dgWind.AllowUserToDeleteRows = false;
            this.dgWind.AllowUserToOrderColumns = true;
            this.dgWind.AllowUserToResizeColumns = false;
            this.dgWind.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgWind.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgWind.BackgroundColor = System.Drawing.Color.White;
            this.dgWind.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWind.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgWind.ColumnHeadersHeight = 30;
            this.dgWind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgWind.ColumnHeadersVisible = false;
            this.dgWind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWind.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgWind.Location = new System.Drawing.Point(311, 371);
            this.dgWind.Name = "dgWind";
            this.dgWind.ReadOnly = true;
            this.dgWind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgWind.RowHeadersVisible = false;
            this.dgWind.RowHeadersWidth = 30;
            this.dgWind.RowTemplate.Height = 40;
            this.dgWind.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgWind.Size = new System.Drawing.Size(540, 19);
            this.dgWind.TabIndex = 3;
            this.dgWind.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgWind_CellMouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 10F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_Start_MC);
            this.groupBox_Operation.Controls.Add(this.btn_StartTD__QL);
            this.groupBox_Operation.Controls.Add(this.btn_Start_TD_Sarsa);
            this.groupBox_Operation.Enabled = false;
            this.groupBox_Operation.Location = new System.Drawing.Point(12, 336);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(148, 154);
            this.groupBox_Operation.TabIndex = 16;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Opeations   ";
            // 
            // btn_Start_MC
            // 
            this.btn_Start_MC.Location = new System.Drawing.Point(21, 35);
            this.btn_Start_MC.Name = "btn_Start_MC";
            this.btn_Start_MC.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Start_MC.Size = new System.Drawing.Size(96, 23);
            this.btn_Start_MC.TabIndex = 6;
            this.btn_Start_MC.Text = "Monte Carlo";
            this.btn_Start_MC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Start_MC.UseVisualStyleBackColor = true;
            this.btn_Start_MC.Click += new System.EventHandler(this.btn_Start_MC_Click);
            // 
            // btn_StartTD__QL
            // 
            this.btn_StartTD__QL.Location = new System.Drawing.Point(21, 100);
            this.btn_StartTD__QL.Name = "btn_StartTD__QL";
            this.btn_StartTD__QL.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_StartTD__QL.Size = new System.Drawing.Size(96, 23);
            this.btn_StartTD__QL.TabIndex = 8;
            this.btn_StartTD__QL.Text = "TD Q-Learning";
            this.btn_StartTD__QL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StartTD__QL.UseVisualStyleBackColor = true;
            this.btn_StartTD__QL.Click += new System.EventHandler(this.btn_StartTD__QL_Click);
            // 
            // btn_Start_TD_Sarsa
            // 
            this.btn_Start_TD_Sarsa.Location = new System.Drawing.Point(21, 68);
            this.btn_Start_TD_Sarsa.Name = "btn_Start_TD_Sarsa";
            this.btn_Start_TD_Sarsa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Start_TD_Sarsa.Size = new System.Drawing.Size(96, 23);
            this.btn_Start_TD_Sarsa.TabIndex = 7;
            this.btn_Start_TD_Sarsa.Text = "TD SARSA";
            this.btn_Start_TD_Sarsa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Start_TD_Sarsa.UseVisualStyleBackColor = true;
            this.btn_Start_TD_Sarsa.Click += new System.EventHandler(this.btn_Start_TD_Sarsa_Click);
            // 
            // groupBox_Results
            // 
            this.groupBox_Results.Controls.Add(this.btn_Results);
            this.groupBox_Results.Controls.Add(this.btn_Export_Data);
            this.groupBox_Results.Location = new System.Drawing.Point(12, 496);
            this.groupBox_Results.Name = "groupBox_Results";
            this.groupBox_Results.Size = new System.Drawing.Size(148, 131);
            this.groupBox_Results.TabIndex = 20;
            this.groupBox_Results.TabStop = false;
            this.groupBox_Results.Text = "Results";
            // 
            // btn_Results
            // 
            this.btn_Results.Location = new System.Drawing.Point(21, 44);
            this.btn_Results.Name = "btn_Results";
            this.btn_Results.Size = new System.Drawing.Size(96, 23);
            this.btn_Results.TabIndex = 9;
            this.btn_Results.Text = "Show Results";
            this.btn_Results.UseVisualStyleBackColor = true;
            this.btn_Results.Click += new System.EventHandler(this.btn_Results_Click);
            // 
            // btn_Export_Data
            // 
            this.btn_Export_Data.Location = new System.Drawing.Point(21, 94);
            this.btn_Export_Data.Name = "btn_Export_Data";
            this.btn_Export_Data.Size = new System.Drawing.Size(96, 23);
            this.btn_Export_Data.TabIndex = 10;
            this.btn_Export_Data.Text = "Export Data";
            this.btn_Export_Data.UseVisualStyleBackColor = true;
            this.btn_Export_Data.Click += new System.EventHandler(this.btn_Export_Data_Click);
            // 
            // groupBox_GridSettings
            // 
            this.groupBox_GridSettings.Controls.Add(this.btn_AcceptGridProperties);
            this.groupBox_GridSettings.Controls.Add(this.txtGoalPoint);
            this.groupBox_GridSettings.Controls.Add(this.txtStartPoint);
            this.groupBox_GridSettings.Controls.Add(this.label4);
            this.groupBox_GridSettings.Controls.Add(this.label3);
            this.groupBox_GridSettings.Controls.Add(this.label2);
            this.groupBox_GridSettings.Controls.Add(this.label1);
            this.groupBox_GridSettings.Controls.Add(this.txtGridCols);
            this.groupBox_GridSettings.Controls.Add(this.txtGridRows);
            this.groupBox_GridSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_GridSettings.Name = "groupBox_GridSettings";
            this.groupBox_GridSettings.Size = new System.Drawing.Size(148, 186);
            this.groupBox_GridSettings.TabIndex = 18;
            this.groupBox_GridSettings.TabStop = false;
            this.groupBox_GridSettings.Text = "Settings of Windy-Grid  ";
            // 
            // btn_AcceptGridProperties
            // 
            this.btn_AcceptGridProperties.Location = new System.Drawing.Point(21, 145);
            this.btn_AcceptGridProperties.Name = "btn_AcceptGridProperties";
            this.btn_AcceptGridProperties.Size = new System.Drawing.Size(96, 23);
            this.btn_AcceptGridProperties.TabIndex = 4;
            this.btn_AcceptGridProperties.Text = "Accept";
            this.btn_AcceptGridProperties.UseVisualStyleBackColor = true;
            this.btn_AcceptGridProperties.Click += new System.EventHandler(this.btn_AcceptGridProperties_Click);
            // 
            // txtGoalPoint
            // 
            this.txtGoalPoint.Location = new System.Drawing.Point(87, 108);
            this.txtGoalPoint.Name = "txtGoalPoint";
            this.txtGoalPoint.ReadOnly = true;
            this.txtGoalPoint.Size = new System.Drawing.Size(51, 20);
            this.txtGoalPoint.TabIndex = 0;
            this.txtGoalPoint.TabStop = false;
            this.txtGoalPoint.Click += new System.EventHandler(this.txtGoalPoint_Click);
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Location = new System.Drawing.Point(87, 83);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.ReadOnly = true;
            this.txtStartPoint.Size = new System.Drawing.Size(51, 20);
            this.txtStartPoint.TabIndex = 0;
            this.txtStartPoint.TabStop = false;
            this.txtStartPoint.Click += new System.EventHandler(this.txtStartPoint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Goal Point:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start Point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Columns:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rows:";
            // 
            // txtGridCols
            // 
            this.txtGridCols.Location = new System.Drawing.Point(87, 54);
            this.txtGridCols.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtGridCols.Name = "txtGridCols";
            this.txtGridCols.Size = new System.Drawing.Size(51, 20);
            this.txtGridCols.TabIndex = 2;
            this.txtGridCols.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtGridCols.ValueChanged += new System.EventHandler(this.txtGridCols_ValueChanged);
            // 
            // txtGridRows
            // 
            this.txtGridRows.Location = new System.Drawing.Point(87, 29);
            this.txtGridRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtGridRows.Name = "txtGridRows";
            this.txtGridRows.Size = new System.Drawing.Size(51, 20);
            this.txtGridRows.TabIndex = 1;
            this.txtGridRows.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txtGridRows.ValueChanged += new System.EventHandler(this.txtGridRows_ValueChanged);
            // 
            // _panel_Controls
            // 
            this._panel_Controls.Controls.Add(this.groupBox_Settings);
            this._panel_Controls.Controls.Add(this.groupBox_Results);
            this._panel_Controls.Controls.Add(this.groupBox_GridSettings);
            this._panel_Controls.Controls.Add(this.groupBox_Operation);
            this._panel_Controls.Dock = System.Windows.Forms.DockStyle.Left;
            this._panel_Controls.Location = new System.Drawing.Point(0, 0);
            this._panel_Controls.Name = "_panel_Controls";
            this._panel_Controls.Size = new System.Drawing.Size(168, 640);
            this._panel_Controls.TabIndex = 19;
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.btn_AlgrorithmSetting);
            this.groupBox_Settings.Controls.Add(this.btn_AnimSettinsa);
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 204);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(148, 126);
            this.groupBox_Settings.TabIndex = 23;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // btn_AlgrorithmSetting
            // 
            this.btn_AlgrorithmSetting.Location = new System.Drawing.Point(21, 31);
            this.btn_AlgrorithmSetting.Name = "btn_AlgrorithmSetting";
            this.btn_AlgrorithmSetting.Size = new System.Drawing.Size(96, 23);
            this.btn_AlgrorithmSetting.TabIndex = 5;
            this.btn_AlgrorithmSetting.Text = "Algorithms";
            this.btn_AlgrorithmSetting.UseVisualStyleBackColor = true;
            this.btn_AlgrorithmSetting.Click += new System.EventHandler(this.btn_AlgrorithmSetting_Click);
            // 
            // btn_AnimSettinsa
            // 
            this.btn_AnimSettinsa.Location = new System.Drawing.Point(21, 75);
            this.btn_AnimSettinsa.Name = "btn_AnimSettinsa";
            this.btn_AnimSettinsa.Size = new System.Drawing.Size(96, 23);
            this.btn_AnimSettinsa.TabIndex = 5;
            this.btn_AnimSettinsa.Text = "Animation";
            this.btn_AnimSettinsa.UseVisualStyleBackColor = true;
            this.btn_AnimSettinsa.Click += new System.EventHandler(this.btn_AnimSettinsa_Click);
            // 
            // lbl_Left
            // 
            this.lbl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Left.Location = new System.Drawing.Point(0, 0);
            this.lbl_Left.Name = "lbl_Left";
            this.lbl_Left.Size = new System.Drawing.Size(32, 352);
            this.lbl_Left.TabIndex = 9;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(273, 375);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(35, 13);
            this.lblWind.TabIndex = 8;
            this.lblWind.Text = "Wind:";
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(323, 372);
            this.txtWind.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(46, 20);
            this.txtWind.TabIndex = 0;
            this.txtWind.TabStop = false;
            this.txtWind.Visible = false;
            this.txtWind.ValueChanged += new System.EventHandler(this.txtWind_ValueChanged);
            this.txtWind.VisibleChanged += new System.EventHandler(this.txtWind_VisibleChanged);
            this.txtWind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWind_KeyUp);
            this.txtWind.Leave += new System.EventHandler(this.txtWind_Leave);
            // 
            // _panel_WindyGrid
            // 
            this._panel_WindyGrid.Controls.Add(this.lbl_Left);
            this._panel_WindyGrid.Controls.Add(this.dgGrid);
            this._panel_WindyGrid.Location = new System.Drawing.Point(273, 12);
            this._panel_WindyGrid.Name = "_panel_WindyGrid";
            this._panel_WindyGrid.Size = new System.Drawing.Size(581, 352);
            this._panel_WindyGrid.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Episode:";
            // 
            // lblEpisodeLength
            // 
            this.lblEpisodeLength.Location = new System.Drawing.Point(397, 122);
            this.lblEpisodeLength.Name = "lblEpisodeLength";
            this.lblEpisodeLength.Size = new System.Drawing.Size(64, 13);
            this.lblEpisodeLength.TabIndex = 18;
            this.lblEpisodeLength.Text = "0";
            // 
            // lblEpisode_ALL
            // 
            this.lblEpisode_ALL.AutoSize = true;
            this.lblEpisode_ALL.Location = new System.Drawing.Point(74, 123);
            this.lblEpisode_ALL.Name = "lblEpisode_ALL";
            this.lblEpisode_ALL.Size = new System.Drawing.Size(13, 13);
            this.lblEpisode_ALL.TabIndex = 18;
            this.lblEpisode_ALL.Text = "0";
            // 
            // prgrssBar_All
            // 
            this.prgrssBar_All.Location = new System.Drawing.Point(23, 150);
            this.prgrssBar_All.Name = "prgrssBar_All";
            this.prgrssBar_All.Size = new System.Drawing.Size(564, 15);
            this.prgrssBar_All.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(316, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Episode Length:";
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.Location = new System.Drawing.Point(24, 27);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(44, 13);
            this.lblCurrentOperation.TabIndex = 18;
            this.lblCurrentOperation.Text = "Nothing";
            // 
            // prgrssBar_EpisodeLength
            // 
            this.prgrssBar_EpisodeLength.Location = new System.Drawing.Point(463, 123);
            this.prgrssBar_EpisodeLength.Name = "prgrssBar_EpisodeLength";
            this.prgrssBar_EpisodeLength.Size = new System.Drawing.Size(124, 12);
            this.prgrssBar_EpisodeLength.TabIndex = 19;
            this.prgrssBar_EpisodeLength.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_M2);
            this.groupBox1.Controls.Add(this.lbl_M1);
            this.groupBox1.Controls.Add(this.lbl_Algorithm_Parameters);
            this.groupBox1.Controls.Add(this.prgrssBar_EpisodeLength);
            this.groupBox1.Controls.Add(this.lblCurrentOperation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.prgrssBar_All);
            this.groupBox1.Controls.Add(this.lblEpisode_ALL);
            this.groupBox1.Controls.Add(this.lblEpisodeLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(168, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 178);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Operation";
            // 
            // lbl_M2
            // 
            this.lbl_M2.AutoSize = true;
            this.lbl_M2.Location = new System.Drawing.Point(276, 45);
            this.lbl_M2.Name = "lbl_M2";
            this.lbl_M2.Size = new System.Drawing.Size(290, 13);
            this.lbl_M2.TabIndex = 24;
            this.lbl_M2.Text = "Please don\'t click on the Window, while algorithm is working";
            // 
            // lbl_M1
            // 
            this.lbl_M1.AutoSize = true;
            this.lbl_M1.Location = new System.Drawing.Point(276, 27);
            this.lbl_M1.Name = "lbl_M1";
            this.lbl_M1.Size = new System.Drawing.Size(311, 13);
            this.lbl_M1.TabIndex = 24;
            this.lbl_M1.Text = "If the Animation stops to work, it is doing the work in background";
            // 
            // lbl_Algorithm_Parameters
            // 
            this.lbl_Algorithm_Parameters.AutoSize = true;
            this.lbl_Algorithm_Parameters.Location = new System.Drawing.Point(23, 47);
            this.lbl_Algorithm_Parameters.Name = "lbl_Algorithm_Parameters";
            this.lbl_Algorithm_Parameters.Size = new System.Drawing.Size(66, 13);
            this.lbl_Algorithm_Parameters.TabIndex = 23;
            this.lbl_Algorithm_Parameters.Text = "Parameterts:";
            // 
            // _frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this._panel_Controls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this._panel_WindyGrid);
            this.Controls.Add(this.dgWind);
            this.Name = "_frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windy Grid World";
            this.mnu_Context_StartGoal.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWind)).EndInit();
            this.groupBox_Operation.ResumeLayout(false);
            this.groupBox_Results.ResumeLayout(false);
            this.groupBox_GridSettings.ResumeLayout(false);
            this.groupBox_GridSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGridCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGridRows)).EndInit();
            this._panel_Controls.ResumeLayout(false);
            this.groupBox_Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtWind)).EndInit();
            this._panel_WindyGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnu_Context_StartGoal;
        private System.Windows.Forms.ToolStripMenuItem mnu_SetStartHere;
        private System.Windows.Forms.ToolStripMenuItem mnu_SetGoalHere;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus_Help;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusPosition;
        private System.Windows.Forms.DataGridView dgWind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.GroupBox groupBox_GridSettings;
        private System.Windows.Forms.TextBox txtGoalPoint;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtGridCols;
        private System.Windows.Forms.NumericUpDown txtGridRows;
        private System.Windows.Forms.Button btn_Start_MC;
        private System.Windows.Forms.Button btn_Start_TD_Sarsa;
        private System.Windows.Forms.Button btn_StartTD__QL;
        private System.Windows.Forms.Panel _panel_Controls;
        private System.Windows.Forms.Button btn_AcceptGridProperties;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem btn_RestartProg;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Left;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.NumericUpDown txtWind;
        private System.Windows.Forms.Panel _panel_WindyGrid;
        private System.Windows.Forms.GroupBox groupBox_Results;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgGrid;
        private System.Windows.Forms.Button btn_Export_Data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEpisodeLength;
        private System.Windows.Forms.Label lblEpisode_ALL;
        private System.Windows.Forms.ProgressBar prgrssBar_All;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCurrentOperation;
        private System.Windows.Forms.ProgressBar prgrssBar_EpisodeLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Results;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.Button btn_AnimSettinsa;
        private System.Windows.Forms.Label lbl_Algorithm_Parameters;
        private System.Windows.Forms.Label lbl_M1;
        private System.Windows.Forms.Label lbl_M2;
        private System.Windows.Forms.Button btn_AlgrorithmSetting;
    }
}

