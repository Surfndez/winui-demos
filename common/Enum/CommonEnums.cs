#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel.DataAnnotations;

namespace syncfusion.demoscommon.winui
{
    /// <summary>
    /// Specifies a control category that should be mentioned in each controls
    /// </summary>
    public enum ControlCategory
    {
        [Display(Name = "GRID")]
        Grids,

        [Display(Name = "DATA VISUALIZATION")]
        DataVisualization,

        [Display(Name = "LAYOUT")]
        Layout,

        [Display(Name = "EDITORS")]
        Editors,

        [Display(Name = "NAVIGATION")]
        Navigation,
        
        [Display(Name = "CALENDARS")]
        Calendars,

        [Display(Name = "NOTIFICATION")]
        Notification,

        [Display(Name = "FILE FORMAT")]
        FileFormat,

        [Display(Name = "REPORTING")]
        Reporting,

        [Display(Name = "BUSINESS INTELLIGENCE")]
        BusinessIntelligence,

        [Display(Name = "DATA SCIENCE")]
        DataScience,

        [Display(Name = "MISCELLANEOUS")]
        Miscellaneous
    }

    /// <summary>
    /// Specifies a control
    /// </summary>
    public enum DemoControl
    {
        [Display(Name = "Data Grid")]
        SfDataGrid,

        [Display(Name = "Tree Grid")]
        SfTreeGrid,
        
        [Display(Name = "Tree View")]
        SfTreeView,
        
        [Display(Name = "Charts")]
        SfChart,

        [Display(Name = "Radial Gauge")]
        SfRadialGauge,

        [Display(Name = "Badge")]
        SfBadge,

        [Display(Name = "Calendar")]
        SfCalendar,

        [Display(Name = "Calendar Date Picker")]
        SfCalendarDatePicker,

        [Display(Name = "Date Picker")]
        SfDatePicker,

        [Display(Name = "Time Picker")]
        SfTimePicker,

        [Display(Name = "Color Picker")]
        SfColorPicker,

        [Display(Name = "Dropdown Color Picker")]
        SfDropDownColorPicker,

        [Display(Name = "Color Palette")]
        SfColorPalette,

        [Display(Name = "Dropdown Color Palette")]
        SfDropDownColorPalette,

        [Display(Name = "Barcode")]
        Barcode,

        [Display(Name = "Slider")]
        SfSlider,

        [Display(Name = "Range Slider")]
        SfRangeSlider,

         [Display(Name = "Ribbon")]
        SfRibbon
    }

    /// </summary>
    /// Specifies a demo type which should mention in each demo
    /// </summary>
    [Flags]
    public enum DemoTypes
    {
        None = 0,
        Showcase = 1,
        New = 2,
        Updated = 4,
    }

    /// </summary>
    /// Specifies a tag which mention in each control list to display new/ updated
    /// </summary>
    public enum ControlBadge
    {
        None = 0,
        New = 1,
        Updated = 2
    }
}
