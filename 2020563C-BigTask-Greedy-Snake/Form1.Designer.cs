
namespace BigTaskTest01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnbegin = new System.Windows.Forms.Button();
            this.gamepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.btnchoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbegin
            // 
            this.btnbegin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbegin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnbegin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnbegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbegin.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnbegin.Location = new System.Drawing.Point(24, 24);
            this.btnbegin.Name = "btnbegin";
            this.btnbegin.Size = new System.Drawing.Size(101, 27);
            this.btnbegin.TabIndex = 0;
            this.btnbegin.Text = "StartGame";
            this.btnbegin.UseVisualStyleBackColor = true;
            this.btnbegin.Click += new System.EventHandler(this.btnbegin_Click);
            // 
            // gamepanel
            // 
            this.gamepanel.Location = new System.Drawing.Point(12, 77);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(562, 480);
            this.gamepanel.TabIndex = 1;
            this.gamepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Location = new System.Drawing.Point(248, 30);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(63, 15);
            this.labScore.TabIndex = 4;
            this.labScore.Text = "Score:0";
            // 
            // btnchoose
            // 
            this.btnchoose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnchoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchoose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnchoose.Location = new System.Drawing.Point(429, 24);
            this.btnchoose.Name = "btnchoose";
            this.btnchoose.Size = new System.Drawing.Size(105, 27);
            this.btnchoose.TabIndex = 5;
            this.btnchoose.Text = "难度重选";
            this.btnchoose.UseVisualStyleBackColor = false;
            this.btnchoose.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 578);
            this.Controls.Add(this.btnchoose);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamepanel);
            this.Controls.Add(this.btnbegin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbegin;
        private System.Windows.Forms.Panel gamepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Button btnchoose;
    }
}

