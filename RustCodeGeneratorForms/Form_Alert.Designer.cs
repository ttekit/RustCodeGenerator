using System.ComponentModel;

namespace RustCodeGeneratorForms;

partial class Form_Alert
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        components = new Container();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        button1 = new Button();
        timer1 = new System.Windows.Forms.Timer(components);
        ((ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImageLayout = ImageLayout.None;
        pictureBox1.Image = Properties.Resources._2312312;
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(128, 128);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(174, 12);
        label1.Name = "label1";
        label1.Size = new Size(120, 50);
        label1.TabIndex = 1;
        label1.Text = "label1";
        // 
        // button1
        // 
        button1.BackColor = Color.Transparent;
        button1.BackgroundImage = Properties.Resources.Screenshot_4591;
        button1.BackgroundImageLayout = ImageLayout.Stretch;
        button1.CausesValidation = false;
        button1.Cursor = Cursors.Cross;
        button1.FlatAppearance.BorderColor = Color.White;
        button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 255);
        button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
        button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        button1.ForeColor = Color.White;
        button1.Location = new Point(164, 68);
        button1.Name = "button1";
        button1.Size = new Size(378, 57);
        button1.TabIndex = 2;
        button1.Text = "Close";
        button1.UseVisualStyleBackColor = false;
        button1.FlatStyle = FlatStyle.Flat;
        button1.FlatAppearance.BorderSize = 0;
        button1.Click += button1_Click;
        // 
        // Form_Alert
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(554, 155);
        Controls.Add(button1);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form_Alert";
        Text = "Form_Alert";
        Load += Form_Alert_Load;
        ((ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Button button1;
    private System.Windows.Forms.Timer timer1;
}