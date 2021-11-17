namespace Warehouse
{
    public class Box
    {
        private float height;
        private float width;
        private float depth;

        public Box()
        {
            
        }

        public Box(float height, float width, float depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public float Volume()
        {
            return width * height * depth;
        }

        public override string ToString()
        {
            return string.Format(" Height: {0}" +
                                 "\n Width: {1}" +
                                 "\n Depth: {2}" +
                                 "\n Volume: {3:f2}\n",
                height,width,depth,Volume());
            
        }
    }
}