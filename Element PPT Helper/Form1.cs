using System;
using System.Drawing;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace Element_PPT_Helper
{
    public partial class PPTControlForm : Form
    {
        PowerPoint.Application app = Globals.ThisAddIn.Application;

        public PPTControlForm()
        {
            InitializeComponent();
        }

        private void switchPointer(PowerPoint.PpSlideShowPointerType pointerType)
        {
            app.ActivePresentation.SlideShowWindow.View.PointerType = pointerType;
        }

        private void PPTControlForm_Load(object sender, EventArgs e)
        {
            Rectangle bounds = Screen.GetBounds(this);
            this.Top = bounds.Height - this.Height;
            this.Left = 0;
            this.Width = bounds.Width;
        }

        private void SwitchToPointerButton_Click(object sender, EventArgs e)
        {
            switchPointer(PowerPoint.PpSlideShowPointerType.ppSlideShowPointerAutoArrow);
        }

        private void SwitchToPenButton_Click(object sender, EventArgs e)
        {
            switchPointer(PowerPoint.PpSlideShowPointerType.ppSlideShowPointerPen);
        }

        private void SwitchToEraserButton_Click(object sender, EventArgs e)
        {
            switchPointer(PowerPoint.PpSlideShowPointerType.ppSlideShowPointerEraser);
        }
    }
}
