using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Word;
using System.Drawing;
using System.Drawing.Imaging;

namespace WordAddIn1
{
    /**
     * Diagram controller should be document level i.e. one per document.
     */
    public class DiagramController
    {
        private Microsoft.Office.Tools.CustomTaskPane taskPane;
        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                if(taskPane == null) taskPane = Globals.ThisAddIn.CustomTaskPanes.Add(UserControl, "yUML.me Editor");
                return taskPane;
            }
        }

        private UserControl1 userControl;
        public UserControl1 UserControl{
            get{
                if (userControl == null)
                {
                    userControl = new UserControl1();
                    userControl.controller = this;
                }
                return userControl;
            }
        }

        
        
        public DiagramController()
        {
            
            
            //myCustomTaskPane.Visible = true;
            Microsoft.Office.Tools.Word.Document vstoDoc = Globals.Factory.GetVstoObject(
                Globals.ThisAddIn.Application.ActiveDocument
            );
            vstoDoc.SelectionChange += new Microsoft.Office.Tools.Word.SelectionEventHandler(
                this.ThisDocument_SelectionChange
            );
        }

        public void Button_Click(Object sender, RibbonControlEventArgs e)
        {
            if (sender == Globals.Ribbons.GetRibbon<Ribbon1>().classButton) insertDiagram("class");
            if (sender == Globals.Ribbons.GetRibbon<Ribbon1>().activityButton) insertDiagram("activity");
            if (sender == Globals.Ribbons.GetRibbon<Ribbon1>().usecaseButton) insertDiagram("usecase");
            if (sender == Globals.Ribbons.GetRibbon<Ribbon1>().editButton) showTaskPane();//TODO update task pane with selection   
        }

        public void insertDiagram(String type)
        {
            if (type == null) type = "class";

            UmlDiagram uml = new UmlDiagram(type);//"class");
            insertDiagram(uml);

            
            //currentSelection.TypeText(shape.AlternativeText);
            //currentSelection.TypeParagraph();
        }

        public void insertDiagram(UmlDiagram uml)
        {
            try
            {

                Selection currentSelection = Globals.ThisAddIn.Application.Selection;
                InlineShape shape;
                try
                {
                    shape = currentSelection.InlineShapes.AddPicture(uml.getDiagramUrl());
                }
                catch (Exception e)
                {
                    String file = "c:/temp/yumlerror.png";//hack to extract image to file system. Stupid API. 
                    Image error = (System.Drawing.Image)Properties.Resources.ErrorImage;
                    error.Save(file, ImageFormat.Png);
                    shape = currentSelection.InlineShapes.AddPicture(file);
                }


                shape.AlternativeText = uml.getAltTextString();
                shape.Select();

                showTaskPane();
                userControl.Diagram = uml;
            }
            catch (Exception e) { }
            
        }

        private void showTaskPane()
        {
            TaskPane.Visible = true;
        }

        public void ThisDocument_SelectionChange(object sender, Microsoft.Office.Tools.Word.SelectionEventArgs e)
        {
            
            if (TaskPane.Visible)
            {//only bother updating if there's something to put data into. 
                if (e.Selection.Type == WdSelectionType.wdSelectionInlineShape)
                {
                    InlineShapes shapes = e.Selection.InlineShapes;

                    if (shapes.Count > 0)
                    {
                        //InlineShape selectedShape;
                        foreach (InlineShape shape in shapes)
                        {
                            //selectedShape = shape;
                            userControl.Diagram = UmlDiagram.parseAltText(shape.AlternativeText);
                        }


                    }
                }
                else
                {
                    userControl.Diagram = null;
                }
                
            }
        }
    }

    
}
