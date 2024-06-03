using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI_QLGH.Report
{
    public partial class rpDSNN : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDSNN()
        {
            InitializeComponent();
        }
        private GridControl control;
        public GridControl GridControl
        {
            get
            {
                return control;
            }
            set
            {
                control = value;
                printableCC.PrintableComponent = control;
            }
        }
    }
}
