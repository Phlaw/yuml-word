namespace WordAddIn1
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.checkBoxScruffy = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonClass = new System.Windows.Forms.RadioButton();
            this.radioButtonActivity = new System.Windows.Forms.RadioButton();
            this.radioButtonUseCase = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(285, 257);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(105, 307);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // checkBoxScruffy
            // 
            this.checkBoxScruffy.AutoSize = true;
            this.checkBoxScruffy.Checked = true;
            this.checkBoxScruffy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScruffy.Location = new System.Drawing.Point(105, 276);
            this.checkBoxScruffy.Name = "checkBoxScruffy";
            this.checkBoxScruffy.Size = new System.Drawing.Size(59, 17);
            this.checkBoxScruffy.TabIndex = 2;
            this.checkBoxScruffy.Text = "Scruffy";
            this.checkBoxScruffy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUseCase);
            this.groupBox1.Controls.Add(this.radioButtonActivity);
            this.groupBox1.Controls.Add(this.radioButtonClass);
            this.groupBox1.Location = new System.Drawing.Point(3, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagram Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.AutoSize = true;
            this.radioButtonClass.Checked = true;
            this.radioButtonClass.Location = new System.Drawing.Point(12, 20);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(50, 17);
            this.radioButtonClass.TabIndex = 0;
            this.radioButtonClass.TabStop = true;
            this.radioButtonClass.Text = "Class";
            this.radioButtonClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonActivity
            // 
            this.radioButtonActivity.AutoSize = true;
            this.radioButtonActivity.Location = new System.Drawing.Point(12, 44);
            this.radioButtonActivity.Name = "radioButtonActivity";
            this.radioButtonActivity.Size = new System.Drawing.Size(59, 17);
            this.radioButtonActivity.TabIndex = 1;
            this.radioButtonActivity.Text = "Activity";
            this.radioButtonActivity.UseVisualStyleBackColor = true;
            // 
            // radioButtonUseCase
            // 
            this.radioButtonUseCase.AutoSize = true;
            this.radioButtonUseCase.Location = new System.Drawing.Point(12, 68);
            this.radioButtonUseCase.Name = "radioButtonUseCase";
            this.radioButtonUseCase.Size = new System.Drawing.Size(71, 17);
            this.radioButtonUseCase.TabIndex = 2;
            this.radioButtonUseCase.Text = "Use Case";
            this.radioButtonUseCase.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxScruffy);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(291, 403);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.CheckBox checkBoxScruffy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUseCase;
        private System.Windows.Forms.RadioButton radioButtonActivity;
        private System.Windows.Forms.RadioButton radioButtonClass;
    }
}
