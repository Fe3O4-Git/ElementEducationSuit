using System;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace Element_PPT_Helper
{
    public partial class ThisAddIn
    {
        PowerPoint.Application app;
        PPTControlForm controlForm;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            app = Globals.ThisAddIn.Application;
            app.SlideShowBegin += App_SlideShowBegin;
            app.SlideShowEnd += App_SlideShowEnd;
            controlForm = new PPTControlForm();
        }

        private void App_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            controlForm.Hide();
        }

        void App_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            controlForm.Show();
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
