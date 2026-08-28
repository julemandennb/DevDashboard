using System.Threading.Tasks;
using SystemMonitor;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

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

                 var SystemInfo = systems[1].SystemInfos();

                if(SystemInfo[0] is DtoSystemInfoRam ram)
                {
                    var fsfse = ram.Manufacturer;
                }

               
            });
        }
    }
}
