using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordAddIn1
{
    public partial class UserControl1 : UserControl
    {

        private UmlDiagram diagram = null;
        public UmlDiagram Diagram
        {
            set
            {
                diagram = value;
                populateFields();
            }
            get
            {
                return diagram;
            }
        }

        public DiagramController controller;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Diagram != null)
            {
                Diagram.script = textBox1.Lines;

                if (checkBoxScruffy.Checked)
                {
                    Diagram.Style = "scruffy";
                }
                else Diagram.Style = "square";

                if (radioButtonClass.Checked) Diagram.Type = "class";
                else if (radioButtonActivity.Checked) Diagram.Type = "activity";
                else if (radioButtonUseCase.Checked) Diagram.Type = "usecase";

                controller.insertDiagram(Diagram);
            }


        }

        /**
         * populates the forms field with data extracted from the uml diagram.  
         */
        private void populateFields()
        {
            if (Diagram == null)
            {
                //populate all fields with blank or default values
                this.textBox1.Lines = null;
            }
            else 
            {
                this.textBox1.Lines = Diagram.script;

                this.checkBoxScruffy.Checked = Diagram.Style.Equals("scruffy");

                this.radioButtonActivity.Checked = Diagram.Type.Equals("activity");
                this.radioButtonUseCase.Checked = Diagram.Type.Equals("usecase");
                this.radioButtonClass.Checked = Diagram.Type.Equals("class");

            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
