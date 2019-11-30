using System.ComponentModel;

namespace FileEncryptor.Enums
{
    public enum OpenFileDialogFilterEnum
    {
        [Description("Lch files (*.lch)|*.lch")]
        LchFiles,

        [Description("All files (*.*)|*.*")]
        AllFiles
    }
}
