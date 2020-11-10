namespace DailyWork
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
            this.comboBoxMainCate = new System.Windows.Forms.ComboBox();
            this.comboBoxMiddleCate = new System.Windows.Forms.ComboBox();
            this.comboBoxSubCate = new System.Windows.Forms.ComboBox();
            this.buttonWorkRegSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMainCate
            // 
            this.comboBoxMainCate.FormattingEnabled = true;
            this.comboBoxMainCate.Items.AddRange(new object[] {
            "인사부서",
            "개발부서",
            "홍보부서"});
            this.comboBoxMainCate.Location = new System.Drawing.Point(166, 85);
            this.comboBoxMainCate.Name = "comboBoxMainCate";
            this.comboBoxMainCate.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMainCate.TabIndex = 0;
            this.comboBoxMainCate.Text = "대분류";
            // 
            // comboBoxMiddleCate
            // 
            this.comboBoxMiddleCate.FormattingEnabled = true;
            this.comboBoxMiddleCate.Items.AddRange(new object[] {
            "정기업무",
            "단기업무"});
            this.comboBoxMiddleCate.Location = new System.Drawing.Point(166, 149);
            this.comboBoxMiddleCate.Name = "comboBoxMiddleCate";
            this.comboBoxMiddleCate.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMiddleCate.TabIndex = 1;
            this.comboBoxMiddleCate.Text = "중분류";
            // 
            // comboBoxSubCate
            // 
            this.comboBoxSubCate.FormattingEnabled = true;
            this.comboBoxSubCate.Items.AddRange(new object[] {
            "근퇴확인",
            "급여정산",
            "개발",
            "회의"});
            this.comboBoxSubCate.Location = new System.Drawing.Point(166, 225);
            this.comboBoxSubCate.Name = "comboBoxSubCate";
            this.comboBoxSubCate.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSubCate.TabIndex = 2;
            this.comboBoxSubCate.Text = "소분류";
            // 
            // buttonWorkRegSave
            // 
            this.buttonWorkRegSave.Location = new System.Drawing.Point(181, 308);
            this.buttonWorkRegSave.Name = "buttonWorkRegSave";
            this.buttonWorkRegSave.Size = new System.Drawing.Size(87, 33);
            this.buttonWorkRegSave.TabIndex = 3;
            this.buttonWorkRegSave.Text = "저장";
            this.buttonWorkRegSave.UseVisualStyleBackColor = true;
            this.buttonWorkRegSave.Click += new System.EventHandler(this.buttonWorkRegSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 371);
            this.Controls.Add(this.buttonWorkRegSave);
            this.Controls.Add(this.comboBoxSubCate);
            this.Controls.Add(this.comboBoxMiddleCate);
            this.Controls.Add(this.comboBoxMainCate);
            this.Name = "Form2";
            this.Text = "업무등록";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMainCate;
        private System.Windows.Forms.ComboBox comboBoxMiddleCate;
        private System.Windows.Forms.ComboBox comboBoxSubCate;
        private System.Windows.Forms.Button buttonWorkRegSave;
    }
}