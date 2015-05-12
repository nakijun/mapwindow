using System;
using System.Windows.Forms;
using MapWinGIS;
using MWLite.GUI.Forms;
using System.Runtime.InteropServices;

namespace MWLite.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                InitGlobalSettings();
                // Application.Run(new LoaderForm());
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start: " + ex.Message);
            }
        }

        public static void InitGlobalSettings()
        {
            var gs = new GlobalSettings();
            gs.ZoomToFirstLayer = true;
            gs.OgrLayerMaxFeatureCount = 25000;
            gs.AllowLayersWithoutProjections = true;
            gs.AllowProjectionMismatch = false;
            gs.ReprojectLayersOnAdding = false;
            gs.OgrLayerForceUpdateMode = true;
            //gs.TilesThreadPoolSize = 1;
            //gs.SetHereMapsApiKey("", "");
            //gs.BingApiKey = "";
        }
    }
}
