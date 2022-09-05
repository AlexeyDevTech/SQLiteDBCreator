using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SQLiteDBCreator.VMs
{
    public class MainWindowViewModel : BindableBase
    {
        public ICommand ExitCommand { get; set; }
        public ICommand AboutProgrammCommand { get; set; }
        public MainWindowViewModel()
        {
            ExitCommand = new DelegateCommand(ExitAction);
            AboutProgrammCommand = new DelegateCommand(AboutProgrammAction);
        }

        private void AboutProgrammAction()
        {
            //about programm window...
        }

        private void ExitAction()
        {
            App.Current.Shutdown();
        }
    }
}
