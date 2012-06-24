using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Word;

namespace WordAddIn1
{
    public partial class Ribbon1
    {
        

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
            
            classButton.Click += new RibbonControlEventHandler(Button_Click);
            usecaseButton.Click += new RibbonControlEventHandler(Button_Click);
            activityButton.Click += new RibbonControlEventHandler(Button_Click);
            editButton.Click += new RibbonControlEventHandler(Button_Click);
        }

        public void Button_Click(Object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            DiagramController controller;
            ThisAddIn.Controllers.TryGetValue(doc,out controller);
            if (controller == null)//add controller to the controllers.
            {
                controller = new DiagramController();
                ThisAddIn.Controllers.Add(doc, controller);
            }
            controller.Button_Click(sender, e);
        }
    }
}
