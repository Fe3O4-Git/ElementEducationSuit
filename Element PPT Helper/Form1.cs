using System;
using System.Drawing;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace Element_PPT_Helper
{
    public partial class PPTControlForm : Form
    {
        PowerPoint.SlideShowView pptView;

        enum pointerTypes
        {
            pointer,
            pen,
            eraser,
        }

        public PPTControlForm()
        {
            InitializeComponent();
        }

        private void switchPointer(pointerTypes pointerType)
        {
            PowerPoint.PpSlideShowPointerType newPointerType = PowerPoint.PpSlideShowPointerType.ppSlideShowPointerAutoArrow;
            switch (pointerType)
            {
                case pointerTypes.pen:
                    newPointerType = PowerPoint.PpSlideShowPointerType.ppSlideShowPointerPen;
                    break;
                case pointerTypes.eraser:
                    newPointerType = PowerPoint.PpSlideShowPointerType.ppSlideShowPointerEraser;
                    break;
            }
            pptView.PointerType = newPointerType;
        }

        private void PPTControlForm_Load(object sender, EventArgs e)
        {
            pptView = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View;
            Rectangle bounds = Screen.GetBounds(this);
            this.Top = bounds.Height - this.Height;
            this.Left = 0;
            this.Width = bounds.Width;
            SwitchToPointerButton.Left = (this.Width - SwitchToPointerButton.Width - SwitchToPenButton.Width - SwitchToEraserButton.Width - ExitButton.Width) / 2;
            SwitchToPenButton.Left = SwitchToPointerButton.Left + SwitchToPointerButton.Width;
            SwitchToEraserButton.Left = SwitchToPenButton.Left + SwitchToPenButton.Width;
            ExitButton.Left = SwitchToEraserButton.Left + SwitchToEraserButton.Width;
            NextPageButton.Left = this.Width - NextPageButton.Width;
            PreviousPageButton.Left = NextPageButton.Left - PreviousPageButton.Width;
        }

        private void SwitchToPointerButton_Click(object sender, EventArgs e)
        {
            switchPointer(pointerTypes.pointer);
        }

        private void SwitchToPenButton_Click(object sender, EventArgs e)
        {
            switchPointer(pointerTypes.pen);
        }

        private void SwitchToEraserButton_Click(object sender, EventArgs e)
        {
            switchPointer(pointerTypes.eraser);
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            pptView.Previous();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            pptView.Next();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            pptView.Exit();
        }

        private void PPTControlForm_VisibleChanged(object sender, EventArgs e)
        {
            PPTControlForm_Load(sender, e);
        }
    }
}
