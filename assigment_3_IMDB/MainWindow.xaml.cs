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

namespace assigment_3_IMDB
{

    //Scafold Line


    //scaffold-dbcontext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IMDB;Integrated Security=True;Trust Server Certificate=False;" Microsoft.EntityFrameworkCore.SqlServer -contextdir Data -outputdir Models/Generated -contextnamespace assigment_3_IMDB.Data -namespace assigment_3_IMDB.Models -force

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}