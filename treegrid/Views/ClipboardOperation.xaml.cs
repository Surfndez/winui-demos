#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.DataGrid;
using Syncfusion.UI.Xaml.Grids;
using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TreeGrid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ClipboardOperation : Page, IDisposable
    {
        public ClipboardOperation()
        {
            this.InitializeComponent();
            var datacontext = new PersonViewModel();
            this.DataContext = datacontext;
            this.PasteList.SelectionChanged += PasteList_SelectionChanged;
            this.CopyList.SelectionChanged += CopyList_SelectionChanged;
            this.CopyList.Loaded += CopyList_Loaded;
            this.PasteList.Loaded += PasteList_Loaded;
            this.sfTreeGrid.ItemsSource = datacontext.Persons;
        }

        /// <summary>
        /// Set the default value for paste option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteList_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            PasteList.SelectedIndex = 1;
        }

        /// <summary>
        /// Set the default value for copy option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyList_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            CopyList.SelectedIndex = 1;
        }

        /// <summary>
        /// Set the value for CopyOption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var data = (sender as ListBox);
            var selecteditem = data.SelectedItems;
            if (data.SelectedItems != null)
            {
                for (int i = 0; i < selecteditem.Count; i++)
                {
                    if (i == 0)
                        this.sfTreeGrid.CopyOption = (GridCopyOptions)selecteditem[i];
                    else
                        this.sfTreeGrid.CopyOption = this.sfTreeGrid.CopyOption | (GridCopyOptions)selecteditem[i];
                }
            }
        }

        /// <summary>
        /// Set the value for Paste Option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var data = (sender as ListBox);
            var selecteditem = data.SelectedItems;
            if (data.SelectedItems != null)
            {

                for (int i = 0; i < selecteditem.Count; i++)
                {
                    if (i == 0)
                        this.sfTreeGrid.PasteOption = (GridPasteOptions)selecteditem[i];
                    else
                        this.sfTreeGrid.PasteOption = this.sfTreeGrid.PasteOption | (GridPasteOptions)selecteditem[i];
                }
            }
        }

        public void Dispose()
        {
            this.Resources.Clear();
            this.PasteList.SelectionChanged -= PasteList_SelectionChanged;
            this.CopyList.SelectionChanged -= CopyList_SelectionChanged;
            this.CopyList.Loaded -= CopyList_Loaded;
            this.PasteList.Loaded -= PasteList_Loaded;
            if (this.sfTreeGrid != null)
            {
                this.sfTreeGrid.Dispose();
                this.sfTreeGrid = null;
                this.DataContext = null;
            }
        }
    }
}
