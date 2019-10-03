using System.Collections.ObjectModel;
using BIMcollab_BCF_WPF_MVVM.Model;

namespace BIMcollab_BCF_WPF_MVVM.ViewModel
{
    internal class ComponentViewModel
    {
        #region Fields

        private readonly BC_ViewPoint viewpoint;

        #endregion

        #region Constructors

        public ComponentViewModel(BC_ViewPoint viewpoint)
        {
            this.viewpoint = viewpoint;

            this.CreateComponentsList();
        }

        #endregion

        #region Properties

        public ObservableCollection<Component> Components { get; set; }

        #endregion

        #region Methods

        private void CreateComponentsList()
        {
            this.Components = new ObservableCollection<Component>();

            if (this.viewpoint == null)
            {
                return;
            }

            this.viewpoint.MoveComponentIteratorToFirst();
            BC_Component component = this.viewpoint.GetComponent();

            do
            {
                this.Components.Add(new Component(component));
            }
            while (this.viewpoint.MoveComponentIteratorToNext());
        }

        #endregion
    }
}
