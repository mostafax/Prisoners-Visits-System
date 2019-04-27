namespace DB
{
    partial class visitSelection
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
            this.visit_ids = new System.Windows.Forms.Label();
            this.visit_name = new System.Windows.Forms.Label();
            this.VisitIDS = new System.Windows.Forms.ComboBox();
            this.all_visit_data = new System.Windows.Forms.Label();
            this.visit_data_gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.visit_data_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visit_ids
            // 
            this.visit_ids.AutoSize = true;
            this.visit_ids.Location = new System.Drawing.Point(141, 48);
            this.visit_ids.Name = "visit_ids";
            this.visit_ids.Size = new System.Drawing.Size(58, 17);
            this.visit_ids.TabIndex = 0;
            this.visit_ids.Text = "Visit IDs";
            // 
            // visit_name
            // 
            this.visit_name.AutoSize = true;
            this.visit_name.Location = new System.Drawing.Point(531, 48);
            this.visit_name.Name = "visit_name";
            this.visit_name.Size = new System.Drawing.Size(63, 17);
            this.visit_name.TabIndex = 1;
            this.visit_name.Text = "Visit Day";
            // 
            // VisitIDS
            // 
            this.VisitIDS.FormattingEnabled = true;
            this.VisitIDS.Location = new System.Drawing.Point(308, 43);
            this.VisitIDS.Name = "VisitIDS";
            this.VisitIDS.Size = new System.Drawing.Size(129, 24);
            this.VisitIDS.TabIndex = 2;
            this.VisitIDS.SelectedIndexChanged += new System.EventHandler(this.VisitIDS_SelectedIndexChanged);
            // 
            // all_visit_data
            // 
            this.all_visit_data.AutoSize = true;
            this.all_visit_data.Location = new System.Drawing.Point(29, 296);
            this.all_visit_data.Name = "all_visit_data";
            this.all_visit_data.Size = new System.Drawing.Size(87, 17);
            this.all_visit_data.TabIndex = 3;
            this.all_visit_data.Text = "All Visit Data";
            // 
            // visit_data_gridView
            // 
            this.visit_data_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visit_data_gridView.Location = new System.Drawing.Point(144, 226);
            this.visit_data_gridView.Name = "visit_data_gridView";
            this.visit_data_gridView.RowTemplate.Height = 24;
            this.visit_data_gridView.Size = new System.Drawing.Size(595, 194);
            this.visit_data_gridView.TabIndex = 4;
            // 
            // VisitSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visit_data_gridView);
            this.Controls.Add(this.all_visit_data);
            this.Controls.Add(this.VisitIDS);
            this.Controls.Add(this.visit_name);
            this.Controls.Add(this.visit_ids);
            this.Name = "VisitSelection";
            this.Text = "VisitSelection";
            this.Load += new System.EventHandler(this.VisitSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visit_data_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label visit_ids;
        private System.Windows.Forms.Label visit_name;
        private System.Windows.Forms.ComboBox VisitIDS;
        private System.Windows.Forms.Label all_visit_data;
        private System.Windows.Forms.DataGridView visit_data_gridView;
    }
}