// See https://aka.ms/new-console-template for more information

//public class ListNode {
//    public int val;
//    public ListNode next;
//    public ListNode(int val=0, ListNode next=null) {
//        this.val = val;
//        this.next = next;
//    }
//}
using LeetCode_AddTwoNum_CSharp;

Solution solution = new();

solution.AddTwoNumbers(new ListNode
{
    val = 2,
    next = new ListNode
    {
        val = 4,
        next = new ListNode
        {
            val = 3
        }
    }
},
new ListNode
{
    val = 5,
    next = new ListNode
    {
        val = 6,
        next = new ListNode
        {
            val = 4
        }
    }
});

solution.AddTwoNumbers(new ListNode
{
    val = 0
},
new ListNode
{
    val = 0
});

solution.AddTwoNumbers(new ListNode
{
    val = 9,
    next = new ListNode
    {
        val = 9,
        next = new ListNode
        {
            val = 9,
            next = new ListNode
            {
                val = 9,
                next = new ListNode
                {
                    val = 9,
                    next = new ListNode
                    {
                        val = 9,
                        next = new ListNode
                        {
                            val = 9
                        }
                    }
                }
            }
        }
    }
},
new ListNode
{
    val = 9,
    next = new ListNode
    {
        val = 9,
        next = new ListNode
        {
            val = 9,
            next = new ListNode
            {
                val = 9
            }
        }
    }
});