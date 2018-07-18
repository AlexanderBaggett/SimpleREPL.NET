using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace REPL
{
    public partial class Form1 : Form
    {
        string ConsoleInputRequested = ">>";
        IReplEnabled LanguageInterface;
        public Form1(IReplEnabled languageInterface)
        {
            InitializeComponent();

            Repl.KeyDown += Repl_KeyDown;
            Repl.Text = "";
            ReplConsole.Items.Add(ConsoleInputRequested);
            this.LanguageInterface = languageInterface;
        }

        private void Repl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                UpdateConsoleUI();
            }
        }

        private void UpdateConsoleUI()
        {
            var lastItem = ReplConsole.Items.Count - 1;
            ReplConsole.Items[lastItem] = ReplConsole.Items[lastItem].ToString() + Repl.Text;
            var valid =  this.LanguageInterface.CheckIfValidCommand(Repl.Text);
            if(valid.Key)
            {
                this.CommandList.Items.Add(Repl.Text);
            }
            ReplConsole.Items.Add(valid.Value);//this could be error messages or letting them know a value was set.
            Repl.Text = "";
            ReplConsole.Items.Add(ConsoleInputRequested);
        }

        private void CheckCommands(string text)
        {
            if(true)
            {
                CommandList.Items.Add(text);
            }
        }
       
    }
    public interface IReplEnabled
    {
        KeyValuePair<bool,string> CheckIfValidCommand(string commandText);
        Dictionary<string, string> GetVariables();
        TreeView GetAst();
    }
}
