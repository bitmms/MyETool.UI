using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyETool.UI.Components.IconComponent.Component
{
    public class Icon : Control
    {
        #region 1. 构造器

        static Icon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                forType: typeof(Icon),
                typeMetadata: new FrameworkPropertyMetadata(typeof(Icon))
            );
        }

        #endregion

        #region 2. 注册依赖属性

        /// <summary>
        /// 图标编码依赖属性，默认值："〇"
        /// </summary>
        public static readonly DependencyProperty IconCodeProperty = DependencyProperty.Register(
            name: nameof(IconCode),
            propertyType: typeof(string),
            ownerType: typeof(Icon),
            typeMetadata: new PropertyMetadata("&#xe639;")
        );

        /// <summary>
        /// 图标大小依赖属性，默认值：18
        /// </summary>
        public static readonly DependencyProperty IconSizeProperty = DependencyProperty.Register(
            name: nameof(IconSize),
            propertyType: typeof(int),
            ownerType: typeof(Icon),
            typeMetadata: new PropertyMetadata(18)
        );

        /// <summary>
        /// 图标颜色依赖属性，默认值：Brushes.Black
        /// </summary>
        public static readonly DependencyProperty IconColorProperty = DependencyProperty.Register(
            name: nameof(IconColor),
            propertyType: typeof(Brush),
            ownerType: typeof(Icon),
            typeMetadata: new PropertyMetadata(Brushes.Black)
        );

        /// <summary>
        /// 图标路径依赖属性，默认值："iconfont.ttf"
        /// </summary>
        public static readonly DependencyProperty IconPathProperty = DependencyProperty.Register(
            name: nameof(IconPath),
            propertyType: typeof(string),
            ownerType: typeof(Icon),
            typeMetadata: new PropertyMetadata("pack://application:,,,/MyETool.UI;component/Components/IconComponent/Font/iconfont.ttf#iconfont")
        );

        #endregion

        #region 3. 依赖属性包装器

        public string IconCode
        {
            get => (string)GetValue(IconCodeProperty);
            set => SetValue(IconCodeProperty, value);
        }

        public int IconSize
        {
            get => (int)GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty, value);
        }

        public Brush IconColor
        {
            get => (Brush)GetValue(IconColorProperty);
            set => SetValue(IconColorProperty, value);
        }

        public string IconPath
        {
            get => (string)GetValue(IconPathProperty);
            set => SetValue(IconPathProperty, value);
        }

        #endregion
    }
}
