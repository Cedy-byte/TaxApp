namespace TaxApp
{
    partial class Reflection
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
            this.txtCollection = new System.Windows.Forms.TextBox();
            this.txtAssemblies = new System.Windows.Forms.TextBox();
            this.txtDll = new System.Windows.Forms.TextBox();
            this.btnAssembly = new System.Windows.Forms.Button();
            this.btnDLL = new System.Windows.Forms.Button();
            this.btncollection = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCollection
            // 
            this.txtCollection.Location = new System.Drawing.Point(172, 319);
            this.txtCollection.Multiline = true;
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(453, 121);
            this.txtCollection.TabIndex = 17;
            // 
            // txtAssemblies
            // 
            this.txtAssemblies.Location = new System.Drawing.Point(172, 194);
            this.txtAssemblies.Multiline = true;
            this.txtAssemblies.Name = "txtAssemblies";
            this.txtAssemblies.Size = new System.Drawing.Size(453, 119);
            this.txtAssemblies.TabIndex = 16;
            // 
            // txtDll
            // 
            this.txtDll.Location = new System.Drawing.Point(172, 74);
            this.txtDll.Multiline = true;
            this.txtDll.Name = "txtDll";
            this.txtDll.Size = new System.Drawing.Size(453, 114);
            this.txtDll.TabIndex = 15;
            // 
            // btnAssembly
            // 
            this.btnAssembly.Location = new System.Drawing.Point(31, 194);
            this.btnAssembly.Name = "btnAssembly";
            this.btnAssembly.Size = new System.Drawing.Size(135, 119);
            this.btnAssembly.TabIndex = 14;
            this.btnAssembly.Text = "Assemblies in this App";
            this.btnAssembly.UseVisualStyleBackColor = true;
            // 
            // btnDLL
            // 
            this.btnDLL.Location = new System.Drawing.Point(31, 74);
            this.btnDLL.Name = "btnDLL";
            this.btnDLL.Size = new System.Drawing.Size(135, 114);
            this.btnDLL.TabIndex = 13;
            this.btnDLL.Text = "Types within the DLL";
            this.btnDLL.UseVisualStyleBackColor = true;
            // 
            // btncollection
            // 
            this.btncollection.Location = new System.Drawing.Point(31, 319);
            this.btncollection.Name = "btncollection";
            this.btncollection.Size = new System.Drawing.Size(135, 121);
            this.btncollection.TabIndex = 12;
            this.btncollection.Text = "ArrayList Collection";
            this.btncollection.UseVisualStyleBackColor = true;
            // 
            // btnString
            // 
            this.btnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnString.Location = new System.Drawing.Point(112, 28);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 31);
            this.btnString.TabIndex = 11;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(31, 28);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 31);
            this.btnDouble.TabIndex = 10;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            // 
            // Reflection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 478);
            this.Controls.Add(this.txtCollection);
            this.Controls.Add(this.txtAssemblies);
            this.Controls.Add(this.txtDll);
            this.Controls.Add(this.btnAssembly);
            this.Controls.Add(this.btnDLL);
            this.Controls.Add(this.btncollection);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnDouble);
            this.Name = "Reflection";
            this.Text = "Reflection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCollection;
        private System.Windows.Forms.TextBox txtAssemblies;
        private System.Windows.Forms.TextBox txtDll;
        private System.Windows.Forms.Button btnAssembly;
        private System.Windows.Forms.Button btnDLL;
        private System.Windows.Forms.Button btncollection;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnDouble;
    }
}