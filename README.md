# 自定义 WPF 组件库

> - [x] Icon
> - [x] Button

## 1. 使用流程

> （1）引入项目
>
> * 方法一：引入项目
> * 方法二：引入 DLL 文件

> （2）引入资源字典

```xaml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="Pack://application:,,,/MyETool.UI;component/Themes/Generic.xaml" />
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

> （3）使用组件

```xaml
<Window x:Class="MyETool.UI.App.View.IconWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:icon="clr-namespace:MyETool.UI.Components.IconComponent.Component;assembly=MyETool.UI"
        mc:Ignorable="d"
        WindowStartupLocation="CenterScreen"
        Title="IconWindow"
        Height="450"
        Width="800">


    <Grid>

        <Grid.RowDefinitions>
            <RowDefinition Height="*"></RowDefinition>
            <RowDefinition Height="*"></RowDefinition>
            <RowDefinition Height="*"></RowDefinition>
        </Grid.RowDefinitions>

        <icon:Icon Grid.Row="0"
                   IconSize="66"
                   IconColor="#5cb6ff"
                   IconCode="&#xe639;" />

        <icon:Icon Grid.Row="1"
                   IconSize="66"
                   IconColor="#5cb6ff"
                   IconCode="&#xe602;"
                   IconPath="pack://application:,,,/MyETool.UI.App;component/Font/iconfont.ttf#iconfont" />

        <icon:Icon Grid.Row="2"
                   IconSize="66"
                   IconColor="#5cb6ff"
                   IconCode="&#xe61c;"
                   IconPath="pack://application:,,,/MyETool.UI.App;component/Font/iconfont.ttf#iconfont" />

    </Grid>


</Window>
```

## 2. 注意事项

> 针对字体图标文件
>
> * 生成操作：Resource
> * 复制到输出目录：不复制

## 3. 打包流程

```bash
# 验证
MSBuild /version
nuget help

# 清理
MSBuild MyETool.UI.sln /p:Configuration=Release /t:Clean

# 编译组件库和桌面程序
MSBuild MyETool.UI.sln /p:Configuration=Release /t:Rebuild

# 组件库打包
nuget pack MyETool.UI\MyETool.UI.csproj -Properties Configuration=Release -OutputDirectory .\MyETool.UI\bin\Release\nupkg

# 桌面程序打包
MSBuild MyETool.UI.App\MyETool.UI.App.csproj /p:Configuration=Release /t:Publish
```

