#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace syncfusion.editordemos.winui.Views.CalendarDatePicker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CalendarDatePickerView : Page
    {
        public CalendarDatePickerView()
        {
            this.InitializeComponent();
        }

        private void languages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedLang = languages.SelectedValue.ToString();
            if (Windows.Globalization.Language.IsWellFormed(selectedLang))
            {
                calendarDatePicker3.Language = selectedLang;
            }
        }
    }
}
