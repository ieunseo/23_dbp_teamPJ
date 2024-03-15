namespace dbp_cafe_team
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
            this.ameri_btn = new System.Windows.Forms.Button();
            this.vanil_btn = new System.Windows.Forms.Button();
            this.choco_btn = new System.Windows.Forms.Button();
            this.moca_btn = new System.Windows.Forms.Button();
            this.latte_btn = new System.Windows.Forms.Button();
            this.caffu_btn = new System.Windows.Forms.Button();
            this.select_cancel = new System.Windows.Forms.Button();
            this.cash_btn = new System.Windows.Forms.Button();
            this.card_btn = new System.Windows.Forms.Button();
            this.order_manage = new System.Windows.Forms.GroupBox();
            this.order_list = new System.Windows.Forms.ListView();
            this.menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.order_cost = new System.Windows.Forms.Button();
            this.order_costtxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.order_manage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ameri_btn
            // 
            this.ameri_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ameri_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ameri_btn.Location = new System.Drawing.Point(11, 23);
            this.ameri_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ameri_btn.Name = "ameri_btn";
            this.ameri_btn.Size = new System.Drawing.Size(79, 53);
            this.ameri_btn.TabIndex = 0;
            this.ameri_btn.Text = "아메리카노";
            this.ameri_btn.UseVisualStyleBackColor = false;
            this.ameri_btn.Click += new System.EventHandler(this.ameri_btn_Click);
            // 
            // vanil_btn
            // 
            this.vanil_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vanil_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vanil_btn.Location = new System.Drawing.Point(105, 90);
            this.vanil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vanil_btn.Name = "vanil_btn";
            this.vanil_btn.Size = new System.Drawing.Size(79, 53);
            this.vanil_btn.TabIndex = 1;
            this.vanil_btn.Text = "바닐라라떼";
            this.vanil_btn.UseVisualStyleBackColor = false;
            this.vanil_btn.Click += new System.EventHandler(this.vanil_btn_Click);
            // 
            // choco_btn
            // 
            this.choco_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choco_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choco_btn.Location = new System.Drawing.Point(199, 90);
            this.choco_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choco_btn.Name = "choco_btn";
            this.choco_btn.Size = new System.Drawing.Size(79, 53);
            this.choco_btn.TabIndex = 2;
            this.choco_btn.Text = "초코라떼";
            this.choco_btn.UseVisualStyleBackColor = false;
            this.choco_btn.Click += new System.EventHandler(this.choco_btn_Click);
            // 
            // moca_btn
            // 
            this.moca_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moca_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.moca_btn.Location = new System.Drawing.Point(199, 23);
            this.moca_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moca_btn.Name = "moca_btn";
            this.moca_btn.Size = new System.Drawing.Size(79, 53);
            this.moca_btn.TabIndex = 3;
            this.moca_btn.Text = "카페모카";
            this.moca_btn.UseVisualStyleBackColor = false;
            this.moca_btn.Click += new System.EventHandler(this.moca_btn_Click);
            // 
            // latte_btn
            // 
            this.latte_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.latte_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.latte_btn.Location = new System.Drawing.Point(105, 23);
            this.latte_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.latte_btn.Name = "latte_btn";
            this.latte_btn.Size = new System.Drawing.Size(79, 53);
            this.latte_btn.TabIndex = 4;
            this.latte_btn.Text = "카페라떼";
            this.latte_btn.UseVisualStyleBackColor = false;
            this.latte_btn.Click += new System.EventHandler(this.latte_btn_Click);
            // 
            // caffu_btn
            // 
            this.caffu_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caffu_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.caffu_btn.Location = new System.Drawing.Point(11, 90);
            this.caffu_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caffu_btn.Name = "caffu_btn";
            this.caffu_btn.Size = new System.Drawing.Size(79, 53);
            this.caffu_btn.TabIndex = 5;
            this.caffu_btn.Text = "카푸치노";
            this.caffu_btn.UseVisualStyleBackColor = false;
            this.caffu_btn.Click += new System.EventHandler(this.caffu_btn_Click);
            // 
            // select_cancel
            // 
            this.select_cancel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.select_cancel.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select_cancel.Location = new System.Drawing.Point(397, 266);
            this.select_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.select_cancel.Name = "select_cancel";
            this.select_cancel.Size = new System.Drawing.Size(79, 39);
            this.select_cancel.TabIndex = 8;
            this.select_cancel.Text = "선택취소";
            this.select_cancel.UseVisualStyleBackColor = false;
            this.select_cancel.Click += new System.EventHandler(this.select_cancel_Click);
            // 
            // cash_btn
            // 
            this.cash_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cash_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cash_btn.Location = new System.Drawing.Point(491, 266);
            this.cash_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cash_btn.Name = "cash_btn";
            this.cash_btn.Size = new System.Drawing.Size(79, 39);
            this.cash_btn.TabIndex = 9;
            this.cash_btn.Text = "현금결제";
            this.cash_btn.UseVisualStyleBackColor = false;
            this.cash_btn.Click += new System.EventHandler(this.cash_btn_Click);
            // 
            // card_btn
            // 
            this.card_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.card_btn.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.card_btn.Location = new System.Drawing.Point(585, 266);
            this.card_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card_btn.Name = "card_btn";
            this.card_btn.Size = new System.Drawing.Size(79, 39);
            this.card_btn.TabIndex = 10;
            this.card_btn.Text = "카드결제";
            this.card_btn.UseVisualStyleBackColor = false;
            this.card_btn.Click += new System.EventHandler(this.card_btn_Click);
            // 
            // order_manage
            // 
            this.order_manage.Controls.Add(this.order_list);
            this.order_manage.Controls.Add(this.label2);
            this.order_manage.Controls.Add(this.label1);
            this.order_manage.Controls.Add(this.order_cost);
            this.order_manage.Controls.Add(this.order_costtxt);
            this.order_manage.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_manage.Location = new System.Drawing.Point(38, 65);
            this.order_manage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_manage.Name = "order_manage";
            this.order_manage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_manage.Size = new System.Drawing.Size(325, 279);
            this.order_manage.TabIndex = 12;
            this.order_manage.TabStop = false;
            this.order_manage.Text = "주문관리";
            // 
            // order_list
            // 
            this.order_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu,
            this.quantity,
            this.Price});
            this.order_list.FullRowSelect = true;
            this.order_list.GridLines = true;
            this.order_list.HideSelection = false;
            this.order_list.Location = new System.Drawing.Point(6, 19);
            this.order_list.Name = "order_list";
            this.order_list.Size = new System.Drawing.Size(313, 176);
            this.order_list.TabIndex = 17;
            this.order_list.UseCompatibleStateImageBehavior = false;
            this.order_list.View = System.Windows.Forms.View.Details;
            this.order_list.SelectedIndexChanged += new System.EventHandler(this.order_list_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Text = "메뉴";
            this.menu.Width = 76;
            // 
            // quantity
            // 
            this.quantity.DisplayIndex = 2;
            this.quantity.Text = "수량";
            this.quantity.Width = 117;
            // 
            // Price
            // 
            this.Price.DisplayIndex = 1;
            this.Price.Text = "가격";
            this.Price.Width = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "원";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "총";
            // 
            // order_cost
            // 
            this.order_cost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.order_cost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.order_cost.Location = new System.Drawing.Point(213, 219);
            this.order_cost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_cost.Name = "order_cost";
            this.order_cost.Size = new System.Drawing.Size(76, 29);
            this.order_cost.TabIndex = 14;
            this.order_cost.Text = "주문합계";
            this.order_cost.UseVisualStyleBackColor = false;
            this.order_cost.Click += new System.EventHandler(this.order_cost_Click);
            // 
            // order_costtxt
            // 
            this.order_costtxt.Location = new System.Drawing.Point(48, 225);
            this.order_costtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order_costtxt.Name = "order_costtxt";
            this.order_costtxt.Size = new System.Drawing.Size(121, 21);
            this.order_costtxt.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.caffu_btn);
            this.groupBox1.Controls.Add(this.latte_btn);
            this.groupBox1.Controls.Add(this.moca_btn);
            this.groupBox1.Controls.Add(this.choco_btn);
            this.groupBox1.Controls.Add(this.vanil_btn);
            this.groupBox1.Controls.Add(this.ameri_btn);
            this.groupBox1.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(386, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(288, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.order_manage);
            this.Controls.Add(this.card_btn);
            this.Controls.Add(this.cash_btn);
            this.Controls.Add(this.select_cancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "주문관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.order_manage.ResumeLayout(false);
            this.order_manage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ameri_btn;
        private System.Windows.Forms.Button vanil_btn;
        private System.Windows.Forms.Button choco_btn;
        private System.Windows.Forms.Button moca_btn;
        private System.Windows.Forms.Button latte_btn;
        private System.Windows.Forms.Button caffu_btn;
        private System.Windows.Forms.Button select_cancel;
        private System.Windows.Forms.Button cash_btn;
        private System.Windows.Forms.Button card_btn;
        private System.Windows.Forms.GroupBox order_manage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox order_costtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button order_cost;
        private System.Windows.Forms.ListView order_list;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader Price;
    }
}