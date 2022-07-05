
namespace BigTaskTest01
{
    partial class Landing_mode
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
            this.btnBetaUser = new System.Windows.Forms.Button();
            this.btnADM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBetaUser
            // 
            this.btnBetaUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBetaUser.Location = new System.Drawing.Point(141, 129);
            this.btnBetaUser.Name = "btnBetaUser";
            this.btnBetaUser.Size = new System.Drawing.Size(219, 51);
            this.btnBetaUser.TabIndex = 0;
            this.btnBetaUser.Text = "内测用户登录";
            this.btnBetaUser.UseVisualStyleBackColor = false;
            this.btnBetaUser.Click += new System.EventHandler(this.btnBetaUser_Click);
            // 
            // btnADM
            // 
            this.btnADM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnADM.Location = new System.Drawing.Point(141, 272);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(219, 51);
            this.btnADM.TabIndex = 1;
            this.btnADM.Text = "管理员登录";
            this.btnADM.UseVisualStyleBackColor = false;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // Landing_mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.btnADM);
            this.Controls.Add(this.btnBetaUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Landing_mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landing_mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBetaUser;
        private System.Windows.Forms.Button btnADM;
    }
}