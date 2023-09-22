using ItesDemo.APP.Models;
using System.Windows.Input;

namespace ItesDemo.APP.ViewModels;

public class ProductoDetalleViewModel : BaseViewModel
{
    #region VARIABLES
    private string myVar;
    private ProductoModel productoSeleccion;
    #endregion

    #region CONSTRUCTOR
    public ProductoDetalleViewModel()
    {
        Title = "Detalle de Producto";        
    }
    #endregion

    #region OBJETOS
    public ProductoModel ProductoSeleccion
    {
        get { return productoSeleccion; }
        set { SetProperty(ref productoSeleccion, value); }
    }
    #endregion

    #region METODOS   

    private async Task GoToBack()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }
    #endregion

    #region COMANDOS
    public ICommand GoToBackCommand => new Command(async () => await GoToBack());
    // public ICommand ProcesoSimpleComando => new Command(SimpleMetodo);    

    #endregion
}
