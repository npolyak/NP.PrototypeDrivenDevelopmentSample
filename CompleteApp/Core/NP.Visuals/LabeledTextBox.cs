using Avalonia;
using Avalonia.Controls.Primitives;

namespace NP.Visuals
{
    public class LabeledTextBox : TemplatedControl
    {

        #region Label Styled Avalonia Property
        public string Label
        {
            get { return GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly StyledProperty<string> LabelProperty =
            AvaloniaProperty.Register<LabeledTextBox, string>
            (
                nameof(Label)
            );
        #endregion Label Styled Avalonia Property


        #region Text Styled Avalonia Property
        public string Text
        {
            get { return GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly StyledProperty<string> TextProperty =
            AvaloniaProperty.Register<LabeledTextBox, string>
            (
                nameof(Text)
            );
        #endregion Text Styled Avalonia Property
    }
}
