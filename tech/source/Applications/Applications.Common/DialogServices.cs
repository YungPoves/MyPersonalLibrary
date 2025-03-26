using System.Windows.Forms;

namespace Applications.Common
{
  public class DialogServices
  {
    public DialogResult GetConfirmation(string message)
    {
      return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
    }

    public void ShowException(string message, Exception exc)
    {
      MessageBox.Show($"{message}, {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void ShowInformation(string message)
    {
      MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void ShowError(string message)
    {
      MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
