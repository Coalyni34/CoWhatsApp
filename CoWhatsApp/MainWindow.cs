using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoWhatsApp
{
    public partial class MainWindow : Form
    {
        private readonly string cowUrl = "https://web.whatsapp.com/";
        public MainWindow()
        {
            InitializeComponent();
            cowBrowser.Load(cowUrl);
        }
    }
}
