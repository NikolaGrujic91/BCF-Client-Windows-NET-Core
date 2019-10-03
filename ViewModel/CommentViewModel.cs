using System.Collections.ObjectModel;
using BIMcollab_BCF_WPF_MVVM.Model;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal class CommentViewModel
    {
        #region Constructors

        public CommentViewModel()
        {
            this.Comments = new ObservableCollection<Comment>();
        }

        #endregion

        #region Properties

        public ObservableCollection<Comment> Comments { get; set; }

        #endregion

        #region Methods

        public void ShowComments(Issue issue)
        {
            this.Comments.Clear();

            foreach (BC_Comment comment in issue.Comments)
            {
                this.Comments.Add(new Comment(comment));
            }
        }

        public void Clear()
        {
            this.Comments.Clear();
        }

        #endregion
    }
}
