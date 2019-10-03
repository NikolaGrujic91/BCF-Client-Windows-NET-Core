using System.Windows.Controls;
using BIMcollab_BCF_WPF_MVVM.Model;
using BIMcollab_BCF_WPF_MVVM.ViewModel;

namespace BIMcollab_BCF_WPF_MVVM.Views
{
    /// <summary>
    /// Interaction logic for CommentView.xaml
    /// </summary>
    public partial class CommentView : UserControl
    {
        #region Fields

        private readonly CommentViewModel commentViewModelObject;

        #endregion

        #region Constructors

        public CommentView()
        {
            this.InitializeComponent();

            this.commentViewModelObject = new CommentViewModel();
            this.DataContext = this.commentViewModelObject;
        }

        #endregion

        #region Methods

        internal void ShowComments(Issue selectedIssue)
        {
            this.commentViewModelObject.ShowComments(selectedIssue);
        }

        public void Clear()
        {
            this.commentViewModelObject.Clear();
        }

        #endregion
    }
}
