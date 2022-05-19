using System.ComponentModel;
using System.Runtime.CompilerServices;
using InternalLibrary.Annotations;

namespace InternalLibrary.ObservableObjectVm;

public class ObserverObject : INotifyPropertyChanged
{
    [field: NonSerialized]
    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        if (propertyChanged == null)
            return;
        propertyChanged((object) this, e);
    }
    
    /// <summary>
    /// Raises the PropertyChange event for the property specified
    /// </summary>
    /// <param name="propertyName">Property name to update. Is case-sensitive.</param>
    public virtual void RaisePropertyChanged(string propertyName)
    {
        OnPropertyChanged(propertyName);
    }
    public void RaiseAllPropertiesChanged() => this.OnPropertyChanged(new PropertyChangedEventArgs(""));
}