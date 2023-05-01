using System.Management;

namespace RustCodeGeneratorForms;

public partial class Form1 : Form
{
    private const string FullPath = @"C:\temp\rustPassword.txt";
    private Form_Alert frm;

    public Form1()
    {
        InitializeComponent();
        SetupEventWatcher();
        frm = new Form_Alert();
    }

    private void SetupEventWatcher()
    {
        const string tick = "0.1";
        const string lcuProcess = "Rust.exe";
        const string gameProcess = "RustClient.exe";
        const string queryPattern = @"
    SELECT * 
    FROM __InstanceOperationEvent 
    WITHIN {0} 
    WHERE TargetInstance ISA 'Win32_Process' 
    AND (TargetInstance.Name = '{1}' OR TargetInstance.Name = '{2}')";

        var query = string.Format(queryPattern, tick, lcuProcess, gameProcess);
        var scope = @"\\.\root\CIMV2";

        var watcher = new ManagementEventWatcher(scope, query);
        watcher.EventArrived += OnEventArrived;
        watcher.Start();
    }

    private void OnEventArrived(object sender, EventArrivedEventArgs e)
    {
        var dateTime = DateTime.Today;
        if (dateTime.DayOfWeek == DayOfWeek.Monday)
            if (e.NewEvent.ClassPath.ClassName.Contains("InstanceCreationEvent"))
            {
                var random = new Random();
                var res = "";
                for (var i = 0; i < 4; i++) res += random.Next(0, 9);

                Invoke(() => frm.showAlert(res, Form_Alert.enmType.Success));

                File.WriteAllText(FullPath, res);
            }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Hide();
    }

    private void From1_Shown(object sender, EventArgs e)
    {
        Hide();
    }
}