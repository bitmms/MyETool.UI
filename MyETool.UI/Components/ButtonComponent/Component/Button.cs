using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace MyETool.UI.Components.ButtonComponent.Component
{
    public class Button : ButtonBase
    {
        #region 1. 构造器

        static Button()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Button), new FrameworkPropertyMetadata(typeof(Button)));
        }

        #endregion

        #region 2. 注册依赖属性

        public static readonly DependencyProperty ButtonTypeProperty = DependencyProperty.Register(nameof(ButtonType), typeof(ButtonType), typeof(Button), new PropertyMetadata(ButtonType.TwoIconAndTextButton));

        private const string IconPath = "pack://application:,,,/MyETool.UI;component/Components/IconComponent/Font/iconfont.ttf#iconfont";
        public static readonly DependencyProperty ButtonIconPathProperty = DependencyProperty.Register(name: nameof(ButtonIconPath), propertyType: typeof(string), ownerType: typeof(Button), typeMetadata: new PropertyMetadata(IconPath));
        public static readonly DependencyProperty ButtonIsAutoSizeProperty = DependencyProperty.Register(nameof(ButtonIsAutoSize), typeof(bool), typeof(Button), new PropertyMetadata(false));

        public static readonly DependencyProperty ButtonWidthProperty = DependencyProperty.Register(nameof(ButtonWidth), typeof(string), typeof(Button), new PropertyMetadata("100"));
        public static readonly DependencyProperty MouseEnterButtonWidthProperty = DependencyProperty.Register(nameof(MouseEnterButtonWidth), typeof(string), typeof(Button), new PropertyMetadata("100"));
        public static readonly DependencyProperty MouseClickButtonWidthProperty = DependencyProperty.Register(nameof(MouseClickButtonWidth), typeof(string), typeof(Button), new PropertyMetadata("100"));

        public static readonly DependencyProperty ButtonHeightProperty = DependencyProperty.Register(nameof(ButtonHeight), typeof(string), typeof(Button), new PropertyMetadata("45"));
        public static readonly DependencyProperty MouseEnterButtonHeightProperty = DependencyProperty.Register(nameof(MouseEnterButtonHeight), typeof(string), typeof(Button), new PropertyMetadata("45"));
        public static readonly DependencyProperty MouseClickButtonHeightProperty = DependencyProperty.Register(nameof(MouseClickButtonHeight), typeof(string), typeof(Button), new PropertyMetadata("45"));

        public static readonly DependencyProperty ButtonBorderSizeProperty = DependencyProperty.Register(nameof(ButtonBorderSize), typeof(int), typeof(Button), new PropertyMetadata(5));
        public static readonly DependencyProperty MouseEnterButtonBorderSizeProperty = DependencyProperty.Register(nameof(MouseEnterButtonBorderSize), typeof(int), typeof(Button), new PropertyMetadata(5));
        public static readonly DependencyProperty MouseClickButtonBorderSizeProperty = DependencyProperty.Register(nameof(MouseClickButtonBorderSize), typeof(int), typeof(Button), new PropertyMetadata(5));

        public static readonly DependencyProperty ButtonBorderRadiusProperty = DependencyProperty.Register(nameof(ButtonBorderRadius), typeof(int), typeof(Button), new PropertyMetadata(5));
        public static readonly DependencyProperty MouseEnterButtonBorderRadiusProperty = DependencyProperty.Register(nameof(MouseEnterButtonBorderRadius), typeof(int), typeof(Button), new PropertyMetadata(5));
        public static readonly DependencyProperty MouseClickButtonBorderRadiusProperty = DependencyProperty.Register(nameof(MouseClickButtonBorderRadius), typeof(int), typeof(Button), new PropertyMetadata(5));

        public static readonly DependencyProperty ButtonBorderColorProperty = DependencyProperty.Register(nameof(ButtonBorderColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty MouseEnterButtonBorderColorProperty = DependencyProperty.Register(nameof(MouseEnterButtonBorderColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.White));
        public static readonly DependencyProperty MouseClickButtonBorderColorProperty = DependencyProperty.Register(nameof(MouseClickButtonBorderColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Green));

        public static readonly DependencyProperty ButtonBackgroundColorProperty = DependencyProperty.Register(nameof(ButtonBackgroundColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Red));
        public static readonly DependencyProperty MouseEnterButtonBackgroundColorProperty = DependencyProperty.Register(nameof(MouseEnterButtonBackgroundColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.SkyBlue));
        public static readonly DependencyProperty MouseClickButtonBackgroundColorProperty = DependencyProperty.Register(nameof(MouseClickButtonBackgroundColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Orange));

        public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.Register(nameof(ButtonText), typeof(string), typeof(Button), new PropertyMetadata("这是按钮"));
        public static readonly DependencyProperty MouseEnterButtonTextProperty = DependencyProperty.Register(nameof(MouseEnterButtonText), typeof(string), typeof(Button), new PropertyMetadata("这是按钮"));
        public static readonly DependencyProperty MouseClickButtonTextProperty = DependencyProperty.Register(nameof(MouseClickButtonText), typeof(string), typeof(Button), new PropertyMetadata("这是按钮"));

        public static readonly DependencyProperty ButtonTextSizeProperty = DependencyProperty.Register(nameof(ButtonTextSize), typeof(int), typeof(Button), new PropertyMetadata(14));
        public static readonly DependencyProperty MouseEnterButtonTextSizeProperty = DependencyProperty.Register(nameof(MouseEnterButtonTextSize), typeof(int), typeof(Button), new PropertyMetadata(14));
        public static readonly DependencyProperty MouseClickButtonTextSizeProperty = DependencyProperty.Register(nameof(MouseClickButtonTextSize), typeof(int), typeof(Button), new PropertyMetadata(14));

        public static readonly DependencyProperty ButtonTextColorProperty = DependencyProperty.Register(nameof(ButtonTextColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty MouseEnterButtonTextColorProperty = DependencyProperty.Register(nameof(MouseEnterButtonTextColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.White));
        public static readonly DependencyProperty MouseClickButtonTextColorProperty = DependencyProperty.Register(nameof(MouseClickButtonTextColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Green));

        public static readonly DependencyProperty ButtonTextWeightProperty = DependencyProperty.Register(nameof(ButtonTextWeight), typeof(FontWeight), typeof(Button), new PropertyMetadata(FontWeights.Normal));
        public static readonly DependencyProperty MouseEnterButtonTextWeightProperty = DependencyProperty.Register(nameof(MouseEnterButtonTextWeight), typeof(FontWeight), typeof(Button), new PropertyMetadata(FontWeights.Normal));
        public static readonly DependencyProperty MouseClickButtonTextWeightProperty = DependencyProperty.Register(nameof(MouseClickButtonTextWeight), typeof(FontWeight), typeof(Button), new PropertyMetadata(FontWeights.Normal));

        public static readonly DependencyProperty ButtonLeftIconCodeProperty = DependencyProperty.Register(nameof(ButtonLeftIconCode), typeof(string), typeof(Button), new PropertyMetadata("〇"));
        public static readonly DependencyProperty MouseEnterButtonLeftIconCodeProperty = DependencyProperty.Register(nameof(MouseEnterButtonLeftIconCode), typeof(string), typeof(Button), new PropertyMetadata("〇"));
        public static readonly DependencyProperty MouseClickButtonLeftIconCodeProperty = DependencyProperty.Register(nameof(MouseClickButtonLeftIconCode), typeof(string), typeof(Button), new PropertyMetadata("〇"));

        public static readonly DependencyProperty ButtonLeftIconSizeProperty = DependencyProperty.Register(nameof(ButtonLeftIconSize), typeof(int), typeof(Button), new PropertyMetadata(18));
        public static readonly DependencyProperty MouseEnterButtonLeftIconSizeProperty = DependencyProperty.Register(nameof(MouseEnterButtonLeftIconSize), typeof(int), typeof(Button), new PropertyMetadata(18));
        public static readonly DependencyProperty MouseClickButtonLeftIconSizeProperty = DependencyProperty.Register(nameof(MouseClickButtonLeftIconSize), typeof(int), typeof(Button), new PropertyMetadata(18));

        public static readonly DependencyProperty ButtonLeftIconColorProperty = DependencyProperty.Register(nameof(ButtonLeftIconColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty MouseEnterButtonLeftIconColorProperty = DependencyProperty.Register(nameof(MouseEnterButtonLeftIconColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.White));
        public static readonly DependencyProperty MouseClickButtonLeftIconColorProperty = DependencyProperty.Register(nameof(MouseClickButtonLeftIconColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Green));

        public static readonly DependencyProperty ButtonLeftIconAndTextSpaceProperty = DependencyProperty.Register(nameof(ButtonLeftIconAndTextSpace), typeof(int), typeof(Button), new PropertyMetadata(10));
        public static readonly DependencyProperty MouseEnterButtonLeftIconAndTextSpaceProperty = DependencyProperty.Register(nameof(MouseEnterButtonLeftIconAndTextSpace), typeof(int), typeof(Button), new PropertyMetadata(10));
        public static readonly DependencyProperty MouseClickButtonLeftIconAndTextSpaceProperty = DependencyProperty.Register(nameof(MouseClickButtonLeftIconAndTextSpace), typeof(int), typeof(Button), new PropertyMetadata(10));

        public static readonly DependencyProperty ButtonRightIconCodeProperty = DependencyProperty.Register(nameof(ButtonRightIconCode), typeof(string), typeof(Button), new PropertyMetadata("〇"));
        public static readonly DependencyProperty MouseClickButtonRightIconCodeProperty = DependencyProperty.Register(nameof(MouseClickButtonRightIconCode), typeof(string), typeof(Button), new PropertyMetadata("〇"));
        public static readonly DependencyProperty MouseEnterButtonRightIconCodeProperty = DependencyProperty.Register(nameof(MouseEnterButtonRightIconCode), typeof(string), typeof(Button), new PropertyMetadata("〇"));

        public static readonly DependencyProperty ButtonRightIconSizeProperty = DependencyProperty.Register(nameof(ButtonRightIconSize), typeof(int), typeof(Button), new PropertyMetadata(18));
        public static readonly DependencyProperty MouseClickButtonRightIconSizeProperty = DependencyProperty.Register(nameof(MouseClickButtonRightIconSize), typeof(int), typeof(Button), new PropertyMetadata(18));
        public static readonly DependencyProperty MouseEnterButtonRightIconSizeProperty = DependencyProperty.Register(nameof(MouseEnterButtonRightIconSize), typeof(int), typeof(Button), new PropertyMetadata(18));

        public static readonly DependencyProperty ButtonRightIconColorProperty = DependencyProperty.Register(nameof(ButtonRightIconColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty MouseEnterButtonRightIconColorProperty = DependencyProperty.Register(nameof(MouseEnterButtonRightIconColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.White));
        public static readonly DependencyProperty MouseClickButtonRightIconColorProperty = DependencyProperty.Register(nameof(MouseClickButtonRightIconColor), typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Green));

        public static readonly DependencyProperty ButtonRightIconAndTextSpaceProperty = DependencyProperty.Register(nameof(ButtonRightIconAndTextSpace), typeof(int), typeof(Button), new PropertyMetadata(10));
        public static readonly DependencyProperty MouseEnterButtonRightIconAndTextSpaceProperty = DependencyProperty.Register(nameof(MouseEnterButtonRightIconAndTextSpace), typeof(int), typeof(Button), new PropertyMetadata(10));
        public static readonly DependencyProperty MouseClickButtonRightIconAndTextSpaceProperty = DependencyProperty.Register(nameof(MouseClickButtonRightIconAndTextSpace), typeof(int), typeof(Button), new PropertyMetadata(10));

        #endregion

        #region 3. 依赖属性的包装器

        public ButtonType ButtonType
        {
            get => (ButtonType)GetValue(ButtonTypeProperty);
            set => SetValue(ButtonTypeProperty, value);
        }

        public string ButtonIconPath
        {
            get => (string)GetValue(ButtonIconPathProperty);
            set => SetValue(ButtonIconPathProperty, value);
        }

        public bool ButtonIsAutoSize
        {
            get => (bool)GetValue(ButtonIsAutoSizeProperty);
            set => SetValue(ButtonIsAutoSizeProperty, value);
        }

        public string ButtonWidth
        {
            get => (string)GetValue(ButtonWidthProperty);
            set => SetValue(ButtonWidthProperty, value);
        }

        public string MouseEnterButtonWidth
        {
            get => (string)GetValue(MouseEnterButtonWidthProperty);
            set => SetValue(MouseEnterButtonWidthProperty, value);
        }

        public string MouseClickButtonWidth
        {
            get => (string)GetValue(MouseClickButtonWidthProperty);
            set => SetValue(MouseClickButtonWidthProperty, value);
        }

        public string ButtonHeight
        {
            get => (string)GetValue(ButtonHeightProperty);
            set => SetValue(ButtonHeightProperty, value);
        }

        public string MouseEnterButtonHeight
        {
            get => (string)GetValue(MouseEnterButtonHeightProperty);
            set => SetValue(MouseEnterButtonHeightProperty, value);
        }

        public string MouseClickButtonHeight
        {
            get => (string)GetValue(MouseClickButtonHeightProperty);
            set => SetValue(MouseClickButtonHeightProperty, value);
        }

        public int ButtonBorderSize
        {
            get => (int)GetValue(ButtonBorderSizeProperty);
            set => SetValue(ButtonBorderSizeProperty, value);
        }

        public int MouseEnterButtonBorderSize
        {
            get => (int)GetValue(MouseEnterButtonBorderSizeProperty);
            set => SetValue(MouseEnterButtonBorderSizeProperty, value);
        }

        public int MouseClickButtonBorderSize
        {
            get => (int)GetValue(MouseClickButtonBorderSizeProperty);
            set => SetValue(MouseClickButtonBorderSizeProperty, value);
        }

        public int ButtonBorderRadius
        {
            get => (int)GetValue(ButtonBorderRadiusProperty);
            set => SetValue(ButtonBorderRadiusProperty, value);
        }

        public int MouseEnterButtonBorderRadius
        {
            get => (int)GetValue(MouseEnterButtonBorderRadiusProperty);
            set => SetValue(MouseEnterButtonBorderRadiusProperty, value);
        }

        public int MouseClickButtonBorderRadius
        {
            get => (int)GetValue(MouseClickButtonBorderRadiusProperty);
            set => SetValue(MouseClickButtonBorderRadiusProperty, value);
        }

        public Brush ButtonBorderColor
        {
            get => (Brush)GetValue(ButtonBorderColorProperty);
            set => SetValue(ButtonBorderColorProperty, value);
        }

        public Brush MouseEnterButtonBorderColor
        {
            get => (Brush)GetValue(MouseEnterButtonBorderColorProperty);
            set => SetValue(MouseEnterButtonBorderColorProperty, value);
        }

        public Brush MouseClickButtonBorderColor
        {
            get => (Brush)GetValue(MouseClickButtonBorderColorProperty);
            set => SetValue(MouseClickButtonBorderColorProperty, value);
        }

        public Brush ButtonBackgroundColor
        {
            get => (Brush)GetValue(ButtonBackgroundColorProperty);
            set => SetValue(ButtonBackgroundColorProperty, value);
        }

        public Brush MouseEnterButtonBackgroundColor
        {
            get => (Brush)GetValue(MouseEnterButtonBackgroundColorProperty);
            set => SetValue(MouseEnterButtonBackgroundColorProperty, value);
        }

        public Brush MouseClickButtonBackgroundColor
        {
            get => (Brush)GetValue(MouseClickButtonBackgroundColorProperty);
            set => SetValue(MouseClickButtonBackgroundColorProperty, value);
        }

        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }

        public string MouseEnterButtonText
        {
            get => (string)GetValue(MouseEnterButtonTextProperty);
            set => SetValue(MouseEnterButtonTextProperty, value);
        }

        public string MouseClickButtonText
        {
            get => (string)GetValue(MouseClickButtonTextProperty);
            set => SetValue(MouseClickButtonTextProperty, value);
        }

        public int ButtonTextSize
        {
            get => (int)GetValue(ButtonTextSizeProperty);
            set => SetValue(ButtonTextSizeProperty, value);
        }

        public int MouseEnterButtonTextSize
        {
            get => (int)GetValue(MouseEnterButtonTextSizeProperty);
            set => SetValue(MouseEnterButtonTextSizeProperty, value);
        }

        public int MouseClickButtonTextSize
        {
            get => (int)GetValue(MouseClickButtonTextSizeProperty);
            set => SetValue(MouseClickButtonTextSizeProperty, value);
        }

        public Brush ButtonTextColor
        {
            get => (Brush)GetValue(ButtonTextColorProperty);
            set => SetValue(ButtonTextColorProperty, value);
        }

        public Brush MouseEnterButtonTextColor
        {
            get => (Brush)GetValue(MouseEnterButtonTextColorProperty);
            set => SetValue(MouseEnterButtonTextColorProperty, value);
        }

        public Brush MouseClickButtonTextColor
        {
            get => (Brush)GetValue(MouseClickButtonTextColorProperty);
            set => SetValue(MouseClickButtonTextColorProperty, value);
        }

        public FontWeight ButtonTextWeight
        {
            get => (FontWeight)GetValue(ButtonTextWeightProperty);
            set => SetValue(ButtonTextWeightProperty, value);
        }

        public FontWeight MouseEnterButtonTextWeight
        {
            get => (FontWeight)GetValue(MouseEnterButtonTextWeightProperty);
            set => SetValue(MouseEnterButtonTextWeightProperty, value);
        }

        public FontWeight MouseClickButtonTextWeight
        {
            get => (FontWeight)GetValue(MouseClickButtonTextWeightProperty);
            set => SetValue(MouseClickButtonTextWeightProperty, value);
        }

        public string ButtonLeftIconCode
        {
            get => (string)GetValue(ButtonLeftIconCodeProperty);
            set => SetValue(ButtonLeftIconCodeProperty, value);
        }

        public string MouseEnterButtonLeftIconCode
        {
            get => (string)GetValue(MouseEnterButtonLeftIconCodeProperty);
            set => SetValue(MouseEnterButtonLeftIconCodeProperty, value);
        }

        public string MouseClickButtonLeftIconCode
        {
            get => (string)GetValue(MouseClickButtonLeftIconCodeProperty);
            set => SetValue(MouseClickButtonLeftIconCodeProperty, value);
        }

        public int ButtonLeftIconSize
        {
            get => (int)GetValue(ButtonLeftIconSizeProperty);
            set => SetValue(ButtonLeftIconSizeProperty, value);
        }

        public int MouseEnterButtonLeftIconSize
        {
            get => (int)GetValue(MouseEnterButtonLeftIconSizeProperty);
            set => SetValue(MouseEnterButtonLeftIconSizeProperty, value);
        }

        public int MouseClickButtonLeftIconSize
        {
            get => (int)GetValue(MouseClickButtonLeftIconSizeProperty);
            set => SetValue(MouseClickButtonLeftIconSizeProperty, value);
        }

        public Brush ButtonLeftIconColor
        {
            get => (Brush)GetValue(ButtonLeftIconColorProperty);
            set => SetValue(ButtonLeftIconColorProperty, value);
        }

        public Brush MouseEnterButtonLeftIconColor
        {
            get => (Brush)GetValue(MouseEnterButtonLeftIconColorProperty);
            set => SetValue(MouseEnterButtonLeftIconColorProperty, value);
        }

        public Brush MouseClickButtonLeftIconColor
        {
            get => (Brush)GetValue(MouseClickButtonLeftIconColorProperty);
            set => SetValue(MouseClickButtonLeftIconColorProperty, value);
        }

        public int ButtonLeftIconAndTextSpace
        {
            get => (int)GetValue(ButtonLeftIconAndTextSpaceProperty);
            set => SetValue(ButtonLeftIconAndTextSpaceProperty, value);
        }

        public int MouseEnterButtonLeftIconAndTextSpace
        {
            get => (int)GetValue(MouseEnterButtonLeftIconAndTextSpaceProperty);
            set => SetValue(MouseEnterButtonLeftIconAndTextSpaceProperty, value);
        }

        public int MouseClickButtonLeftIconAndTextSpace
        {
            get => (int)GetValue(MouseClickButtonLeftIconAndTextSpaceProperty);
            set => SetValue(MouseClickButtonLeftIconAndTextSpaceProperty, value);
        }

        public string ButtonRightIconCode
        {
            get => (string)GetValue(ButtonRightIconCodeProperty);
            set => SetValue(ButtonRightIconCodeProperty, value);
        }

        public string MouseEnterButtonRightIconCode
        {
            get => (string)GetValue(MouseEnterButtonRightIconCodeProperty);
            set => SetValue(MouseEnterButtonRightIconCodeProperty, value);
        }

        public string MouseClickButtonRightIconCode
        {
            get => (string)GetValue(MouseClickButtonRightIconCodeProperty);
            set => SetValue(MouseClickButtonRightIconCodeProperty, value);
        }

        public int ButtonRightIconSize
        {
            get => (int)GetValue(ButtonRightIconSizeProperty);
            set => SetValue(ButtonRightIconSizeProperty, value);
        }

        public int MouseEnterButtonRightIconSize
        {
            get => (int)GetValue(MouseEnterButtonRightIconSizeProperty);
            set => SetValue(MouseEnterButtonRightIconSizeProperty, value);
        }

        public int MouseClickButtonRightIconSize
        {
            get => (int)GetValue(MouseClickButtonRightIconSizeProperty);
            set => SetValue(MouseClickButtonRightIconSizeProperty, value);
        }

        public Brush ButtonRightIconColor
        {
            get => (Brush)GetValue(ButtonRightIconColorProperty);
            set => SetValue(ButtonRightIconColorProperty, value);
        }

        public Brush MouseEnterButtonRightIconColor
        {
            get => (Brush)GetValue(MouseEnterButtonRightIconColorProperty);
            set => SetValue(MouseEnterButtonRightIconColorProperty, value);
        }

        public Brush MouseClickButtonRightIconColor
        {
            get => (Brush)GetValue(MouseClickButtonRightIconColorProperty);
            set => SetValue(MouseClickButtonRightIconColorProperty, value);
        }

        public int ButtonRightIconAndTextSpace
        {
            get => (int)GetValue(ButtonRightIconAndTextSpaceProperty);
            set => SetValue(ButtonRightIconAndTextSpaceProperty, value);
        }

        public int MouseEnterButtonRightIconAndTextSpace
        {
            get => (int)GetValue(MouseEnterButtonRightIconAndTextSpaceProperty);
            set => SetValue(MouseEnterButtonRightIconAndTextSpaceProperty, value);
        }

        public int MouseClickButtonRightIconAndTextSpace
        {
            get => (int)GetValue(MouseClickButtonRightIconAndTextSpaceProperty);
            set => SetValue(MouseClickButtonRightIconAndTextSpaceProperty, value);
        }

        #endregion
    }
}
