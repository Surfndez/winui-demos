#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.chartdemos.winui
{
    public class SeriesSelectionChartViewModel : NotificationObject
    {
        public SelectionType SelectionType
        {
            get
            {
                return selectionType;
            }

            set
            {
                selectionType = value;
                RaisePropertyChanged(nameof(SelectionType));
            }
        }

        public Syncfusion.UI.Xaml.Charts.SelectionMode SelectionMode
        {
            get
            {
                return selectionMode;
            }

            set
            {
                selectionMode = value;
                RaisePropertyChanged(nameof(SelectionMode));

                if (selectionMode == Syncfusion.UI.Xaml.Charts.SelectionMode.MouseClick)
                {
                    EnableSelectionStyle = true;
                    EnableSelectionOpacity = 1d;
                }
                else
                {
                    EnableSelectionStyle = false;
                    EnableSelectionOpacity = 0.2d;
                    SelectionType = SelectionType.Single;
                }
            }
        }

        public bool EnableSelectionStyle
        {
            get
            {
                return enableSelectionStyle;
            }

            set
            {
                enableSelectionStyle = value;
                RaisePropertyChanged(nameof(EnableSelectionStyle));
            }
        }

        public double EnableSelectionOpacity
        {
            get
            {
                return enableSelectionOpacity;
            }

            set
            {
                enableSelectionOpacity = value;
                RaisePropertyChanged(nameof(EnableSelectionOpacity));
            }
        }

        public ObservableCollection<Sales> SalesCollection
        {
            get;
        }

        public int Series1SelectedIndex
        {
            get
            {
                return series1SelectedIndex;
            }

            set
            {
                series1SelectedIndex = value;
                RaisePropertyChanged(nameof(Series1SelectedIndex));

                if (series1SelectedIndex != -1)
                {
                    Series2SelectedIndex = -1;
                }
            }
        }

        public int Series2SelectedIndex
        {
            get
            {
                return series2SelectedIndex;
            }

            set
            {
                series2SelectedIndex = value;
                RaisePropertyChanged(nameof(Series2SelectedIndex));

                if (series2SelectedIndex != -1)
                {
                    Series1SelectedIndex = -1;
                }
            }
        }

        private bool enableSelectionStyle;
        private Syncfusion.UI.Xaml.Charts.SelectionMode selectionMode;
        private double enableSelectionOpacity;
        private SelectionType selectionType;
        private int series1SelectedIndex;
        private int series2SelectedIndex;

        public SeriesSelectionChartViewModel()
        {
            SalesCollection = new ObservableCollection<Sales>();
            SalesCollection.Add(new Sales() { Category = "Samsung", Year2013 = 32.5, Year2014 = 28.0 });
            SalesCollection.Add(new Sales() { Category = "Apple", Year2013 = 16.6, Year2014 = 16.4 });
            SalesCollection.Add(new Sales() { Category = "Sony", Year2013 = 4.1, Year2014 = 3.9 });
            SalesCollection.Add(new Sales() { Category = "LG", Year2013 = 4.3, Year2014 = 6.0 });
            SalesCollection.Add(new Sales() { Category = "ZTE", Year2013 = 3.2, Year2014 = 3.1 });

            EnableSelectionStyle = true;
            EnableSelectionOpacity = 1d;
            SelectionMode = Syncfusion.UI.Xaml.Charts.SelectionMode.MouseClick;
            SelectionType = SelectionType.Single;
            Series1SelectedIndex = -1;
            Series2SelectedIndex = -1;
        }

        public static Array SelectionModes
        {
            get
            {
                return Enum.GetValues(typeof(Syncfusion.UI.Xaml.Charts.SelectionMode));
            }
        }
        public static Array SelectionStyles
        {
            get
            {
                return Enum.GetValues(typeof(SelectionType));
            }
        }
    }
}
