using System.Windows.Forms;

namespace Applications.Common
{
  public class DialogServices
  {
    public DialogResult GetDialogResult()
    {
      return DialogResult.OK;
    }

    public DialogResult ShowInformation()
    {
      return MessageBox.Show("", "Information: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public DialogResult ShowWarning()
    {
      return MessageBox.Show("Warning: ", "Warning", MessageBoxButtons.OK);
    }
  }
}
