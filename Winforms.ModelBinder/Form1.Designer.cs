namespace Winforms.ModelBinder
{
    partial class Form1
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
            this.CarName = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.IsDiesel = new System.Windows.Forms.CheckBox();
            this.EngineTypes = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarName
            // 
            this.CarName.Location = new System.Drawing.Point(12, 12);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(100, 20);
            this.CarName.TabIndex = 0;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(129, 12);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(100, 20);
            this.Manufacturer.TabIndex = 1;
            // 
            // IsDiesel
            // 
            this.IsDiesel.AutoSize = true;
            this.IsDiesel.Location = new System.Drawing.Point(246, 15);
            this.IsDiesel.Name = "IsDiesel";
            this.IsDiesel.Size = new System.Drawing.Size(63, 17);
            this.IsDiesel.TabIndex = 2;
            this.IsDiesel.Text = "IsDiesel";
            this.IsDiesel.UseVisualStyleBackColor = true;
            // 
            // EngineTypes
            // 
            this.EngineTypes.FormattingEnabled = true;
            this.EngineTypes.Location = new System.Drawing.Point(12, 48);
            this.EngineTypes.Name = "EngineTypes";
            this.EngineTypes.Size = new System.Drawing.Size(298, 21);
            this.EngineTypes.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 125);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.EngineTypes);
            this.Controls.Add(this.IsDiesel);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.CarName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CarName;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.CheckBox IsDiesel;
        private System.Windows.Forms.ComboBox EngineTypes;
        private System.Windows.Forms.Button btnSave;
    }
}

