#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace syncfusion.radialgaugedemos.winui.Views
{
    using Microsoft.UI.Xaml.Controls;
    using Microsoft.UI.Xaml.Media.Animation;
    using System.Collections.Generic;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Animation : Page
    {
        public List<AnimationTypes> AnimationTypesItemsSource { get; }

        public Animation()
        {
            this.InitializeComponent();
            this.AnimationTypesItemsSource = new List<AnimationTypes>()
            {
                new AnimationTypes("Linear", "x:Null", null),
                new AnimationTypes("Bounce out", "BounceEase Bounciness=\"5\" EasingMode=\"EaseOut\"", new BounceEase { Bounciness = 5 }),
                new AnimationTypes("Ease", "CircleEase EasingMode=\"EaseOut\"", new CircleEase { EasingMode = EasingMode.EaseOut }),
                new AnimationTypes("Ease in cric", "CircleEase EasingMode=\"EaseIn\"", new CircleEase { EasingMode = EasingMode.EaseIn }),
                new AnimationTypes("Elastic out", "ElasticEase Oscillations=\"2\" Springiness=\"7\" EasingMode=\"EaseOut\"", new ElasticEase { Oscillations = 2, Springiness = 7 }),
                new AnimationTypes("Ease out back","BackEase Amplitude=\"0.5\" EasingMode=\"EaseOut\"", new BackEase { Amplitude = 0.5 }),
            };

            this.DataContext = this;
        }

        private void AnimationTypesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.needlePointer.AnimationEasingFunction = AnimationTypesComboBox.SelectedValue as EasingFunctionBase;
        }
    }

    public class AnimationTypes
    {
        public string AnimationType { get; private set; }
        public string SubstitutionString { get; private set; }
        public EasingFunctionBase EasingFunction { get; private set; }
        public AnimationTypes(string animationType, string substitutionString, EasingFunctionBase easingFunction)
        {
            this.AnimationType = animationType;
            this.SubstitutionString = substitutionString;
            this.EasingFunction = easingFunction;
        }
    }
}
