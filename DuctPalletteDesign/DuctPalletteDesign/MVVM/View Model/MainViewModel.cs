using DuctPalletteDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuctPalletteDesign.MVVM.View_Model
{
    class MainViewModel:ObservableObject
    {

        public DrawingDetails drawingDetails { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; }
        }

        public MainViewModel()
        {
            drawingDetails = new DrawingDetails();
            CurrentView = drawingDetails;
        }
    }
}
