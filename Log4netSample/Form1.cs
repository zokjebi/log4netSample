using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using log4net;

namespace Log4netSample
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();

            log.Info("Form1 Start!_1");
            log.Info("Form1 Start!_2");
            log.Info("Form1 Start!_3");
            log.Info("Form1 Start!_4");
            log.Info("Form1 Start!_5");
        }
    }
}
