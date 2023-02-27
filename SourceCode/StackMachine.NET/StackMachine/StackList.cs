using System;

namespace StackMachine
{
    /// <summary>
    /// Summary description for StackList.
    /// </summary>
    public class StackList
    {
        //private RunnableStackMachine machineGUI;
        private AbstractStackMachine _currentStackModel = null;
        private FifoStackMachine _fifoStackModel = new FifoStackMachine();
        private LifoStackMachine _lifoStackModel = new LifoStackMachine();


        public StackList()
        {
            updateModel(true);
        }

        void updateModel(bool lifoModel)
        {
            if(lifoModel)
            {
                _currentStackModel = _lifoStackModel;
            }
            else
            {
                _currentStackModel = _fifoStackModel;
            }
        }

        void updateStackSizeLabel()
        {
            string default_label = "Number of elements: ";
            int current_size = _currentStackModel.Count;
            default_label += current_size.ToString();
            Console.WriteLine(default_label);
        }
        void updateStackBox()
        {
            int size = _currentStackModel.Count;

            for (int i=0; i<size; i++)
            {
                Console.WriteLine(_currentStackModel[i]);
            }
        }
        public void push (String value1)
        {
            if (!string.IsNullOrEmpty(value1))
            {
                _currentStackModel.push(value1);
                updateStackSizeLabel();
                updateStackBox();
            }
        }
        public void pop()
        {
            try
            {
                _currentStackModel.pop();
                updateStackSizeLabel();
                updateStackBox();
            }
            catch (System.Exception outofbounds)
            {
                Console.WriteLine(outofbounds.Message);
            }
        }
        public void add()
        {
            _currentStackModel.add();
            updateStackSizeLabel();
            updateStackBox();
        }
        public void subtract()
        {
            _currentStackModel.subtract();
            updateStackSizeLabel();
            updateStackBox();
        }
        public void multiply()
        {
            _currentStackModel.multiply();
            updateStackSizeLabel();
            updateStackBox();
        }
        public void divide()
        {
            _currentStackModel.divide();
            updateStackSizeLabel();
            updateStackBox();
        }
    }
}
