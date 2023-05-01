using System.Windows.Forms;

namespace RustCodeGeneratorForms;

public partial class Form_Alert : Form
{
    public enum enmAction
    {
        wait,
        start,
        close
    }

    public enum enmType
    {
        Success,
        Warning,
        Error,
        Info
    }

    private enmAction action;

    public Form_Alert()
    {
        InitializeComponent();
    }

    private int x, y;

    public void showAlert(string msg, enmType type)
    {
        Opacity = 1.0;
        StartPosition = FormStartPosition.Manual;
        Focus();
        TopMost = true;
        string fname;

        for (var i = 1; i < 10; i++)
        {
            fname = "alert" + i.ToString();
            var frm = (Form_Alert)Application.OpenForms[fname];

            if (frm == null)
            {
                Name = fname;
                x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                y = Screen.PrimaryScreen.WorkingArea.Height - Height * i + 5 * i;
                Location = new Point(x, y);
                break;
            }
        }

        x = Screen.PrimaryScreen.WorkingArea.Width - Width + 50;

        switch (type)
        {
            case enmType.Error:
                // this.pictureBox1.Image = Resources.error;
                BackColor = Color.DarkRed;
                break;
            case enmType.Info:
                // this.pictureBox1.Image = Resources.info;
                BackColor = Color.RoyalBlue;
                break;
            case enmType.Warning:
                // this.pictureBox1.Image = Resources.warning;
                BackColor = Color.DarkOrange;
                break;
        }

        label1.Text = msg;
        Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Form_Alert_Load(object sender, EventArgs e)
    {
    }
}