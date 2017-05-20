namespace WinClient
{
    partial class Client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbWHO = new System.Windows.Forms.RadioButton();
            this.rbHC = new System.Windows.Forms.RadioButton();
            this.lblEntity = new System.Windows.Forms.Label();
            this.cbEntity = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEntity);
            this.groupBox1.Controls.Add(this.lblEntity);
            this.groupBox1.Controls.Add(this.rbHC);
            this.groupBox1.Controls.Add(this.rbWHO);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Location = new System.Drawing.Point(147, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 151);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(205, 43);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(180, 111);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(442, 20);
            this.txtURL.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(144, 284);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 1;
            // 
            // rbWHO
            // 
            this.rbWHO.AutoSize = true;
            this.rbWHO.Checked = true;
            this.rbWHO.Location = new System.Drawing.Point(66, 41);
            this.rbWHO.Name = "rbWHO";
            this.rbWHO.Size = new System.Drawing.Size(66, 17);
            this.rbWHO.TabIndex = 3;
            this.rbWHO.TabStop = true;
            this.rbWHO.Text = "WHO.int";
            this.rbWHO.UseVisualStyleBackColor = true;
            this.rbWHO.CheckedChanged += new System.EventHandler(this.rbWHO_CheckedChanged);
            // 
            // rbHC
            // 
            this.rbHC.AutoSize = true;
            this.rbHC.Location = new System.Drawing.Point(180, 41);
            this.rbHC.Name = "rbHC";
            this.rbHC.Size = new System.Drawing.Size(78, 17);
            this.rbHC.TabIndex = 4;
            this.rbHC.Text = "HealthCare";
            this.rbHC.UseVisualStyleBackColor = true;
            this.rbHC.CheckedChanged += new System.EventHandler(this.rbHC_CheckedChanged);
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(66, 81);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(33, 13);
            this.lblEntity.TabIndex = 5;
            this.lblEntity.Text = "Entity";
            // 
            // cbEntity
            // 
            this.cbEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntity.FormattingEnabled = true;
            this.cbEntity.Location = new System.Drawing.Point(180, 72);
            this.cbEntity.Name = "cbEntity";
            this.cbEntity.Size = new System.Drawing.Size(121, 21);
            this.cbEntity.TabIndex = 6;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(955, 696);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rbHC;
        private System.Windows.Forms.RadioButton rbWHO;
        private System.Windows.Forms.ComboBox cbEntity;
        private System.Windows.Forms.Label lblEntity;
    }
}