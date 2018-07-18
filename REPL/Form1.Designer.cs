namespace REPL
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReplConsole = new System.Windows.Forms.ListBox();
            this.Repl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VariableList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AstView = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReplConsole
            // 
            this.ReplConsole.FormattingEnabled = true;
            this.ReplConsole.Location = new System.Drawing.Point(-2, 24);
            this.ReplConsole.Name = "ReplConsole";
            this.ReplConsole.Size = new System.Drawing.Size(485, 511);
            this.ReplConsole.TabIndex = 0;
            // 
            // Repl
            // 
            this.Repl.Location = new System.Drawing.Point(-2, 543);
            this.Repl.Multiline = true;
            this.Repl.Name = "Repl";
            this.Repl.Size = new System.Drawing.Size(895, 30);
            this.Repl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eval";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "REPL";
            // 
            // CommandList
            // 
            this.CommandList.FormattingEnabled = true;
            this.CommandList.Location = new System.Drawing.Point(489, 24);
            this.CommandList.Name = "CommandList";
            this.CommandList.Size = new System.Drawing.Size(485, 264);
            this.CommandList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Accepted Commands";
            // 
            // VariableList
            // 
            this.VariableList.FormattingEnabled = true;
            this.VariableList.Location = new System.Drawing.Point(489, 310);
            this.VariableList.Name = "VariableList";
            this.VariableList.Size = new System.Drawing.Size(135, 225);
            this.VariableList.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Variables";
            // 
            // AstView
            // 
            this.AstView.Location = new System.Drawing.Point(630, 310);
            this.AstView.Name = "AstView";
            this.AstView.Size = new System.Drawing.Size(344, 227);
            this.AstView.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "AST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 573);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AstView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VariableList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CommandList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Repl);
            this.Controls.Add(this.ReplConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ReplConsole;
        private System.Windows.Forms.TextBox Repl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CommandList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox VariableList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView AstView;
        private System.Windows.Forms.Label label5;
    }
}

