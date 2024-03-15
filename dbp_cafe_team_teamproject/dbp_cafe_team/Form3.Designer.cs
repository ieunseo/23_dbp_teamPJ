namespace dbp_cafe_team
{
    partial class Form3
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
            this.revenue = new System.Windows.Forms.DataGridView();
            this.revenue_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.revenue)).BeginInit();
            this.SuspendLayout();
            // 
            // revenue
            // 
            this.revenue.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenue.Location = new System.Drawing.Point(51, 66);
            this.revenue.Name = "revenue";
            this.revenue.RowHeadersWidth = 51;
            this.revenue.RowTemplate.Height = 23;
            this.revenue.Size = new System.Drawing.Size(596, 220);
            this.revenue.TabIndex = 0;
            this.revenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.revenue_CellContentClick);
            // 
            // revenue_search
            // 
            this.revenue_search.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.revenue_search.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.revenue_search.Location = new System.Drawing.Point(51, 302);
            this.revenue_search.Name = "revenue_search";
            this.revenue_search.Size = new System.Drawing.Size(596, 37);
            this.revenue_search.TabIndex = 1;
            this.revenue_search.Text = "매출조회";
            this.revenue_search.UseVisualStyleBackColor = false;
            this.revenue_search.Click += new System.EventHandler(this.revenue_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "총 매출";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.revenue_search);
            this.Controls.Add(this.revenue);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "매출관리";
            this.Load += new System.EventHandler(this.form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.revenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView revenue;
        private System.Windows.Forms.Button revenue_search;
        private System.Windows.Forms.Label label1;
    }
}