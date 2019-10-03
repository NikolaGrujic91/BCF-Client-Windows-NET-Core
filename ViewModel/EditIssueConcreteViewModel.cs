using BIMcollab_BCF_WPF_MVVM.Model;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal class EditIssueConcreteViewModel : EditIssueAbstractViewModel
    {
        #region Constructors

        public EditIssueConcreteViewModel(Project project)
        {
            this.activeProject = project;
        }

        #endregion

        #region Methods

        protected override string GetActiveStatus()
        {
            return this.issue.Status;
        }

        protected override int GetActiveType()
        {
            return (int)this.issue.TypeID;
        }

        protected override int GetActiveMilestone()
        {
            return (int)this.issue.MilestoneID;
        }

        protected override int GetActiveArea()
        {
            return (int)this.issue.AreaID;
        }

        protected override int GetActivePriority()
        {
            return (int) this.issue.PriorityID;
        }

        protected override int GetOwnerIndex()
        {
            return (int) this.issue.OwnerIndex;
        }

        protected override int GetActiveVisibility()
        {
            return (int) this.issue.VisibilityID;
        }

        protected override bool IsNewIssueCreated()
        {
            return false;
        }

        #endregion
    }
}
