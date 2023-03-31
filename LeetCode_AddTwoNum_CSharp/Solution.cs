using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_AddTwoNum_CSharp
{
    public class Solution
    {
        public ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode? retVal = null;
            ListNode? factorA = l1;
            ListNode? factorB = l2;
            bool carryOver = false;
            int intA, intB, computedValue;
            
            while (factorA != null || factorB != null)
            {
                intA = GetValueFromNode(factorA);
                intB = GetValueFromNode(factorB);
                computedValue = ComputeValueToAdd(intA, intB, carryOver);
                AddValueToList(ref retVal, computedValue % 10);

                carryOver = computedValue >= 10;
                factorA = factorA != null ? factorA.next : factorA;
                factorB = factorB != null ? factorB.next : factorB;

                if(factorA == null && factorB == null && carryOver)
                {
                    AddValueToList(ref retVal, 1);
                }
            }

            DisplayNodeList(retVal);
            return retVal;
        }
        /// <summary>
        /// Add two factors and a possible carryover
        /// </summary>
        /// <param name="factorA"></param>
        /// <param name="factorB"></param>
        /// <param name="carryOver"></param>
        /// <returns></returns>
        public int ComputeValueToAdd(int factorA, int factorB, bool carryOver)
        {
            int carryOverValue = carryOver ? 1 : 0;
            return (factorA + factorB + carryOverValue);
        }

        /// <summary>
        /// Get a Node's null-safe Value
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetValueFromNode(ListNode? node)
        {
            if(node == null)
            {
                return 0;
            }
            else
            {
                return node.val;
            }
        }

        /// <summary>
        /// Add a Node onto the LinkedList
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        public void AddValueToList(ref ListNode? list, int value)
        {
            if (list == null)
            {
                list = new ListNode(value);
            }
            else
            {
                GetLastNodeInList(list).next = new ListNode(value);
            }
        }

        /// <summary>
        /// Get the Last Node in a Linked List
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ListNode GetLastNodeInList(ListNode list)
        {
            if(list == null)
            {
                throw new ArgumentNullException();
            }

            if(list.next == null)
            {
                return list;
            }

            ListNode currentNode = list.next;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            return currentNode;
        }

        /// <summary>
        /// For Development Purposes
        /// Print the values of a Node
        /// </summary>
        /// <param name="list"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void DisplayNodeList(ListNode? list)
        {
            if(list == null) { throw new ArgumentNullException(); }
            ListNode currentNode = list;
            Console.Write($"( {currentNode.val} ) -> ");
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
                Console.Write($"( {currentNode.val} ) -> ");
            }

            Console.WriteLine();
        }
    }
}
