using System.Collections;

namespace ExampleSolutionArchitecture.Lesson8_OOP_Intoduction.Hometasks
{
    internal class MyStack
    {

        Queue q1 = new Queue();
        Queue q2 = new Queue();

        public MyStack()
        {

        }

        public void Push(int x)
        {
            q1.Enqueue(x);
        }

        public int Pop()
        {
            if (q1.Count == 0) return -1;
            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            int last = (int)q1.Dequeue();
            Queue q = q1;
            q1 = q2;
            q2 = q;
            return last;
        }

        public int Top()
        {
            if (q1.Count == 0) return -1;
            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            int last = (int)q1.Dequeue();
            q2.Enqueue(last);
            Queue q = q1;
            q1 = q2;
            q2 = q;
            return last;
        }

        public bool Empty()
        {
            if (q1.Count == 0) return true;
            return false;
        }
    }
}
