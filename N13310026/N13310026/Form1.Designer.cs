namespace N13310026
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
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangeLabel = new System.Windows.Forms.Button();
            this.lab_ChangeLabel = new System.Windows.Forms.Label();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.BackColor = System.Drawing.Color.Pink;
            this.btn_ClickMe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ClickMe.Location = new System.Drawing.Point(65, 114);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(186, 96);
            this.btn_ClickMe.TabIndex = 0;
            this.btn_ClickMe.Text = "請按一下";
            this.btn_ClickMe.UseVisualStyleBackColor = false;
            this.btn_ClickMe.Click += new System.EventHandler(this.btn_ClickMe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "N13310026_康";
            // 
            // btn_ChangeLabel
            // 
            this.btn_ChangeLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_ChangeLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ChangeLabel.ForeColor = System.Drawing.Color.Indigo;
            this.btn_ChangeLabel.Location = new System.Drawing.Point(65, 257);
            this.btn_ChangeLabel.Name = "btn_ChangeLabel";
            this.btn_ChangeLabel.Size = new System.Drawing.Size(125, 62);
            this.btn_ChangeLabel.TabIndex = 2;
            this.btn_ChangeLabel.Text = "按我切換標籤";
            this.btn_ChangeLabel.UseVisualStyleBackColor = false;
            this.btn_ChangeLabel.Click += new System.EventHandler(this.btn_ChangeLabel_Click);
            // 
            // lab_ChangeLabel
            // 
            this.lab_ChangeLabel.AutoSize = true;
            this.lab_ChangeLabel.Font = new System.Drawing.Font("標楷體", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ChangeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lab_ChangeLabel.Location = new System.Drawing.Point(229, 270);
            this.lab_ChangeLabel.Name = "lab_ChangeLabel";
            this.lab_ChangeLabel.Size = new System.Drawing.Size(109, 29);
            this.lab_ChangeLabel.TabIndex = 3;
            this.lab_ChangeLabel.Text = "label2";
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Font = new System.Drawing.Font("標楷體", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Counter.ForeColor = System.Drawing.Color.SlateBlue;
            this.lab_Counter.Location = new System.Drawing.Point(229, 352);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(29, 29);
            this.lab_Counter.TabIndex = 5;
            this.lab_Counter.Text = "0";
            // 
            // btn_Counter
            // 
            this.btn_Counter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Counter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Counter.ForeColor = System.Drawing.Color.Thistle;
            this.btn_Counter.Location = new System.Drawing.Point(65, 339);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(125, 62);
            this.btn_Counter.TabIndex = 4;
            this.btn_Counter.Text = "按我加加";
            this.btn_Counter.UseVisualStyleBackColor = false;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_ChangeLabel);
            this.Controls.Add(this.btn_ChangeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Label lab_ChangeLabel;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button btn_Counter;
    }
}

