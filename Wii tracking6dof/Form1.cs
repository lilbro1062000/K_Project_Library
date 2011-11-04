using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WiimoteLib;
using System.Threading;

namespace Wii_tracking6dof
{
    public partial class Form1 : Form
    {
        bool connected;
        Wii_stuff w = new Wii_stuff();
        public Form1()
        {
            InitializeComponent();
            Thread wii_thread = new Thread(new ThreadStart(w.wii_stuff));

            
            
        }
     
    }
}
