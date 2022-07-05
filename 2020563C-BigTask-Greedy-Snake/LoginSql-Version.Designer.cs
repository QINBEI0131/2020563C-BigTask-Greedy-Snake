
namespace BigTaskTest01
{
    partial class LoginSql_Version
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
            this.labADMname = new System.Windows.Forms.Label();
            this.labADMPSW = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnLoginSql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labADMname
            // 
            this.labADMname.AutoSize = true;
            this.labADMname.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labADMname.Location = new System.Drawing.Point(57, 201);
            this.labADMname.Name = "labADMname";
            this.labADMname.Size = new System.Drawing.Size(159, 15);
            this.labADMname.TabIndex = 0;
            this.labADMname.Text = "Administrator-Name:";
            // 
            // labADMPSW
            // 
            this.labADMPSW.AutoSize = true;
            this.labADMPSW.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labADMPSW.Location = new System.Drawing.Point(57, 250);
            this.labADMPSW.Name = "labADMPSW";
            this.labADMPSW.Size = new System.Drawing.Size(151, 15);
            this.labADMPSW.TabIndex = 1;
            this.labADMPSW.Text = "Adminstrator-Code:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 198);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(238, 250);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(212, 25);
            this.txtPsw.TabIndex = 3;
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // btnLoginSql
            // 
            this.btnLoginSql.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoginSql.Location = new System.Drawing.Point(238, 341);
            this.btnLoginSql.Name = "btnLoginSql";
            this.btnLoginSql.Size = new System.Drawing.Size(137, 34);
            this.btnLoginSql.TabIndex = 4;
            this.btnLoginSql.Text = "Authorization";
            this.btnLoginSql.UseVisualStyleBackColor = false;
            this.btnLoginSql.Click += new System.EventHandler(this.btnLoginSql_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正舒体", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "管理员登录测试-数据库版";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正舒体", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "请管理员输入各自的管理员账号密码进行登录";
            // 
            // LoginSql_Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(704, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginSql);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labADMPSW);
            this.Controls.Add(this.labADMname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginSql_Version";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSql_Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labADMname;
        private System.Windows.Forms.Label labADMPSW;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnLoginSql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}