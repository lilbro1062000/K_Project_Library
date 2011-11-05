using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiimoteLib;

namespace Wii_tracking6dof
{
    class Wii_stuff
    {
        bool connected;
        public void wii_stuff()
        { 
            // create a new instance of the Wiimote
            Wiimote wm = new Wiimote();

            // setup the event to handle state changes
            wm.WiimoteChanged += new EventHandler<WiimoteChangedEventArgs>(wm_WiimoteChanged);

            // setup the event to handle insertion/removal of extensions
            wm.WiimoteExtensionChanged += new EventHandler<WiimoteExtensionChangedEventArgs>(wm_WiimoteExtensionChanged);

            // connect to the Wiimote
            connected = false;
            check_for_wii_remotes(wm);

            // set the report type to return the IR sensor and accelerometer data (buttons always come back)

            wm.SetReportType(InputReport.IRAccel, true);
        }

        public string  check_for_wii_remotes(Wiimote wm)
        {
           
                try
                {
                    wm.Connect();
                    connected = true;
                    return "Connected";

                }
                catch (WiimoteLib.WiimoteNotFoundException ex)
                {
                    return ex.Message;

                }

           
        }

        void wm_WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void wm_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
