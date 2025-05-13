using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SkillSwapClassLibrary;

namespace LINQ_3___PXLSkillSwap;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SkillSwapData.GetSkillSwapDataSet();

    }

    // Tip: Voor LINQ heb je een Enumerable verzameling nodig. Gebruik hiervoor:
    // dt.AsEnumerable()
    private void ShowWorkshopsButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ShowCategoriesButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ShowMusicButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ShowPast14Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ShowBuildingAButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ShowDronesButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ShowListOfWorkshopNamesButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ShowListOfWorkshopNamesAndCategoryNamesButton_Click(object sender, RoutedEventArgs e)
    {

    }
}
