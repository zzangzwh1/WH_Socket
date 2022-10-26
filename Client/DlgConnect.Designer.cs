
namespace Client
{
    partial class DlgConnect
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
            this.UI_lbl_status = new System.Windows.Forms.Label();
            this.UI_Btn_connect = new System.Windows.Forms.Button();
            this.UI_tBox_hPort = new System.Windows.Forms.TextBox();
            this.UI_tBox_hAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_lbl_status
            // 
            this.UI_lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lbl_status.Location = new System.Drawing.Point(26, 373);
            this.UI_lbl_status.Name = "UI_lbl_status";
            this.UI_lbl_status.Size = new System.Drawing.Size(481, 50);
            this.UI_lbl_status.TabIndex = 11;
            this.UI_lbl_status.Text = "Please enter a host address..";
            this.UI_lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Btn_connect
            // 
            this.UI_Btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Btn_connect.Location = new System.Drawing.Point(274, 258);
            this.UI_Btn_connect.Name = "UI_Btn_connect";
            this.UI_Btn_connect.Size = new System.Drawing.Size(215, 63);
            this.UI_Btn_connect.TabIndex = 10;
            this.UI_Btn_connect.Text = "Connect";
            this.UI_Btn_connect.UseVisualStyleBackColor = true;
            // 
            // UI_tBox_hPort
            // 
            this.UI_tBox_hPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_tBox_hPort.Location = new System.Drawing.Point(48, 197);
            this.UI_tBox_hPort.Name = "UI_tBox_hPort";
            this.UI_tBox_hPort.Size = new System.Drawing.Size(441, 35);
            this.UI_tBox_hPort.TabIndex = 9;
            // 
            // UI_tBox_hAddress
            // 
            this.UI_tBox_hAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_tBox_hAddress.Location = new System.Drawing.Point(48, 79);
            this.UI_tBox_hAddress.Name = "UI_tBox_hAddress";
            this.UI_tBox_hAddress.Size = new System.Drawing.Size(441, 35);
            this.UI_tBox_hAddress.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Host Post :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host Address :";
            // 
            // DlgConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.UI_lbl_status);
            this.Controls.Add(this.UI_Btn_connect);
            this.Controls.Add(this.UI_tBox_hPort);
            this.Controls.Add(this.UI_tBox_hAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DlgConnect";
            this.Text = "DlgConnect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_lbl_status;
        private System.Windows.Forms.Button UI_Btn_connect;
        private System.Windows.Forms.TextBox UI_tBox_hPort;
        private System.Windows.Forms.TextBox UI_tBox_hAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}