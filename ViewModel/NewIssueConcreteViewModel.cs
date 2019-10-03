using BIMcollab_BCF_WPF_MVVM.Model;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal class NewIssueConcreteViewModel : EditIssueAbstractViewModel
    {
        #region Constructors

        public NewIssueConcreteViewModel(Project project)
        {
            this.activeProject = project;
        }

        #endregion

        #region Methods

        protected override string GetActiveStatus()
        {
            return this.activeProject.DefaultStatusType;
        }

        protected override int GetActiveType()
        {
            return this.activeProject.DefaultIssueType;
        }

        protected override int GetActiveMilestone()
        {
            return 0;
        }

        protected override int GetActiveArea()
        {
            return 0;
        }

        protected override int GetActivePriority()
        {
            return this.activeProject.DefaultPriorityType;
        }

        protected override int GetOwnerIndex()
        {
            return 0;
        }

        protected override int GetActiveVisibility()
        {
            return 0;
        }

        protected override bool IsNewIssueCreated()
        {
            return true;
        }

        #endregion
    }
}
