using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms.Factories
{
    public class FormFactory
    {
        public static LoginForm CreateLoginForm()
        {
            return new LoginForm();
        }

        public static MainForm CreateMainForm()
        {
            return new MainForm();
        }


    }
}
