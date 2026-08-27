using SystemMonitor;
using SystemMonitor.Interface;
using System.Threading.Tasks;

namespace DevDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            test();
        }

        private void test()
        {
            SystemMonitors systemMonitors = new SystemMonitors();
            _ = Task.Run(async () =>
            {
                var systems = await systemMonitors.GetAll();

                 var fff = systems[1].SystemInfos();

                var fsfse = "fgsefsef";
            });
        }
    }
}
