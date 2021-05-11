using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_Canning.Classes
{
   public  class GlobalVars
    {
        public static string sep = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public static Control lastControl;
        public static string RSCFolder = string.Empty;
        public static string SettingsDB = string.Empty;
        public static string Printer = string.Empty;
        public static string LotLookup = string.Empty;
        public static TextEdit focusedEdit = new TextEdit();
        public enum msgState { Error, Success, Question, First, Info }
        public static string userName { get; set; }

        #region Settings
        public static string ServerIP { get; set; }
        public static string ServerPort { get; set; }
        public static string canningWhse { get; set; }
        public static string canningIT { get; set; }
        public static string canningLoc { get; set; }

        public static XtraReport canningTag { get; set; }
        #endregion

        #region Printing
        public static string itemCode { get; set; }
        public static string itemDesc { get; set; }
        public static string rmCode { get; set; }
        public static string rmDesc { get; set; }
        public static string lotNumber { get; set; }
        public static string qty { get; set; }
        public static string unq { get; set; }
        #endregion

        #region Reprint
        public static string RPitemCode { get; set; }
        public static string RPlotNumber { get; set; }
        #endregion
    }
}
