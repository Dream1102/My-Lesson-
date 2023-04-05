namespace ExampleSolutionArchitecture.Lesson9_OOP_Introduction.Hometasks
{
    public class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;

            }
        }
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }
    }
}
//public class Solution
//{
//        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
//        {
//            var lengthA = GetListNodeLength(headA);
//            var lengthB = GetListNodeLength(headB);

//            while (lengthA > lengthB)
//            {
//                headA = headA.next;
//                lengthA--;
//            }

//            while (lengthB > lengthA)
//            {
//                headB = headB.next;
//                lengthB--;
//            }

//            while (headA != headB)
//            {
//                headA = headA.next;
//                headB = headB.next;
//            }

//            return headA;
//        }

//        private static int GetListNodeLength(ListNode node)
//        {
//            var length = 0;

//            while (node != null)
//            {
//                node = node.next;
//                length++;
//            }

//            return length;
//        }
//    }

