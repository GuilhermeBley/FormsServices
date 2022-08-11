namespace FormsServices.Client.Forms
{
    partial class Form2
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
            this.ListView1 = new System.Windows.Forms.ListView();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Location = new System.Drawing.Point(12, 12);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(776, 218);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(640, 369);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(148, 69);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Get random numbers";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ListView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ListView1;
        private Button Button1;
    }
}