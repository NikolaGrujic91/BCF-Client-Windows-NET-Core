using System;
using System.Windows;
using System.Windows.Controls;
using BIMcollab_BCF_WPF_MVVM.Model;
using BIMcollab_BCF_WPF_MVVM.ViewModel;

namespace BIMcollab_BCF_WPF_MVVM.Views
{
    /// <summary>
    /// Interaction logic for IssueView.xaml
    /// </summary>
    public partial class IssueView : UserControl
    {
        #region Fields

        private readonly IssueViewModel issueViewModelObject;
        private EditIssueView editIssueView;

        #endregion

        #region Constructors

        public IssueView()
        {
            this.InitializeComponent();

            this.issueViewModelObject = new IssueViewModel();
            this.DataContext = this.issueViewModelObject;
        }

        #endregion

        #region Delegates

        internal class SelectionChangedEventArgs : EventArgs
        {
            public SelectionChangedEventArgs(Issue issue, bool isAnyIssueSelected)
            {
                this.SelectedIssue = issue;
                this.IsAnyIssueSelected = isAnyIssueSelected;
            }

            public Issue SelectedIssue { get; }

            public bool IsAnyIssueSelected { get; }
        }

        internal delegate void OnSelectionChangedDelegate(SelectionChangedEventArgs args);

        internal event OnSelectionChangedDelegate SelectionChanged;

        #endregion

        #region Events

        private void EditIssueViewOnIssueSaved(EditIssueView.IssueSavedEventArgs args)
        {
            int selectedRowIndex = this.IssuesGrid.SelectedIndex;

            if (args.IsNewIssue)
            {
                this.issueViewModelObject.AddIssue(args.EditedIssue);
            }

            this.IssuesGrid.Items.Refresh();

            if (args.IsNewIssue)
            {
                selectedRowIndex = this.IssuesGrid.Items.Count - 1;
            }

            this.IssuesGrid.SelectedIndex = selectedRowIndex;
            this.EnsureVisible();
        }

        private void IssuesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int selectedRowIndex = this.IssuesGrid.SelectedIndex;
            bool isAnyIssueSelected = selectedRowIndex > -1;

            Issue issue = isAnyIssueSelected ? (Issue)this.issueViewModelObject.GetCurrentIssue() : null;

            this.SelectionChanged?.Invoke(new SelectionChangedEventArgs(issue, isAnyIssueSelected));
        }

        private void PublishMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            this.issueViewModelObject.Publish();
            this.ShowMessageBox(this.issueViewModelObject.GetPublishMessage());
        }

        private void EditMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            this.editIssueView.EditIssue(this.issueViewModelObject.GetCurrentIssue());
            this.editIssueView.ShowDialog();
        }

        private void AddMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            this.editIssueView.NewIssue();
            this.editIssueView.ShowDialog();
        }

        private void ComponentsItem_OnClick(object sender, RoutedEventArgs e)
        {
            var componentView = new ComponentView(this.issueViewModelObject.GetCurrentIssue().ViewPoint) { Owner = Application.Current.MainWindow }; ;
            componentView.ShowDialog();
        }

        private void CheckBox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            this.issueViewModelObject.SaveFilterSettings();
            this.issueViewModelObject.Refresh();
        }

        #endregion

        #region Methods

        internal void LoadIssues(Project activeProject)
        {
            this.issueViewModelObject.LoadIssues(activeProject);
            this.editIssueView = new EditIssueView(activeProject) {Owner = Application.Current.MainWindow};
            this.editIssueView.IssueSaved += this.EditIssueViewOnIssueSaved;
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "BIMcollab Playground");
        }

        private void EnsureVisible()
        {
            if (this.IssuesGrid.SelectedItem != null)
            {
                this.IssuesGrid.ScrollIntoView(this.IssuesGrid.SelectedItem);
            }
        }

        #endregion
    }
}
