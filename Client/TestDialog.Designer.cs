
namespace Client
{
    partial class TestDialog
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
            this.UI_btn_connect = new System.Windows.Forms.Button();
            this.UI_btn_guess = new System.Windows.Forms.Button();
            this.UI_NumGuessBar = new System.Windows.Forms.TrackBar();
            this.UI_lbl_min = new System.Windows.Forms.Label();
            this.UI_lbl_max = new System.Windows.Forms.Label();
            this.UI_lbl_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumGuessBar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_btn_connect
            // 
            this.UI_btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_btn_connect.Location = new System.Drawing.Point(40, 23);
            this.UI_btn_connect.Name = "UI_btn_connect";
            this.UI_btn_connect.Size = new System.Drawing.Size(234, 54);
            this.UI_btn_connect.TabIndex = 0;
            this.UI_btn_connect.Text = "button1";
            this.UI_btn_connect.UseVisualStyleBackColor = true;
            // 
            // UI_btn_guess
            // 
            this.UI_btn_guess.Location = new System.Drawing.Point(539, 365);
            this.UI_btn_guess.Name = "UI_btn_guess";
            this.UI_btn_guess.Size = new System.Drawing.Size(234, 54);
            this.UI_btn_guess.TabIndex = 1;
            this.UI_btn_guess.Text = "button2";
            this.UI_btn_guess.UseVisualStyleBackColor = true;
            // 
            // UI_NumGuessBar
            // 
            this.UI_NumGuessBar.Location = new System.Drawing.Point(40, 141);
            this.UI_NumGuessBar.Name = "UI_NumGuessBar";
            this.UI_NumGuessBar.Size = new System.Drawing.Size(720, 69);
            this.UI_NumGuessBar.TabIndex = 2;
            // 
            // UI_lbl_min
            // 
            this.UI_lbl_min.AutoSize = true;
            this.UI_lbl_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lbl_min.Location = new System.Drawing.Point(51, 229);
            this.UI_lbl_min.Name = "UI_lbl_min";
            this.UI_lbl_min.Size = new System.Drawing.Size(26, 29);
            this.UI_lbl_min.TabIndex = 3;
            this.UI_lbl_min.Text = "0";
            // 
            // UI_lbl_max
            // 
            this.UI_lbl_max.AutoSize = true;
            this.UI_lbl_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lbl_max.Location = new System.Drawing.Point(709, 229);
            this.UI_lbl_max.Name = "UI_lbl_max";
            this.UI_lbl_max.Size = new System.Drawing.Size(65, 29);
            this.UI_lbl_max.TabIndex = 4;
            this.UI_lbl_max.Text = "1000";
            // 
            // UI_lbl_value
            // 
            this.UI_lbl_value.AutoSize = true;
            this.UI_lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_lbl_value.Location = new System.Drawing.Point(364, 229);
            this.UI_lbl_value.Name = "UI_lbl_value";
            this.UI_lbl_value.Size = new System.Drawing.Size(52, 29);
            this.UI_lbl_value.TabIndex = 5;
            this.UI_lbl_value.Text = "500";
            // 
            // TestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_lbl_value);
            this.Controls.Add(this.UI_lbl_max);
            this.Controls.Add(this.UI_lbl_min);
            this.Controls.Add(this.UI_NumGuessBar);
            this.Controls.Add(this.UI_btn_guess);
            this.Controls.Add(this.UI_btn_connect);
            this.Name = "TestDialog";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumGuessBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_btn_connect;
        private System.Windows.Forms.Button UI_btn_guess;
        private System.Windows.Forms.TrackBar UI_NumGuessBar;
        private System.Windows.Forms.Label UI_lbl_min;
        private System.Windows.Forms.Label UI_lbl_max;
        private System.Windows.Forms.Label UI_lbl_value;
    }
}

