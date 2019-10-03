using System.Text;
using System.Windows.Media;
using BIMcollab_BCF_WPF_MVVM.Model;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal class IssueOverviewViewModel
    {
        #region Fields

        private Issue selectedIssue;

        #endregion

        #region Constructors

        public IssueOverviewViewModel()
        {

        }

        #endregion

        #region Methods

        public void SetSelectedIssue(Issue issue)
        {
            this.selectedIssue = issue;
        }

        public ImageSource Snapshot()
        {
            return this.selectedIssue.Snapshot;
        }

        public string IssueInformation()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(this.selectedIssue.Title).AppendLine();
            stringBuilder.AppendLine(this.selectedIssue.Owner);
            stringBuilder.AppendLine($"{this.selectedIssue.Status} , {this.selectedIssue.Type} , {this.selectedIssue.Priority}");
            stringBuilder.AppendLine(this.selectedIssue.Area);
            stringBuilder.AppendLine(this.selectedIssue.Milestone);

            int count = this.selectedIssue.Labels.Count;

            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(i == count - 1 ? this.selectedIssue.Labels[i] : $"{this.selectedIssue.Labels[i]}, ");
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
