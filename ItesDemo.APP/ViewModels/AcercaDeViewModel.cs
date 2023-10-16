using System;
using System.Windows.Input;

namespace ItesDemo.APP.ViewModels;

public class AcercaDeViewModel : BaseViewModel
{
    #region VARIABLES
    private string myVar;
    #endregion

    #region CONSTRUCTOR
    public AcercaDeViewModel()
    {
    }
    #endregion

    #region OBJETOS
    public string MyProperty
    {
        get { return myVar; }
        set { SetProperty(ref myVar, value); }
    }
    #endregion

    #region METODOS
    private void SimpleMetodo()
    {

    }

    private async Task ProcesoAsync()
    {

    }
    #endregion

    #region COMANDOS
    public ICommand ProcesoAsyncComando => new Command(async () => await ProcesoAsync());
    public ICommand ProcesoSimpleComando => new Command(SimpleMetodo);
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    async void OnButtonClicked(object sender, EventArgs args)
    {
        await Launcher.OpenAsync("https://github.com/LittleCat27/ItesDemo.APP");
    }


    #endregion
}
