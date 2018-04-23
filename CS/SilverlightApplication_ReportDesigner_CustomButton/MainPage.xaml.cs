using System.Windows.Controls;

namespace SilverlightApplication_ReportDesigner_CustomButton {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            DataContext = new MainPageViewModel();
        }
    }
}
