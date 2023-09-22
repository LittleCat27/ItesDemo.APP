using ItesDemo.APP.Models;
using ItesDemo.APP.ViewModels;

namespace ItesDemo.APP.Views;

public partial class ProductoDetallePage : ContentPage
{
	public ProductoDetallePage(ProductoModel seleccion)
	{
		InitializeComponent();
		ProductoDetalleViewModel viewModel = new ProductoDetalleViewModel();
		viewModel.ProductoSeleccion = seleccion;
		BindingContext = viewModel;
	}
}