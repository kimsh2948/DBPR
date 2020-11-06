namespace CafeManagement
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputPW = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginInterface = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAmericano = new System.Windows.Forms.Button();
            this.buttonLatte = new System.Windows.Forms.Button();
            this.buttonCafeMoca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInputID
            // 
            this.textBoxInputID.Location = new System.Drawing.Point(36, 26);
            this.textBoxInputID.Name = "textBoxInputID";
            this.textBoxInputID.Size = new System.Drawing.Size(100, 21);
            this.textBoxInputID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            // 
            // textBoxInputPW
            // 
            this.textBoxInputPW.Location = new System.Drawing.Point(171, 26);
            this.textBoxInputPW.Name = "textBoxInputPW";
            this.textBoxInputPW.Size = new System.Drawing.Size(100, 21);
            this.textBoxInputPW.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(288, 24);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // labelLoginInterface
            // 
            this.labelLoginInterface.AutoSize = true;
            this.labelLoginInterface.Location = new System.Drawing.Point(578, 29);
            this.labelLoginInterface.Name = "labelLoginInterface";
            this.labelLoginInterface.Size = new System.Drawing.Size(105, 12);
            this.labelLoginInterface.TabIndex = 5;
            this.labelLoginInterface.Text = "로그인을 해주세요";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(689, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCafeMoca);
            this.groupBox1.Controls.Add(this.buttonLatte);
            this.groupBox1.Controls.Add(this.buttonAmericano);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(36, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 146);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐셔용 화면";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // buttonAmericano
            // 
            this.buttonAmericano.Location = new System.Drawing.Point(17, 66);
            this.buttonAmericano.Name = "buttonAmericano";
            this.buttonAmericano.Size = new System.Drawing.Size(187, 66);
            this.buttonAmericano.TabIndex = 9;
            this.buttonAmericano.Text = "아메리카노";
            this.buttonAmericano.UseVisualStyleBackColor = true;
            // 
            // buttonLatte
            // 
            this.buttonLatte.Location = new System.Drawing.Point(274, 66);
            this.buttonLatte.Name = "buttonLatte";
            this.buttonLatte.Size = new System.Drawing.Size(187, 66);
            this.buttonLatte.TabIndex = 10;
            this.buttonLatte.Text = "라떼";
            this.buttonLatte.UseVisualStyleBackColor = true;
            // 
            // buttonCafeMoca
            // 
            this.buttonCafeMoca.Location = new System.Drawing.Point(526, 66);
            this.buttonCafeMoca.Name = "buttonCafeMoca";
            this.buttonCafeMoca.Size = new System.Drawing.Size(187, 66);
            this.buttonCafeMoca.TabIndex = 11;
            this.buttonCafeMoca.Text = "카페모카";
            this.buttonCafeMoca.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(36, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 159);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자용 화면";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelLoginInterface);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInputPW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputID);
            this.Name = "Form1";
            this.Text = "맛있는 커피";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputPW;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLoginInterface;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCafeMoca;
        private System.Windows.Forms.Button buttonLatte;
        private System.Windows.Forms.Button buttonAmericano;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

