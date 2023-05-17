/*   SmartReport License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2023 Luciano Gorosito <lucianogorosito@hotmail.com>        *
*                                                                             *
*    This file is part of SmartReport                                         *
*                                                                             *
*    SamrtReport is free software: you can redistribute it and/or modify      *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    SmartReport is distributed in the hope that it will be useful,           *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;

namespace SmartReport
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class App : Autodesk.Revit.UI.IExternalApplication
    {
        static Autodesk.Revit.DB.AddInId m_appId = new Autodesk.Revit.DB.AddInId(new Guid("58cdfc31-550e-4f88-a700-f0d1c1fd1ec5"));
        //get the absolute path of this assembly
        public static string ExecutingAssemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public static string AppDirectory = System.IO.Path.GetDirectoryName(ExecutingAssemblyPath);

        public Result OnStartup(UIControlledApplication application)
        {
            AddMenu(application);
            return Autodesk.Revit.UI.Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Autodesk.Revit.UI.Result.Succeeded;
        }

        private void AddMenu(UIControlledApplication app)
        {
            Autodesk.Revit.UI.RibbonPanel SRPanel = app.CreateRibbonPanel("SmartReport");
            //IMPORTANT NOTE: las imagenes de los botones deben tener su propiedad "Build Action" como Resource.

            //Add button to the Panel
            PushButton button3 = SRPanel.AddItem(new PushButtonData("SR1", "Create Report",
                ExecutingAssemblyPath, "SmartReport.Main")) as PushButton;

            button3.LargeImage = new BitmapImage(new Uri("pack://application:,,,/SmartReport;component/Resources/document_prepare.png"));
            button3.ToolTip = "...";
            button3.LongDescription = "...";

            string path;
            path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            ContextualHelp contextHelp = new ContextualHelp(ContextualHelpType.ChmFile,
                "http://www.universobim.com/"); // hard coding for simplicity. 

            button3.SetContextualHelp(contextHelp);
        }
    }
}
