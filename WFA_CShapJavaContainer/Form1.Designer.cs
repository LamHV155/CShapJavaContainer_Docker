
namespace WFA_CShapJavaContainer
{
    partial class frm_Compile
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
            this.btn_StartUbuntu20Java = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.tbx_InsertCode = new System.Windows.Forms.TextBox();
            this.btn_Compile = new System.Windows.Forms.Button();
            this.tbx_InsertParameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Running = new System.Windows.Forms.Label();
            this.lbl_Existed = new System.Windows.Forms.Label();
            this.lbl_NotContainer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartUbuntu20Java
            // 
            this.btn_StartUbuntu20Java.Location = new System.Drawing.Point(24, 21);
            this.btn_StartUbuntu20Java.Name = "btn_StartUbuntu20Java";
            this.btn_StartUbuntu20Java.Size = new System.Drawing.Size(297, 40);
            this.btn_StartUbuntu20Java.TabIndex = 0;
            this.btn_StartUbuntu20Java.Text = "Start Ubuntu 20.04 + Java";
            this.btn_StartUbuntu20Java.UseVisualStyleBackColor = true;
            this.btn_StartUbuntu20Java.Click += new System.EventHandler(this.btn_StartUbuntu20Java_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(348, 21);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(232, 40);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // tbx_InsertCode
            // 
            this.tbx_InsertCode.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_InsertCode.Location = new System.Drawing.Point(24, 109);
            this.tbx_InsertCode.Multiline = true;
            this.tbx_InsertCode.Name = "tbx_InsertCode";
            this.tbx_InsertCode.Size = new System.Drawing.Size(573, 207);
            this.tbx_InsertCode.TabIndex = 2;
            // 
            // btn_Compile
            // 
            this.btn_Compile.Location = new System.Drawing.Point(24, 376);
            this.btn_Compile.Name = "btn_Compile";
            this.btn_Compile.Size = new System.Drawing.Size(186, 33);
            this.btn_Compile.TabIndex = 3;
            this.btn_Compile.Text = "Compile";
            this.btn_Compile.UseVisualStyleBackColor = true;
            this.btn_Compile.Click += new System.EventHandler(this.btn_Compile_Click);
            // 
            // tbx_InsertParameter
            // 
            this.tbx_InsertParameter.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_InsertParameter.Location = new System.Drawing.Point(107, 334);
            this.tbx_InsertParameter.Name = "tbx_InsertParameter";
            this.tbx_InsertParameter.Size = new System.Drawing.Size(473, 23);
            this.tbx_InsertParameter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // lbl_Running
            // 
            this.lbl_Running.AutoSize = true;
            this.lbl_Running.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Running.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Running.Location = new System.Drawing.Point(85, 77);
            this.lbl_Running.Name = "lbl_Running";
            this.lbl_Running.Size = new System.Drawing.Size(59, 17);
            this.lbl_Running.TabIndex = 7;
            this.lbl_Running.Text = "Running";
            // 
            // lbl_Existed
            // 
            this.lbl_Existed.AutoSize = true;
            this.lbl_Existed.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Existed.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Existed.Location = new System.Drawing.Point(85, 77);
            this.lbl_Existed.Name = "lbl_Existed";
            this.lbl_Existed.Size = new System.Drawing.Size(52, 17);
            this.lbl_Existed.TabIndex = 8;
            this.lbl_Existed.Text = "Existed";
            // 
            // lbl_NotContainer
            // 
            this.lbl_NotContainer.AutoSize = true;
            this.lbl_NotContainer.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotContainer.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_NotContainer.Location = new System.Drawing.Point(85, 77);
            this.lbl_NotContainer.Name = "lbl_NotContainer";
            this.lbl_NotContainer.Size = new System.Drawing.Size(146, 17);
            this.lbl_NotContainer.TabIndex = 9;
            this.lbl_NotContainer.Text = "Not container existed !";
            // 
            // frm_Compile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 431);
            this.Controls.Add(this.lbl_NotContainer);
            this.Controls.Add(this.lbl_Existed);
            this.Controls.Add(this.lbl_Running);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_InsertParameter);
            this.Controls.Add(this.btn_Compile);
            this.Controls.Add(this.tbx_InsertCode);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_StartUbuntu20Java);
            this.Name = "frm_Compile";
            this.Text = "Compile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartUbuntu20Java;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox tbx_InsertCode;
        private System.Windows.Forms.Button btn_Compile;
        private System.Windows.Forms.TextBox tbx_InsertParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Running;
        private System.Windows.Forms.Label lbl_Existed;
        private System.Windows.Forms.Label lbl_NotContainer;
    }
}

