namespace blazorserver01.Data
{
    public class BioUnit
    {
        protected string color;
        public int posx;
        public int posy;
        public Environment parent;
        protected int living;
        protected int livingTop;
        public BioUnit(int x, int y, Environment e) {
            this.posx = x;
            this.posy = y;
            this.color = "#444444";
            this.parent = e;
        }
        public string myColor() => this.color;
        public virtual bool will_I_live() => true;
    }
}