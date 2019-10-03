namespace BIMcollab_BCF_WPF_MVVM.Model
{
    internal class Component
    {
        #region Fields

        private readonly BC_Component component;

        #endregion

        #region Constructors

        public Component(BC_Component component)
        {
            this.component = component;

            this.Visible = this.component.IsVisible();
            this.Selected = this.component.IsSelected();
            this.Colored = this.IsColored();
            this.IfcGUID = this.component.GetIfcGlobalId();
        }

        #endregion

        #region Properties

        public bool Visible { get; set; }

        public bool Selected { get; set; }

        public bool Colored { get; set; }

        public string IfcGUID { get; set; }

        #endregion

        #region Methods

        private bool IsColored()
        {
            return string.IsNullOrEmpty(this.component.GetColor());
        }

        #endregion
    }
}
