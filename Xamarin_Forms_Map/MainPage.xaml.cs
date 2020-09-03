using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Xamarin_Forms_Map
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Position position = new Position(41.7377780, -111.8308331);
            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            Map map = new Map(mapSpan)
            {
                //MapType = MapType.Hybrid
                // potrentially add funcitonality to switch back to street maptype, IDK why you would though
            };

            Content = map;
        }
    }
}
