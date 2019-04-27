namespace WindowsFormsApp1
{
    partial class visitFunction
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
            this.add_visit = new System.Windows.Forms.Button();
            this.delete_visit = new System.Windows.Forms.Button();
            this.update_visit = new System.Windows.Forms.Button();
            this.prisoner_ids = new System.Windows.Forms.ListBox();
            this.visitor_ids = new System.Windows.Forms.ListBox();
            this.prison_ids = new System.Windows.Forms.ListBox();
            this.policemen_ids = new System.Windows.Forms.ListBox();
            this.visitIDS = new System.Windows.Forms.ComboBox();
            this.visit_day_date = new System.Windows.Forms.TextBox();
            this.visit_start_time = new System.Windows.Forms.TextBox();
            this.visit_end_time = new System.Windows.Forms.TextBox();
            this.prisoner_id = new System.Windows.Forms.TextBox();
            this.visitor_id = new System.Windows.Forms.TextBox();
            this.prison_id = new System.Windows.Forms.TextBox();
            this.policeman_id = new System.Windows.Forms.TextBox();
            this.Visit_ID = new System.Windows.Forms.Label();
            this.VISIT_DAY = new System.Windows.Forms.Label();
            this.START_TIME = new System.Windows.Forms.Label();
            this.END_TIME = new System.Windows.Forms.Label();
            this.pr_id = new System.Windows.Forms.Label();
            this.vi_rd = new System.Windows.Forms.Label();
            this.pr__id = new System.Windows.Forms.Label();
            this.po_id = new System.Windows.Forms.Label();
            this.THE_PRISONERS = new System.Windows.Forms.Label();
            this.THE_VISITORS = new System.Windows.Forms.Label();
            this.THE_PRISONS = new System.Windows.Forms.Label();
            this.THE_POLICEMEN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_visit
            // 
            this.add_visit.Location = new System.Drawing.Point(114, 373);
            this.add_visit.Name = "add_visit";
            this.add_visit.Size = new System.Drawing.Size(76, 30);
            this.add_visit.TabIndex = 0;
            this.add_visit.Text = "Add";
            this.add_visit.UseVisualStyleBackColor = true;
            this.add_visit.Click += new System.EventHandler(this.add_visit_Click);
            // 
            // delete_visit
            // 
            this.delete_visit.Location = new System.Drawing.Point(575, 373);
            this.delete_visit.Name = "delete_visit";
            this.delete_visit.Size = new System.Drawing.Size(76, 30);
            this.delete_visit.TabIndex = 1;
            this.delete_visit.Text = "Delete";
            this.delete_visit.UseVisualStyleBackColor = true;
            this.delete_visit.Click += new System.EventHandler(this.delete_visit_Click);
            // 
            // update_visit
            // 
            this.update_visit.Location = new System.Drawing.Point(339, 373);
            this.update_visit.Name = "update_visit";
            this.update_visit.Size = new System.Drawing.Size(76, 30);
            this.update_visit.TabIndex = 2;
            this.update_visit.Text = "Update";
            this.update_visit.UseVisualStyleBackColor = true;
            this.update_visit.Click += new System.EventHandler(this.update_visit_Click);
            // 
            // prisoner_ids
            // 
            this.prisoner_ids.FormattingEnabled = true;
            this.prisoner_ids.ItemHeight = 16;
            this.prisoner_ids.Location = new System.Drawing.Point(701, 31);
            this.prisoner_ids.Name = "prisoner_ids";
            this.prisoner_ids.Size = new System.Drawing.Size(62, 52);
            this.prisoner_ids.TabIndex = 3;
            // 
            // visitor_ids
            // 
            this.visitor_ids.FormattingEnabled = true;
            this.visitor_ids.ItemHeight = 16;
            this.visitor_ids.Location = new System.Drawing.Point(589, 110);
            this.visitor_ids.Name = "visitor_ids";
            this.visitor_ids.Size = new System.Drawing.Size(62, 52);
            this.visitor_ids.TabIndex = 4;
            // 
            // prison_ids
            // 
            this.prison_ids.FormattingEnabled = true;
            this.prison_ids.ItemHeight = 16;
            this.prison_ids.Location = new System.Drawing.Point(701, 166);
            this.prison_ids.Name = "prison_ids";
            this.prison_ids.Size = new System.Drawing.Size(62, 52);
            this.prison_ids.TabIndex = 5;
            // 
            // policemen_ids
            // 
            this.policemen_ids.FormattingEnabled = true;
            this.policemen_ids.ItemHeight = 16;
            this.policemen_ids.Location = new System.Drawing.Point(589, 241);
            this.policemen_ids.Name = "policemen_ids";
            this.policemen_ids.Size = new System.Drawing.Size(62, 52);
            this.policemen_ids.TabIndex = 6;
            this.policemen_ids.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // visitIDS
            // 
            this.visitIDS.FormattingEnabled = true;
            this.visitIDS.Location = new System.Drawing.Point(69, 31);
            this.visitIDS.Name = "visitIDS";
            this.visitIDS.Size = new System.Drawing.Size(121, 24);
            this.visitIDS.TabIndex = 7;
            this.visitIDS.SelectedIndexChanged += new System.EventHandler(this.visitIDS_SelectedIndexChanged);
            // 
            // visit_day_date
            // 
            this.visit_day_date.Location = new System.Drawing.Point(81, 110);
            this.visit_day_date.Name = "visit_day_date";
            this.visit_day_date.Size = new System.Drawing.Size(100, 22);
            this.visit_day_date.TabIndex = 8;
            // 
            // visit_start_time
            // 
            this.visit_start_time.Location = new System.Drawing.Point(81, 178);
            this.visit_start_time.Name = "visit_start_time";
            this.visit_start_time.Size = new System.Drawing.Size(100, 22);
            this.visit_start_time.TabIndex = 9;
            this.visit_start_time.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // visit_end_time
            // 
            this.visit_end_time.Location = new System.Drawing.Point(81, 254);
            this.visit_end_time.Name = "visit_end_time";
            this.visit_end_time.Size = new System.Drawing.Size(100, 22);
            this.visit_end_time.TabIndex = 10;
            // 
            // prisoner_id
            // 
            this.prisoner_id.Location = new System.Drawing.Point(350, 33);
            this.prisoner_id.Name = "prisoner_id";
            this.prisoner_id.Size = new System.Drawing.Size(100, 22);
            this.prisoner_id.TabIndex = 11;
            this.prisoner_id.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // visitor_id
            // 
            this.visitor_id.Location = new System.Drawing.Point(350, 113);
            this.visitor_id.Name = "visitor_id";
            this.visitor_id.Size = new System.Drawing.Size(100, 22);
            this.visitor_id.TabIndex = 12;
            // 
            // prison_id
            // 
            this.prison_id.Location = new System.Drawing.Point(350, 178);
            this.prison_id.Name = "prison_id";
            this.prison_id.Size = new System.Drawing.Size(100, 22);
            this.prison_id.TabIndex = 13;
            // 
            // policeman_id
            // 
            this.policeman_id.Location = new System.Drawing.Point(350, 254);
            this.policeman_id.Name = "policeman_id";
            this.policeman_id.Size = new System.Drawing.Size(100, 22);
            this.policeman_id.TabIndex = 14;
            // 
            // Visit_ID
            // 
            this.Visit_ID.AutoSize = true;
            this.Visit_ID.Location = new System.Drawing.Point(12, 38);
            this.Visit_ID.Name = "Visit_ID";
            this.Visit_ID.Size = new System.Drawing.Size(51, 17);
            this.Visit_ID.TabIndex = 15;
            this.Visit_ID.Text = "Visit ID";
            this.Visit_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // VISIT_DAY
            // 
            this.VISIT_DAY.AutoSize = true;
            this.VISIT_DAY.Location = new System.Drawing.Point(12, 113);
            this.VISIT_DAY.Name = "VISIT_DAY";
            this.VISIT_DAY.Size = new System.Drawing.Size(63, 17);
            this.VISIT_DAY.TabIndex = 16;
            this.VISIT_DAY.Text = "Visit Day";
            // 
            // START_TIME
            // 
            this.START_TIME.AutoSize = true;
            this.START_TIME.Location = new System.Drawing.Point(7, 178);
            this.START_TIME.Name = "START_TIME";
            this.START_TIME.Size = new System.Drawing.Size(73, 17);
            this.START_TIME.TabIndex = 17;
            this.START_TIME.Text = "Start Time";
            // 
            // END_TIME
            // 
            this.END_TIME.AutoSize = true;
            this.END_TIME.Location = new System.Drawing.Point(12, 259);
            this.END_TIME.Name = "END_TIME";
            this.END_TIME.Size = new System.Drawing.Size(68, 17);
            this.END_TIME.TabIndex = 18;
            this.END_TIME.Text = "End Time";
            // 
            // pr_id
            // 
            this.pr_id.AutoSize = true;
            this.pr_id.Location = new System.Drawing.Point(222, 38);
            this.pr_id.Name = "pr_id";
            this.pr_id.Size = new System.Drawing.Size(78, 17);
            this.pr_id.TabIndex = 19;
            this.pr_id.Text = "Prisoner ID";
            // 
            // vi_rd
            // 
            this.vi_rd.AutoSize = true;
            this.vi_rd.Location = new System.Drawing.Point(238, 113);
            this.vi_rd.Name = "vi_rd";
            this.vi_rd.Size = new System.Drawing.Size(64, 17);
            this.vi_rd.TabIndex = 20;
            this.vi_rd.Text = "Visitor ID";
            // 
            // pr__id
            // 
            this.pr__id.AutoSize = true;
            this.pr__id.Location = new System.Drawing.Point(234, 183);
            this.pr__id.Name = "pr__id";
            this.pr__id.Size = new System.Drawing.Size(65, 17);
            this.pr__id.TabIndex = 21;
            this.pr__id.Text = "Prison ID";
            // 
            // po_id
            // 
            this.po_id.AutoSize = true;
            this.po_id.Location = new System.Drawing.Point(222, 257);
            this.po_id.Name = "po_id";
            this.po_id.Size = new System.Drawing.Size(90, 17);
            this.po_id.TabIndex = 22;
            this.po_id.Text = "Policeman ID";
            // 
            // THE_PRISONERS
            // 
            this.THE_PRISONERS.AutoSize = true;
            this.THE_PRISONERS.Location = new System.Drawing.Point(687, 9);
            this.THE_PRISONERS.Name = "THE_PRISONERS";
            this.THE_PRISONERS.Size = new System.Drawing.Size(87, 17);
            this.THE_PRISONERS.TabIndex = 23;
            this.THE_PRISONERS.Text = "Prisoner IDS";
            // 
            // THE_VISITORS
            // 
            this.THE_VISITORS.AutoSize = true;
            this.THE_VISITORS.Location = new System.Drawing.Point(586, 81);
            this.THE_VISITORS.Name = "THE_VISITORS";
            this.THE_VISITORS.Size = new System.Drawing.Size(73, 17);
            this.THE_VISITORS.TabIndex = 24;
            this.THE_VISITORS.Text = "Visitor IDS";
            // 
            // THE_PRISONS
            // 
            this.THE_PRISONS.AutoSize = true;
            this.THE_PRISONS.Location = new System.Drawing.Point(698, 135);
            this.THE_PRISONS.Name = "THE_PRISONS";
            this.THE_PRISONS.Size = new System.Drawing.Size(74, 17);
            this.THE_PRISONS.TabIndex = 25;
            this.THE_PRISONS.Text = "Prison IDS";
            // 
            // THE_POLICEMEN
            // 
            this.THE_POLICEMEN.AutoSize = true;
            this.THE_POLICEMEN.Location = new System.Drawing.Point(572, 212);
            this.THE_POLICEMEN.Name = "THE_POLICEMEN";
            this.THE_POLICEMEN.Size = new System.Drawing.Size(99, 17);
            this.THE_POLICEMEN.TabIndex = 26;
            this.THE_POLICEMEN.Text = "Policemen IDS";
            // 
            // visitFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.THE_POLICEMEN);
            this.Controls.Add(this.THE_PRISONS);
            this.Controls.Add(this.THE_VISITORS);
            this.Controls.Add(this.THE_PRISONERS);
            this.Controls.Add(this.po_id);
            this.Controls.Add(this.pr__id);
            this.Controls.Add(this.vi_rd);
            this.Controls.Add(this.pr_id);
            this.Controls.Add(this.END_TIME);
            this.Controls.Add(this.START_TIME);
            this.Controls.Add(this.VISIT_DAY);
            this.Controls.Add(this.Visit_ID);
            this.Controls.Add(this.policeman_id);
            this.Controls.Add(this.prison_id);
            this.Controls.Add(this.visitor_id);
            this.Controls.Add(this.prisoner_id);
            this.Controls.Add(this.visit_end_time);
            this.Controls.Add(this.visit_start_time);
            this.Controls.Add(this.visit_day_date);
            this.Controls.Add(this.visitIDS);
            this.Controls.Add(this.policemen_ids);
            this.Controls.Add(this.prison_ids);
            this.Controls.Add(this.visitor_ids);
            this.Controls.Add(this.prisoner_ids);
            this.Controls.Add(this.update_visit);
            this.Controls.Add(this.delete_visit);
            this.Controls.Add(this.add_visit);
            this.Name = "visitFunction";
            this.Text = "visitFunction";
            this.Load += new System.EventHandler(this.visitFunction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_visit;
        private System.Windows.Forms.Button delete_visit;
        private System.Windows.Forms.Button update_visit;
        private System.Windows.Forms.ListBox prisoner_ids;
        private System.Windows.Forms.ListBox visitor_ids;
        private System.Windows.Forms.ListBox prison_ids;
        private System.Windows.Forms.ListBox policemen_ids;
        private System.Windows.Forms.ComboBox visitIDS;
        private System.Windows.Forms.TextBox visit_day_date;
        private System.Windows.Forms.TextBox visit_start_time;
        private System.Windows.Forms.TextBox visit_end_time;
        private System.Windows.Forms.TextBox prisoner_id;
        private System.Windows.Forms.TextBox visitor_id;
        private System.Windows.Forms.TextBox prison_id;
        private System.Windows.Forms.TextBox policeman_id;
        private System.Windows.Forms.Label Visit_ID;
        private System.Windows.Forms.Label VISIT_DAY;
        private System.Windows.Forms.Label START_TIME;
        private System.Windows.Forms.Label END_TIME;
        private System.Windows.Forms.Label pr_id;
        private System.Windows.Forms.Label vi_rd;
        private System.Windows.Forms.Label pr__id;
        private System.Windows.Forms.Label po_id;
        private System.Windows.Forms.Label THE_PRISONERS;
        private System.Windows.Forms.Label THE_VISITORS;
        private System.Windows.Forms.Label THE_PRISONS;
        private System.Windows.Forms.Label THE_POLICEMEN;
    }
}