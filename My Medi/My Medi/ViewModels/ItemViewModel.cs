﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace My_Medi.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        

        //private string _lineOne;
        ///// <summary>
        ///// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        ///// </summary>
        ///// <returns></returns>
        //public string LineOne
        //{
        //    get
        //    {
        //        return _lineOne;
        //    }
        //    set
        //    {
        //        if (value != _lineOne)
        //        {
        //            _lineOne = value;
        //            NotifyPropertyChanged("LineOne");
        //        }
        //    }
        //}

        //private string _lineTwo;
        ///// <summary>
        ///// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        ///// </summary>
        ///// <returns></returns>
        //public string LineTwo
        //{
        //    get
        //    {
        //        return _lineTwo;
        //    }
        //    set
        //    {
        //        if (value != _lineTwo)
        //        {
        //            _lineTwo = value;
        //            NotifyPropertyChanged("LineTwo");
        //        }
        //    }
        //}

        //private string _lineThree;
        ///// <summary>
        ///// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        ///// </summary>
        ///// <returns></returns>
        //public string LineThree
        //{
        //    get
        //    {
        //        return _lineThree;
        //    }
        //    set
        //    {
        //        if (value != _lineThree)
        //        {
        //            _lineThree = value;
        //            NotifyPropertyChanged("LineThree");
        //        }
        //    }
        //}
        public int Lineone { get; set; }

        public string Linetwo { get; set; }

        public string Linethree { get; set; }
        
        public string LineFour { get; set; }

        public string LineFive { get; set; }

        public string Linesix { get; set; }

        public string Lineseven { get; set; }

        public string Lineeight { get; set; }

        public string Linenine { get; set; }

        public string Lineten { get; set; }


        //public override string ToString()
        //{
        //    return Linethree.ToShortDateString() + " " + Lineseven.ToShortTimeString();
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}