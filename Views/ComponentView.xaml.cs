using System.Windows;
using BIMcollab_BCF_WPF_MVVM.ViewModel;

namespace BIMcollab_BCF_WPF_MVVM.Views
{
    /// <summary>
    /// Interaction logic for ComponentView.xaml
    /// </summary>
    public partial class ComponentView : Window
    {
        #region Fields

        private readonly ComponentViewModel componentViewModelObject;

        #endregion

        #region Constructors

        internal ComponentView(BC_ViewPoint viewpoint)
        {
            this.InitializeComponent();

            this.componentViewModelObject = new ComponentViewModel(viewpoint);
            this.DataContext = this.componentViewModelObject;
        }

        #endregion
    }
}
