namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelComparison = new System.Windows.Forms.Label();
            this.labelLogicResult = new System.Windows.Forms.Label();
            this.labelEligible = new System.Windows.Forms.Label();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonlncrement = new System.Windows.Forms.Button();
            this.buttonDecrement = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonLogical = new System.Windows.Forms.Button();
            this.buttonTernary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expressions  and Operations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelValue.Location = new System.Drawing.Point(131, 133);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(141, 19);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Input Value:";
            // 
            // labelComparison
            // 
            this.labelComparison.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelComparison.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelComparison.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelComparison.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelComparison.Location = new System.Drawing.Point(88, 199);
            this.labelComparison.Name = "labelComparison";
            this.labelComparison.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelComparison.Size = new System.Drawing.Size(244, 37);
            this.labelComparison.TabIndex = 2;
            this.labelComparison.Text = "labelComparison >10?";
            this.labelComparison.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogicResult
            // 
            this.labelLogicResult.AutoSize = true;
            this.labelLogicResult.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelLogicResult.Location = new System.Drawing.Point(88, 282);
            this.labelLogicResult.Name = "labelLogicResult";
            this.labelLogicResult.Size = new System.Drawing.Size(185, 19);
            this.labelLogicResult.TabIndex = 3;
            this.labelLogicResult.Text = "labelLogicResult";
            // 
            // labelEligible
            // 
            this.labelEligible.AutoSize = true;
            this.labelEligible.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEligible.Location = new System.Drawing.Point(70, 371);
            this.labelEligible.Name = "labelEligible";
            this.labelEligible.Size = new System.Drawing.Size(273, 19);
            this.labelEligible.TabIndex = 4;
            this.labelEligible.Text = "You are eligible to vote";
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(92, 322);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(79, 16);
            this.checkBoxA.TabIndex = 5;
            this.checkBoxA.Text = "checkBoxA";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(213, 322);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(79, 16);
            this.checkBoxB.TabIndex = 6;
            this.checkBoxB.Text = "checkBoxB";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(367, 135);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(90, 22);
            this.textBoxValue.TabIndex = 7;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(367, 214);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(90, 22);
            this.textBoxInput.TabIndex = 8;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(135, 416);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(90, 22);
            this.textBoxAge.TabIndex = 9;
            // 
            // buttonlncrement
            // 
            this.buttonlncrement.Location = new System.Drawing.Point(595, 125);
            this.buttonlncrement.Name = "buttonlncrement";
            this.buttonlncrement.Size = new System.Drawing.Size(155, 39);
            this.buttonlncrement.TabIndex = 10;
            this.buttonlncrement.Text = "buttonlncrement";
            this.buttonlncrement.UseVisualStyleBackColor = true;
            this.buttonlncrement.Click += new System.EventHandler(this.buttonlncrement_Click);
            // 
            // buttonDecrement
            // 
            this.buttonDecrement.Location = new System.Drawing.Point(595, 199);
            this.buttonDecrement.Name = "buttonDecrement";
            this.buttonDecrement.Size = new System.Drawing.Size(155, 39);
            this.buttonDecrement.TabIndex = 11;
            this.buttonDecrement.Text = "buttonDecrement";
            this.buttonDecrement.UseVisualStyleBackColor = true;
            this.buttonDecrement.Click += new System.EventHandler(this.buttonDecrement_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(595, 262);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(155, 39);
            this.buttonCompare.TabIndex = 12;
            this.buttonCompare.Text = "buttonCompare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonLogical
            // 
            this.buttonLogical.Location = new System.Drawing.Point(595, 324);
            this.buttonLogical.Name = "buttonLogical";
            this.buttonLogical.Size = new System.Drawing.Size(155, 39);
            this.buttonLogical.TabIndex = 13;
            this.buttonLogical.Text = "buttonLogical";
            this.buttonLogical.UseVisualStyleBackColor = true;
            this.buttonLogical.Click += new System.EventHandler(this.buttonLogical_Click);
            // 
            // buttonTernary
            // 
            this.buttonTernary.Location = new System.Drawing.Point(595, 388);
            this.buttonTernary.Name = "buttonTernary";
            this.buttonTernary.Size = new System.Drawing.Size(155, 39);
            this.buttonTernary.TabIndex = 14;
            this.buttonTernary.Text = "buttonTernary";
            this.buttonTernary.UseVisualStyleBackColor = true;
            this.buttonTernary.Click += new System.EventHandler(this.buttonTernary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTernary);
            this.Controls.Add(this.buttonLogical);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonDecrement);
            this.Controls.Add(this.buttonlncrement);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.labelEligible);
            this.Controls.Add(this.labelLogicResult);
            this.Controls.Add(this.labelComparison);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelComparison;
        private System.Windows.Forms.Label labelLogicResult;
        private System.Windows.Forms.Label labelEligible;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonlncrement;
        private System.Windows.Forms.Button buttonDecrement;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonLogical;
        private System.Windows.Forms.Button buttonTernary;
    }
}

