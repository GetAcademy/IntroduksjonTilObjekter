namespace IntroduksjonTilObjekter
{
    internal class HippieCounter
    {
        public int Count { get; private set; }
        public static int StartValue;

        public HippieCounter()
        {
            Reset();
        }

        public void Click()
        {
            Count++;
        }

        public void Reset()
        {
            Count = StartValue;
        }
    }
}

