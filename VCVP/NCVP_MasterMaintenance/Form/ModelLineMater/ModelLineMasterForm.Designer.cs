﻿namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance
{
    partial class ModelLineMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelLineMasterForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.modelname_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.modelname_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.Model_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Model_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Update_btn.ControlId = null;
            resources.ApplyResources(this.Update_btn, "Update_btn");
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // modelname_cmb
            // 
            this.modelname_cmb.ControlId = null;
            resources.ApplyResources(this.modelname_cmb, "modelname_cmb");
            this.modelname_cmb.FormattingEnabled = true;
            this.modelname_cmb.Name = "modelname_cmb";
            this.modelname_cmb.SelectedIndexChanged += new System.EventHandler(this.modelname_cmb_SelectedIndexChanged);
            // 
            // modelname_lbl
            // 
            resources.ApplyResources(this.modelname_lbl, "modelname_lbl");
            this.modelname_lbl.ControlId = null;
            this.modelname_lbl.Name = "modelname_lbl";
            this.modelname_lbl.Click += new System.EventHandler(this.modelname_lbl_Click);
            // 
            // Model_dgv
            // 
            this.Model_dgv.AllowUserToAddRows = false;
            this.Model_dgv.AllowUserToDeleteRows = false;
            this.Model_dgv.AllowUserToOrderColumns = true;
            this.Model_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Model_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Model_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Model_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colLineID,
            this.ColLineName});
            this.Model_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Model_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Model_dgv.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.Model_dgv, "Model_dgv");
            this.Model_dgv.MultiSelect = false;
            this.Model_dgv.Name = "Model_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Model_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Model_dgv.RowHeadersVisible = false;
            this.Model_dgv.RowTemplate.Height = 21;
            this.Model_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Model_dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Model_dgv_CellBeginEdit);
            this.Model_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Model_dgv_CellContentClick);
            // 
            // colSelected
            // 
            this.colSelected.DataPropertyName = "Selected";
            resources.ApplyResources(this.colSelected, "colSelected");
            this.colSelected.Name = "colSelected";
            // 
            // colLineID
            // 
            this.colLineID.DataPropertyName = "LineCode";
            resources.ApplyResources(this.colLineID, "colLineID");
            this.colLineID.Name = "colLineID";
            this.colLineID.ReadOnly = true;
            // 
            // ColLineName
            // 
            this.ColLineName.DataPropertyName = "LineName";
            resources.ApplyResources(this.ColLineName, "ColLineName");
            this.ColLineName.Name = "ColLineName";
            this.ColLineName.ReadOnly = true;
            // 
            // ModelLineMasterForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Model_dgv);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.modelname_cmb);
            this.Controls.Add(this.modelname_lbl);
            this.Name = "ModelLineMasterForm";
            this.Load += new System.EventHandler(this.ModelLineMasterForm_Load);
            this.Controls.SetChildIndex(this.modelname_lbl, 0);
            this.Controls.SetChildIndex(this.modelname_cmb, 0);
            this.Controls.SetChildIndex(this.Update_btn, 0);
            this.Controls.SetChildIndex(this.Model_dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Model_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.ButtonCommon Update_btn;
        private Framework.ComboBoxCommon modelname_cmb;
        private Framework.LabelCommon modelname_lbl;
        internal Framework.DataGridViewCommon Model_dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLineName;
    }
}
