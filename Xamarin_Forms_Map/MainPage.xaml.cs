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
            //Position position = new Position(36.9628066, -122.0194722);
            //MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            //Map map = new Map(mapSpan);
            Map map = new Map();
            Content = map;
        }
    }
}
