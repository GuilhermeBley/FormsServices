namespace FormsServices.Client.Forms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(107, 73);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Open Form2";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(160, 12);
            this.Label1.Name = "label1";
            this.Label1.Size = new System.Drawing.Size(50, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button Button1;
    private Label Label1;
}
