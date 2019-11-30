using System.ComponentModel;

namespace FileEncryptor.UI.Enums
{
    public enum OpenFileDialogFilterEnum
    {
        [Description("Lch files (*.lch)|*.lch")]
        LchFiles,

        [Description("All files (*.*)|*.*")]
        AllFiles
    }
}
