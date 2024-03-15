namespace dbp_cafe_team
{
    partial class Form2
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
            this.pay_search = new System.Windows.Forms.Button();
            this.pay_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.주문번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.판매물품명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.결제금액 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.물품수량 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.결제수단 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderNum_SearchBtn = new System.Windows.Forms.Button();
            this.OrderNum_Serch_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pay_search
            // 
            this.pay_search.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pay_search.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_search.Location = new System.Drawing.Point(601, 269);
            this.pay_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pay_search.Name = "pay_search";
            this.pay_search.Size = new System.Drawing.Size(153, 70);
            this.pay_search.TabIndex = 1;
            this.pay_search.Text = "결제내역조회";
            this.pay_search.UseVisualStyleBackColor = false;
            this.pay_search.Click += new System.EventHandler(this.pay_search_Click);
            // 
            // pay_cancel
            // 
            this.pay_cancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pay_cancel.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_cancel.Location = new System.Drawing.Point(601, 346);
            this.pay_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pay_cancel.Name = "pay_cancel";
            this.pay_cancel.Size = new System.Drawing.Size(153, 70);
            this.pay_cancel.TabIndex = 2;
            this.pay_cancel.Text = "결제취소";
            this.pay_cancel.UseVisualStyleBackColor = false;
            this.pay_cancel.Click += new System.EventHandler(this.pay_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "결제내역";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.주문번호,
            this.판매물품명,
            this.결제금액,
            this.물품수량,
            this.결제수단});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 89);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 325);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // 주문번호
            // 
            this.주문번호.Text = "주문번호";
            this.주문번호.Width = 95;
            // 
            // 판매물품명
            // 
            this.판매물품명.Text = "판매물품명";
            this.판매물품명.Width = 77;
            // 
            // 결제금액
            // 
            this.결제금액.Text = "결제금액";
            this.결제금액.Width = 72;
            // 
            // 물품수량
            // 
            this.물품수량.Text = "물품수량";
            this.물품수량.Width = 79;
            // 
            // 결제수단
            // 
            this.결제수단.Text = "결제수단";
            this.결제수단.Width = 81;
            // 
            // OrderNum_SearchBtn
            // 
            this.OrderNum_SearchBtn.Location = new System.Drawing.Point(490, 49);
            this.OrderNum_SearchBtn.Name = "OrderNum_SearchBtn";
            this.OrderNum_SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.OrderNum_SearchBtn.TabIndex = 5;
            this.OrderNum_SearchBtn.Text = "검색";
            this.OrderNum_SearchBtn.UseVisualStyleBackColor = true;
            this.OrderNum_SearchBtn.Click += new System.EventHandler(this.OrderNum_SearchBtn_Click);
            // 
            // OrderNum_Serch_textBox
            // 
            this.OrderNum_Serch_textBox.Location = new System.Drawing.Point(244, 47);
            this.OrderNum_Serch_textBox.Name = "OrderNum_Serch_textBox";
            this.OrderNum_Serch_textBox.Size = new System.Drawing.Size(230, 25);
            this.OrderNum_Serch_textBox.TabIndex = 6;
            this.OrderNum_Serch_textBox.TextChanged += new System.EventHandler(this.OrderNum_Serch_textBox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderNum_Serch_textBox);
            this.Controls.Add(this.OrderNum_SearchBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pay_cancel);
            this.Controls.Add(this.pay_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "결제내역";
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pay_search;
        private System.Windows.Forms.Button pay_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 주문번호;
        private System.Windows.Forms.ColumnHeader 판매물품명;
        private System.Windows.Forms.ColumnHeader 결제금액;
        private System.Windows.Forms.ColumnHeader 물품수량;
        private System.Windows.Forms.ColumnHeader 결제수단;
        private System.Windows.Forms.Button OrderNum_SearchBtn;
        private System.Windows.Forms.TextBox OrderNum_Serch_textBox;
    }
}