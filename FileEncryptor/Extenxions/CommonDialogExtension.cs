using System;
using System.Windows.Forms;

namespace FileEncryptor.UI.Extenxions
{
    public static class CommonDialogExtension
    {
        public static CommonDialog DialogResultIsOK(this CommonDialog dialog, Action callback)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
                callback();

            return dialog;
        }
    }
}
