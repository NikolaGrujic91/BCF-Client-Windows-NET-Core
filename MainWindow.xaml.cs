using System.Windows;
using BIMcollab_BCF_WPF_MVVM.Views;

namespace BIMcollab_BCF_WPF_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors

        public MainWindow()
        {
            this.InitializeComponent();

            this.ProjectViewControl.Connected += this.ProjectViewControlOnConnected;
            this.IssueViewControl.SelectionChanged += this.IssueViewControlOnSelectionChanged;
        }

        #endregion

        #region Events

        private void ProjectViewControlOnConnected(ProjectView.ConnectedEventArgs args)
        {
            this.IssueViewControl.LoadIssues(args.ActiveProject);
        }

        private void IssueViewControlOnSelectionChanged(IssueView.SelectionChangedEventArgs args)
        {
            if (args.IsAnyIssueSelected)
            {
                this.IssueOverviewViewControl.ShowIssueOverview(args.SelectedIssue);
                this.CommentViewControl.ShowComments(args.SelectedIssue);
            }
            else
            {
                this.IssueOverviewViewControl.Clear();
                this.CommentViewControl.Clear();
            }
        }

        #endregion
    }
}
