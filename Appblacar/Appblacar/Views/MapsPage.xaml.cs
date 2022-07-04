using Appblacar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Appblacar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();

            ViajeModel viaje = new ViajeModel
            {
                ID = 1,
                Name = "loki",
                Latitud = 10.354465412342,
                Longitud = -1.349358538932
            };

            MapControl.MoveToRegion(
               MapSpan.FromCenterAndRadius(
               new Position(
                   viaje.Latitud,
                   viaje.Longitud
                   ), Distance.FromMiles(.5)
                   )
               ); ;

            MapControl.Pins.Add(
                new Pin
                {
                    Type = PinType.Place,
                    Label = viaje.Name,
                    Position = new Position(
                        viaje.Latitud,
                        viaje.Longitud
                        )
                }
                );
        }
    }
}