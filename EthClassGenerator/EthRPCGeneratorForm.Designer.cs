namespace EthClassGenerator
{
    partial class EthRPCGeneratorForm
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
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnGenerateNoParams = new System.Windows.Forms.Button();
            this.txtReturnType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParams = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(92, 47);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(188, 20);
            this.txtMethodName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Method Name";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(92, 94);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(262, 192);
            this.txtSummary.TabIndex = 2;
            // 
            // btnGenerateNoParams
            // 
            this.btnGenerateNoParams.Location = new System.Drawing.Point(657, 401);
            this.btnGenerateNoParams.Name = "btnGenerateNoParams";
            this.btnGenerateNoParams.Size = new System.Drawing.Size(167, 33);
            this.btnGenerateNoParams.TabIndex = 3;
            this.btnGenerateNoParams.Text = "GenerateNoParams";
            this.btnGenerateNoParams.UseVisualStyleBackColor = true;
            this.btnGenerateNoParams.Click += new System.EventHandler(this.btnGenerateNoParams_Click);
            // 
            // txtReturnType
            // 
            this.txtReturnType.Location = new System.Drawing.Point(92, 317);
            this.txtReturnType.Name = "txtReturnType";
            this.txtReturnType.Size = new System.Drawing.Size(158, 20);
            this.txtReturnType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Return Type";
            // 
            // txtParams
            // 
            this.txtParams.Location = new System.Drawing.Point(516, 42);
            this.txtParams.Name = "txtParams";
            this.txtParams.Size = new System.Drawing.Size(100, 20);
            this.txtParams.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Param/s";
            // 
            // EthRPCGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 469);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReturnType);
            this.Controls.Add(this.btnGenerateNoParams);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMethodName);
            this.Name = "EthRPCGenerator";
            this.Text = "EthRPCGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnGenerateNoParams;
        private System.Windows.Forms.TextBox txtReturnType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.Label label4;
    }
}

