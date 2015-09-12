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
            return new LoginForm() { StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen};
        }

        public static MainForm CreateMainForm()
        {
            return new MainForm();
        }


    }
}
