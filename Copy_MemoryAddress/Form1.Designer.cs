
namespace Copy_MemoryAddress
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.lblOriginData = new System.Windows.Forms.Label();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrgData = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblCopyData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxInt = new System.Windows.Forms.TextBox();
            this.tboxIntArray = new System.Windows.Forms.TextBox();
            this.rdoEqual = new System.Windows.Forms.RadioButton();
            this.rdoSallowCopy = new System.Windows.Forms.RadioButton();
            this.rdoDeepCopy = new System.Windows.Forms.RadioButton();
            this.tboxClassNumber = new System.Windows.Forms.TextBox();
            this.tboxChar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrigin);
            this.groupBox1.Controls.Add(this.lblOriginData);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origin Data";
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(324, 25);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(66, 30);
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // lblOriginData
            // 
            this.lblOriginData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOriginData.Location = new System.Drawing.Point(6, 25);
            this.lblOriginData.Name = "lblOriginData";
            this.lblOriginData.Size = new System.Drawing.Size(309, 30);
            this.lblOriginData.TabIndex = 0;
            this.lblOriginData.Text = "label1";
            this.lblOriginData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.label4);
            this.gbox.Controls.Add(this.label3);
            this.gbox.Controls.Add(this.lblOrgData);
            this.gbox.Controls.Add(this.btnCopy);
            this.gbox.Controls.Add(this.lblCopyData);
            this.gbox.Location = new System.Drawing.Point(11, 256);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(403, 117);
            this.gbox.TabIndex = 2;
            this.gbox.TabStop = false;
            this.gbox.Text = "a=b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copy";
            // 
            // lblOrgData
            // 
            this.lblOrgData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrgData.Location = new System.Drawing.Point(54, 69);
            this.lblOrgData.Name = "lblOrgData";
            this.lblOrgData.Size = new System.Drawing.Size(277, 30);
            this.lblOrgData.TabIndex = 2;
            this.lblOrgData.Text = "label2";
            this.lblOrgData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(337, 25);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(56, 74);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblCopyData
            // 
            this.lblCopyData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopyData.Location = new System.Drawing.Point(54, 25);
            this.lblCopyData.Name = "lblCopyData";
            this.lblCopyData.Size = new System.Drawing.Size(277, 30);
            this.lblCopyData.TabIndex = 0;
            this.lblCopyData.Text = "label1";
            this.lblCopyData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "3. Int Array";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "4. Class Inner Int";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "2. Char";
            // 
            // tboxInt
            // 
            this.tboxInt.Location = new System.Drawing.Point(109, 113);
            this.tboxInt.Name = "tboxInt";
            this.tboxInt.Size = new System.Drawing.Size(56, 25);
            this.tboxInt.TabIndex = 7;
            // 
            // tboxIntArray
            // 
            this.tboxIntArray.Location = new System.Drawing.Point(109, 157);
            this.tboxIntArray.Name = "tboxIntArray";
            this.tboxIntArray.Size = new System.Drawing.Size(56, 25);
            this.tboxIntArray.TabIndex = 8;
            // 
            // rdoEqual
            // 
            this.rdoEqual.AutoSize = true;
            this.rdoEqual.Location = new System.Drawing.Point(21, 217);
            this.rdoEqual.Name = "rdoEqual";
            this.rdoEqual.Size = new System.Drawing.Size(64, 19);
            this.rdoEqual.TabIndex = 11;
            this.rdoEqual.TabStop = true;
            this.rdoEqual.Text = "Equal";
            this.rdoEqual.UseVisualStyleBackColor = true;
            // 
            // rdoSallowCopy
            // 
            this.rdoSallowCopy.AutoSize = true;
            this.rdoSallowCopy.Location = new System.Drawing.Point(133, 217);
            this.rdoSallowCopy.Name = "rdoSallowCopy";
            this.rdoSallowCopy.Size = new System.Drawing.Size(111, 19);
            this.rdoSallowCopy.TabIndex = 12;
            this.rdoSallowCopy.TabStop = true;
            this.rdoSallowCopy.Text = "Sallow Copy";
            this.rdoSallowCopy.UseVisualStyleBackColor = true;
            // 
            // rdoDeepCopy
            // 
            this.rdoDeepCopy.AutoSize = true;
            this.rdoDeepCopy.Location = new System.Drawing.Point(272, 217);
            this.rdoDeepCopy.Name = "rdoDeepCopy";
            this.rdoDeepCopy.Size = new System.Drawing.Size(102, 19);
            this.rdoDeepCopy.TabIndex = 13;
            this.rdoDeepCopy.TabStop = true;
            this.rdoDeepCopy.Text = "Deep Copy";
            this.rdoDeepCopy.UseVisualStyleBackColor = true;
            // 
            // tboxClassNumber
            // 
            this.tboxClassNumber.Location = new System.Drawing.Point(341, 157);
            this.tboxClassNumber.Name = "tboxClassNumber";
            this.tboxClassNumber.Size = new System.Drawing.Size(56, 25);
            this.tboxClassNumber.TabIndex = 15;
            // 
            // tboxChar
            // 
            this.tboxChar.Location = new System.Drawing.Point(341, 113);
            this.tboxChar.Name = "tboxChar";
            this.tboxChar.Size = new System.Drawing.Size(56, 25);
            this.tboxChar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 387);
            this.Controls.Add(this.tboxClassNumber);
            this.Controls.Add(this.tboxChar);
            this.Controls.Add(this.rdoDeepCopy);
            this.Controls.Add(this.rdoSallowCopy);
            this.Controls.Add(this.rdoEqual);
            this.Controls.Add(this.tboxIntArray);
            this.Controls.Add(this.tboxInt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Label lblOriginData;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrgData;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblCopyData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxInt;
        private System.Windows.Forms.TextBox tboxIntArray;
        private System.Windows.Forms.RadioButton rdoEqual;
        private System.Windows.Forms.RadioButton rdoSallowCopy;
        private System.Windows.Forms.RadioButton rdoDeepCopy;
        private System.Windows.Forms.TextBox tboxClassNumber;
        private System.Windows.Forms.TextBox tboxChar;
    }
}

