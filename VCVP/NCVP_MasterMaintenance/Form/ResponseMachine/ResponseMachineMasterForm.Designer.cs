namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance
{
    partial class ResponseMachineMasterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RespMachine_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_prodution_work_content_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prodution_work_content_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.machinename_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machinename_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            ((System.ComponentModel.ISupportInitialize)(this.RespMachine_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // RespMachine_dgv
            // 
            this.RespMachine_dgv.AllowUserToAddRows = false;
            this.RespMachine_dgv.AllowUserToDeleteRows = false;
            this.RespMachine_dgv.AllowUserToOrderColumns = true;
            this.RespMachine_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RespMachine_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RespMachine_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RespMachine_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.col_prodution_work_content_cd,
            this.col_prodution_work_content_name});
            this.RespMachine_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RespMachine_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.RespMachine_dgv.EnableHeadersVisualStyles = false;
            this.RespMachine_dgv.Location = new System.Drawing.Point(6, 176);
            this.RespMachine_dgv.MultiSelect = false;
            this.RespMachine_dgv.Name = "RespMachine_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RespMachine_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RespMachine_dgv.RowHeadersVisible = false;
            this.RespMachine_dgv.RowTemplate.Height = 21;
            this.RespMachine_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RespMachine_dgv.Size = new System.Drawing.Size(677, 326);
            this.RespMachine_dgv.TabIndex = 54;
            this.RespMachine_dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.RespMachine_dgv_CellBeginEdit);
            // 
            // colSelect
            // 
            this.colSelect.DataPropertyName = "Selected";
            this.colSelect.HeaderText = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_prodution_work_content_cd
            // 
            this.col_prodution_work_content_cd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_prodution_work_content_cd.DataPropertyName = "ProdWorkContCode";
            this.col_prodution_work_content_cd.HeaderText = "ProdWorkContCode";
            this.col_prodution_work_content_cd.Name = "col_prodution_work_content_cd";
            this.col_prodution_work_content_cd.ReadOnly = true;
            this.col_prodution_work_content_cd.Width = 142;
            // 
            // col_prodution_work_content_name
            // 
            this.col_prodution_work_content_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_prodution_work_content_name.DataPropertyName = "ProdWorkContName";
            this.col_prodution_work_content_name.HeaderText = "ProdWorkContName";
            this.col_prodution_work_content_name.Name = "col_prodution_work_content_name";
            this.col_prodution_work_content_name.ReadOnly = true;
            this.col_prodution_work_content_name.Width = 146;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Update_btn.ControlId = null;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Update_btn.Location = new System.Drawing.Point(404, 122);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(80, 33);
            this.Update_btn.TabIndex = 53;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // machinename_cmb
            // 
            this.machinename_cmb.ControlId = null;
            this.machinename_cmb.Font = new System.Drawing.Font("Arial", 9F);
            this.machinename_cmb.FormattingEnabled = true;
            this.machinename_cmb.Location = new System.Drawing.Point(112, 128);
            this.machinename_cmb.Name = "machinename_cmb";
            this.machinename_cmb.Size = new System.Drawing.Size(187, 23);
            this.machinename_cmb.TabIndex = 52;
            this.machinename_cmb.SelectedIndexChanged += new System.EventHandler(this.machinename_cmb_SelectedIndexChanged);
            // 
            // machinename_lbl
            // 
            this.machinename_lbl.AutoSize = true;
            this.machinename_lbl.ControlId = null;
            this.machinename_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machinename_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machinename_lbl.Location = new System.Drawing.Point(13, 131);
            this.machinename_lbl.Name = "machinename_lbl";
            this.machinename_lbl.Size = new System.Drawing.Size(93, 15);
            this.machinename_lbl.TabIndex = 51;
            this.machinename_lbl.Text = "Machine Name:";
            // 
            // ResponseMachineMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 507);
            this.Controls.Add(this.RespMachine_dgv);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.machinename_cmb);
            this.Controls.Add(this.machinename_lbl);
            this.Name = "ResponseMachineMasterForm";
            this.Text = "Response Machine List";
            this.Load += new System.EventHandler(this.ResponseMachineMasterForm_Load);
            this.Controls.SetChildIndex(this.machinename_lbl, 0);
            this.Controls.SetChildIndex(this.machinename_cmb, 0);
            this.Controls.SetChildIndex(this.Update_btn, 0);
            this.Controls.SetChildIndex(this.RespMachine_dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RespMachine_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Framework.DataGridViewCommon RespMachine_dgv;
        private Framework.ButtonCommon Update_btn;
        private Framework.ComboBoxCommon machinename_cmb;
        private Framework.LabelCommon machinename_lbl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prodution_work_content_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prodution_work_content_name;
    }
}
