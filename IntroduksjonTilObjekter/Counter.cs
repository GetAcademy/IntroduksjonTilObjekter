using System;

namespace IntroduksjonTilObjekter
{
    internal class Counter
    {
        public int Count { get; private set; }
        private readonly int _startValue;

        public Counter(int startValue = 0)
        {
            _startValue = startValue;
            Reset();
        }

        //public void Show()
        //{
        //    Console.WriteLine(_count);
        //}

        //public int Count
        //{
        //    get
        //    {
        //        return _count;
        //    }
        //}

        //public int GetCount()
        //{
        //    return _count;
        //}

        public void Click()
        {
            Count++;
        }

        public void Reset()
        {
            Count = _startValue;
        }
    }
}
