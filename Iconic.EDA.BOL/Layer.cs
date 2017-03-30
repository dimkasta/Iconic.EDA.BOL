namespace Iconic.EDA.BOL
{
    public partial class Layer
    {
        public int Number { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public Color SelectedColor { get; set; }
        public Fill SelectedFill { get; set; }
        public bool Visible { get; set; }
        public bool Active { get; set; }
    }
}