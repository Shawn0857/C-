namespace WindowsForms2
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
            this.addButton = new System.Windows.Forms.Button();
            this.minButton2 = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.eqlButton = new System.Windows.Forms.Button();
            this.noteqlButton = new System.Windows.Forms.Button();
            this.biggerButton = new System.Windows.Forms.Button();
            this.smallerButton = new System.Windows.Forms.Button();
            this.Val1 = new System.Windows.Forms.TextBox();
            this.Val2 = new System.Windows.Forms.TextBox();
            this.resultVal = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(154, 155);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 37);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "加法";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // minButton2
            // 
            this.minButton2.Location = new System.Drawing.Point(242, 155);
            this.minButton2.Name = "minButton2";
            this.minButton2.Size = new System.Drawing.Size(82, 37);
            this.minButton2.TabIndex = 1;
            this.minButton2.Text = "減法";
            this.minButton2.UseVisualStyleBackColor = true;
            this.minButton2.Click += new System.EventHandler(this.minButton2_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(330, 155);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(82, 37);
            this.mulButton.TabIndex = 2;
            this.mulButton.Text = "乘法";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(418, 155);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(82, 37);
            this.divButton.TabIndex = 3;
            this.divButton.Text = "除法";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // eqlButton
            // 
            this.eqlButton.Location = new System.Drawing.Point(154, 218);
            this.eqlButton.Name = "eqlButton";
            this.eqlButton.Size = new System.Drawing.Size(82, 37);
            this.eqlButton.TabIndex = 4;
            this.eqlButton.Text = "相等?";
            this.eqlButton.UseVisualStyleBackColor = true;
            this.eqlButton.Click += new System.EventHandler(this.eqlButton_Click);
            // 
            // noteqlButton
            // 
            this.noteqlButton.Location = new System.Drawing.Point(242, 218);
            this.noteqlButton.Name = "noteqlButton";
            this.noteqlButton.Size = new System.Drawing.Size(82, 37);
            this.noteqlButton.TabIndex = 5;
            this.noteqlButton.Text = "不相等?";
            this.noteqlButton.UseVisualStyleBackColor = true;
            this.noteqlButton.Click += new System.EventHandler(this.noteqlButton_Click);
            // 
            // biggerButton
            // 
            this.biggerButton.Location = new System.Drawing.Point(330, 218);
            this.biggerButton.Name = "biggerButton";
            this.biggerButton.Size = new System.Drawing.Size(82, 37);
            this.biggerButton.TabIndex = 6;
            this.biggerButton.Text = "大於";
            this.biggerButton.UseVisualStyleBackColor = true;
            this.biggerButton.Click += new System.EventHandler(this.biggerButton_Click);
            // 
            // smallerButton
            // 
            this.smallerButton.Location = new System.Drawing.Point(418, 218);
            this.smallerButton.Name = "smallerButton";
            this.smallerButton.Size = new System.Drawing.Size(82, 37);
            this.smallerButton.TabIndex = 7;
            this.smallerButton.Text = "小於";
            this.smallerButton.UseVisualStyleBackColor = true;
            this.smallerButton.Click += new System.EventHandler(this.smallerButton_Click);
            // 
            // Val1
            // 
            this.Val1.Location = new System.Drawing.Point(154, 114);
            this.Val1.Name = "Val1";
            this.Val1.Size = new System.Drawing.Size(170, 22);
            this.Val1.TabIndex = 8;
            // 
            // Val2
            // 
            this.Val2.Location = new System.Drawing.Point(330, 114);
            this.Val2.Name = "Val2";
            this.Val2.Size = new System.Drawing.Size(170, 22);
            this.Val2.TabIndex = 9;
            // 
            // resultVal
            // 
            this.resultVal.Location = new System.Drawing.Point(242, 273);
            this.resultVal.Name = "resultVal";
            this.resultVal.Size = new System.Drawing.Size(170, 22);
            this.resultVal.TabIndex = 10;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Location = new System.Drawing.Point(175, 279);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(50, 16);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "結果:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultVal);
            this.Controls.Add(this.Val2);
            this.Controls.Add(this.Val1);
            this.Controls.Add(this.smallerButton);
            this.Controls.Add(this.biggerButton);
            this.Controls.Add(this.noteqlButton);
            this.Controls.Add(this.eqlButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.minButton2);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "簡易計算機程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button minButton2;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button eqlButton;
        private System.Windows.Forms.Button noteqlButton;
        private System.Windows.Forms.Button biggerButton;
        private System.Windows.Forms.Button smallerButton;
        private System.Windows.Forms.TextBox Val1;
        private System.Windows.Forms.TextBox Val2;
        private System.Windows.Forms.TextBox resultVal;
        private System.Windows.Forms.Label resultLabel;
    }
}

