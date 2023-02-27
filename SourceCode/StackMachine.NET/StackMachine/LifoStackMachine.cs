using System;

namespace StackMachine
{
    /// <summary>
    /// Summary description for LifoStackMachine.
    /// </summary>
    public class LifoStackMachine:AbstractStackMachine
    {
        public override void push (String value1)
        {
            this.Insert(0, value1);
        }
        public override void pop()
        {
            this.RemoveAt(0);
        }
        protected override int popInt()
        {
            object obj = this[0];
            int poppedInt = System.Convert.ToInt32(obj);
            this.RemoveAt(0);
            return poppedInt;
        }
        protected override void pushInt(int val)
        {
            this.Insert(0,val);
        }
    }
}
