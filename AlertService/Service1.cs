using System;
using System.ServiceProcess;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSCreateProcessAsUserFromService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            MessageBox.Show("A message from AlertService.");
        }

        protected override void OnStop()
        {
        }

        // This thread function would launch a child process 
        // in the interactive session of the logged-on user.
        public static void MyThreadFunc()
        {
            CreateProcessAsUserWrapper.LaunchChildProcess("C:\\Windows\\notepad.exe");
        }
    }
}
