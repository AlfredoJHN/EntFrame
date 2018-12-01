namespace AW.PRODUCTS
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
            this.cbColores = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.Colores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbColores
            // 
            this.cbColores.FormattingEnabled = true;
            this.cbColores.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Black",
            "White",
            "Silver"});
            this.cbColores.Location = new System.Drawing.Point(404, 107);
            this.cbColores.Name = "cbColores";
            this.cbColores.Size = new System.Drawing.Size(121, 21);
            this.cbColores.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(24, 167);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(270, 21);
            this.cbProductos.TabIndex = 2;
            // 
            // Colores
            // 
            this.Colores.AutoSize = true;
            this.Colores.Location = new System.Drawing.Point(356, 110);
            this.Colores.Name = "Colores";
            this.Colores.Size = new System.Drawing.Size(42, 13);
            this.Colores.TabIndex = 3;
            this.Colores.Text = "Colores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Colores);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbColores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label Colores;
        private System.Windows.Forms.Label label1;
    }
}

