using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIS_Vulcan_Canning.Classes
{
    class Labels
    {
        public static string setupCanningTag()
        {
            try
            {
                string labelName = string.Empty;
                DirectoryInfo configDirectory = new DirectoryInfo(GlobalVars.canningLoc);
                FileInfo[] allLabels = configDirectory.GetFiles("*.repx");
                foreach (FileInfo label in allLabels)
                {
                    labelName = label.Name;
                }

                if (labelName != string.Empty)
                {
                    GlobalVars.canningTag = XtraReport.FromFile(GlobalVars.canningLoc + labelName, true);
                    return "1*Success";
                }
                else
                {
                    return "0*No zect tags found in the seleced location";
                }
            }
            catch (Exception ex)
            {
                return ExHandler.returnErrorEX(ex);
            }
        }
    }
}
