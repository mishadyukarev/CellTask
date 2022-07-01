namespace Cell.Model.Component
{
    public readonly struct XyC
    {
        readonly int[] _xy;

        public int X => _xy[0];
        public int Y => _xy[1];
        public int[] Xy => (int[])_xy.Clone();

        internal XyC(in int[] xy) => _xy = xy;
    }
}