using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ExamenApp2.Modelo;
using Microsoft.Maui.Controls;

namespace ExamenApp2.ViewModel
{
    public class ProveedoresPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Proveedor> _proveedores;
        public ObservableCollection<Proveedor> Proveedores
        {
            get { return _proveedores; }
            set
            {
                _proveedores = value;
                OnPropertyChanged();
            }
        }

        private Proveedor _nuevoProveedor;
        public Proveedor NuevoProveedor
        {
            get { return _nuevoProveedor; }
            set
            {
                _nuevoProveedor = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarProveedorCommand { get; }
        public ICommand EliminarProveedorCommand { get; }

        public ProveedoresPageViewModel()
        {
            Proveedores = new ObservableCollection<Proveedor>();
            NuevoProveedor = new Proveedor();

            AgregarProveedorCommand = new Command(AgregarProveedor);
            EliminarProveedorCommand = new Command<Proveedor>(EliminarProveedor);
        }

        private void AgregarProveedor()
        {
            Proveedores.Add(NuevoProveedor);
            NuevoProveedor = new Proveedor(); // Reinicia el proveedor para agregar uno nuevo
        }

        private void EliminarProveedor(Proveedor proveedor)
        {
            Proveedores.Remove(proveedor);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
