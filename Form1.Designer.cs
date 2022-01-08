
namespace _2a1b
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
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.play_btn = new System.Windows.Forms.Button();
            this.tutorial_btn = new System.Windows.Forms.Button();
            this.tutorial = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fireworks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fireworks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "by wefir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "a number guessing game";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(66, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(173, 87);
            this.title.TabIndex = 4;
            this.title.Text = "2a1b";
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play_btn.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play_btn.Location = new System.Drawing.Point(81, 262);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(154, 47);
            this.play_btn.TabIndex = 5;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tutorial_btn
            // 
            this.tutorial_btn.AllowDrop = true;
            this.tutorial_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tutorial_btn.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial_btn.Location = new System.Drawing.Point(81, 356);
            this.tutorial_btn.Name = "tutorial_btn";
            this.tutorial_btn.Size = new System.Drawing.Size(154, 45);
            this.tutorial_btn.TabIndex = 6;
            this.tutorial_btn.Text = "Tutorial";
            this.tutorial_btn.UseVisualStyleBackColor = true;
            this.tutorial_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // tutorial
            // 
            this.tutorial.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial.Location = new System.Drawing.Point(77, 146);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(620, 207);
            this.tutorial.TabIndex = 7;
            this.tutorial.Text = "玩家要猜一個四位數。不出現重複的數字\r\n\r\n每猜一次，系統將給予提示XaYb\r\n\r\nX表示位置與值皆正確的數的個數，而Y表示數字正確而位置不對的數的個數。";
            this.tutorial.Visible = false;
            // 
            // Back_btn
            // 
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_btn.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(81, 356);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(154, 45);
            this.Back_btn.TabIndex = 8;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Visible = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(40, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 36);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Your Guess";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(603, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "OutPut";
            this.label4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(409, 64);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(324, 358);
            this.textBox2.TabIndex = 17;
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fireworks
            // 
            this.fireworks.Image = global::_2a1b.Properties.Resources.fireworks;
            this.fireworks.Location = new System.Drawing.Point(1, 77);
            this.fireworks.Name = "fireworks";
            this.fireworks.Size = new System.Drawing.Size(402, 309);
            this.fireworks.TabIndex = 19;
            this.fireworks.TabStop = false;
            this.fireworks.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(745, 496);
            this.Controls.Add(this.fireworks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.tutorial_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tutorial);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "2a1b";
            ((System.ComponentModel.ISupportInitialize)(this.fireworks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button tutorial_btn;
        private System.Windows.Forms.Label tutorial;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox fireworks;
    }
}

