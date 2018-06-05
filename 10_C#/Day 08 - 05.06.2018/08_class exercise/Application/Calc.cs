namespace ConsoleApplication1
{

    delegate bool CompareHandler(int n1, int n2);

    class Calc
    {
        public event CompareHandler CompareEventHandler;

        private int successCounter;
        public int SuccessCounter
        {
            get { return successCounter; }
        }


        public bool TestNumbers(int n1, int n2)
        {
            bool result=false;

            if (CompareEventHandler != null)
            {
                result = CompareEventHandler(n1, n2);
                successCounter += result ? 1 : 0;
            }
           
            return result;
        }

    }


}
