using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Applications.Common;

public class ObservableObject :
  INotifyPropertyChanging,
  INotifyPropertyChanged
{
    public event PropertyChangingEventHandler? PropertyChanging;
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void SetProperty<T>(ref T property, T newValue, [CallerMemberName] string? callerMemberName = null)
    {
      if(Equals(property, newValue))
        return;

      OnPropertyChanging(callerMemberName);

      property = newValue;

      OnPropertyChanged(callerMemberName);
    }

    protected virtual void OnPropertyChanging([CallerMemberName] string? callerMemberName = null)
    {
      PropertyChangingEventHandler? handler = PropertyChanging;

      handler?.Invoke(this, new PropertyChangingEventArgs(callerMemberName));
    }
    protected virtual void OnPropertyChanged([CallerMemberName] string? callerMemberName = null)
    {
      PropertyChangedEventHandler? handler = PropertyChanged;

      handler?.Invoke(this, new PropertyChangedEventArgs(callerMemberName));
    }
}
