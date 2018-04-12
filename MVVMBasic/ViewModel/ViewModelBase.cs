using MVVMBasic.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.ViewModel
{
   public class ViewModelBase
    {
        public SimpleCommand SimpleCommand { get; set; }
        public ViewModelBase()
        {
            this.SimpleCommand = new SimpleCommand(this);
        }

        public void SimpleMethod()
        {
            Debug.WriteLine("hello");
        }
    }
}
