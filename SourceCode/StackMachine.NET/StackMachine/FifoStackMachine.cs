using System;


namespace StackMachine
{
    public class FifoStackMachine:AbstractStackMachine
    {
        /// <summary>
        /// Push to fisrt element in stack
        /// </summary>
        /// <param name="value1"></param>
        public override void push(String value1)
        {
            this.Insert(0, value1);
        }
        public override void pop()
        {
            this.RemoveAt((this.Count)-1);
        }
        protected override int popInt()
        {
            //pop from end on stack, def of Fifo.
            int count = this.Count;
            Console.WriteLine(count);
            object obj = this[(this.Count - 1)];
            int poppedInt = System.Convert.ToInt32(obj); ;
            this.RemoveAt((this.Count) - 1);
            return poppedInt;
        }
        protected override void pushInt(int value1)
        {
            this.Insert(0,value1);
        }
    }
}
