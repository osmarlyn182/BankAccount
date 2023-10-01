namespace CuentaBancaria
{
    partial class BankAccountinfo
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
            this.lblBienvenidaBA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAmount = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenidaBA
            // 
            this.lblBienvenidaBA.AutoSize = true;
            this.lblBienvenidaBA.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaBA.Location = new System.Drawing.Point(43, 41);
            this.lblBienvenidaBA.Name = "lblBienvenidaBA";
            this.lblBienvenidaBA.Size = new System.Drawing.Size(0, 21);
            this.lblBienvenidaBA.TabIndex = 0;
            this.lblBienvenidaBA.Click += new System.EventHandler(this.lblBienvenidaBA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // btnAmount
            // 
            this.btnAmount.Location = new System.Drawing.Point(112, 112);
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Size = new System.Drawing.Size(114, 59);
            this.btnAmount.TabIndex = 2;
            this.btnAmount.Text = "Depositar";
            this.btnAmount.UseVisualStyleBackColor = true;
            this.btnAmount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(112, 203);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(114, 54);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Retirar ";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(408, 112);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(108, 59);
            this.btnBalance.TabIndex = 4;
            this.btnBalance.Text = "Ver Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(408, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 54);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // BankAccountinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBienvenidaBA);
            this.Name = "BankAccountinfo";
            this.Text = "BankAccountinfo";
            this.Load += new System.EventHandler(this.BankAccountinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblBienvenidaBA;
    }
}