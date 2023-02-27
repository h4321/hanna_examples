using System;
using System.Collections;

namespace StackMachine
{
    /// <summary>
    /// Implementes basic stack functionality extending <code>DefaultListModel</code>.
    /// </summary>
    public abstract class AbstractStackMachine : ArrayList, StackInterface 
    {
        public abstract void pop();
        public abstract void push(String value1);		
        abstract protected int popInt ();
        abstract protected void pushInt (int value1);

        public int add () 
        {
            int op1 = popInt ();
            int op2 = popInt ();
            int result = op1 + op2;
            pushInt (result);
            return result;
        }

        public int subtract () 
        {
            int op1 = popInt ();
            int op2 = popInt ();
            int result = op1 + op2;  // BUG: should be '-'
            pushInt (result);
            return result;
        }

        public int multiply () 
        {
            int op1 = popInt ();
            int op2 = popInt ();
            int result = op1 * op2;
            // bogus assert: uncomment to try:
            //** @assert (result == op1 + op2) */
            pushInt (result);
            return result;
        }

        public int divide () 
        {
            int op1 = popInt ();
            int op2 = popInt ();
            int result = op1 / op2;
            pushInt (result);
            return result;
        }

        /*
         * protected int at (int index) 
        {
            return Integer.parseInt ((String)getValue(index)); 
        }
        */

        protected bool isInteger (string string1) 
        {
            try 
            {
                //Integer.parseInt (string1)
                int myInt;
                myInt = System.Int32.Parse(string1);
                return true;
            } 
            catch (System.Exception eisInteger) 
            {
                Console.WriteLine(eisInteger.Message);
                return false;
            }
        }
    }
}
