﻿namespace DailyWork
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
            this.buttonWorkReg = new System.Windows.Forms.Button();
            this.buttonWorkMod = new System.Windows.Forms.Button();
            this.buttonWorkDel = new System.Windows.Forms.Button();
            this.listViewWorkList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonWorkReg
            // 
            this.buttonWorkReg.Location = new System.Drawing.Point(170, 328);
            this.buttonWorkReg.Name = "buttonWorkReg";
            this.buttonWorkReg.Size = new System.Drawing.Size(105, 46);
            this.buttonWorkReg.TabIndex = 0;
            this.buttonWorkReg.Text = "업무등록";
            this.buttonWorkReg.UseVisualStyleBackColor = true;
            this.buttonWorkReg.Click += new System.EventHandler(this.buttonWorkReg_Click);
            // 
            // buttonWorkMod
            // 
            this.buttonWorkMod.Location = new System.Drawing.Point(366, 328);
            this.buttonWorkMod.Name = "buttonWorkMod";
            this.buttonWorkMod.Size = new System.Drawing.Size(105, 46);
            this.buttonWorkMod.TabIndex = 1;
            this.buttonWorkMod.Text = "업무수정";
            this.buttonWorkMod.UseVisualStyleBackColor = true;
            // 
            // buttonWorkDel
            // 
            this.buttonWorkDel.Location = new System.Drawing.Point(570, 328);
            this.buttonWorkDel.Name = "buttonWorkDel";
            this.buttonWorkDel.Size = new System.Drawing.Size(105, 46);
            this.buttonWorkDel.TabIndex = 2;
            this.buttonWorkDel.Text = "업무삭제";
            this.buttonWorkDel.UseVisualStyleBackColor = true;
            // 
            // listViewWorkList
            // 
            this.listViewWorkList.GridLines = true;
            this.listViewWorkList.HideSelection = false;
            this.listViewWorkList.Location = new System.Drawing.Point(170, 48);
            this.listViewWorkList.Name = "listViewWorkList";
            this.listViewWorkList.Size = new System.Drawing.Size(505, 236);
            this.listViewWorkList.TabIndex = 3;
            this.listViewWorkList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewWorkList);
            this.Controls.Add(this.buttonWorkDel);
            this.Controls.Add(this.buttonWorkMod);
            this.Controls.Add(this.buttonWorkReg);
            this.Name = "Form1";
            this.Text = "ERP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWorkReg;
        private System.Windows.Forms.Button buttonWorkMod;
        private System.Windows.Forms.Button buttonWorkDel;
        private System.Windows.Forms.ListView listViewWorkList;
    }
}

