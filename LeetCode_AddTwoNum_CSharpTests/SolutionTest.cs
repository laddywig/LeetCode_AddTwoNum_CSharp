namespace LeetCode_AddTwoNum_CSharpTests
{
    using LeetCode_AddTwoNum_CSharp;
    using NuGet.Frameworks;

    [TestClass]
    public class SolutionTest
    {
        [DataTestMethod]
        [DataRow(1, 2, false, 3)]
        [DataRow(1, 2, true, 4)]
        [DataRow(9, 9, false, 18)]
        [DataRow(9, 9, true, 19)]
        public void ComputeValueToAdd_FromDataRowTest(int factorA, int factorB, bool carryOver, int expected)
        {
            Solution classObject = new();
            int actual = classObject.ComputeValueToAdd(factorA, factorB, carryOver);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetValueFromNode_NullNode()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            ListNode node = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            int expected = 0;
            Solution classObject = new();
            int actual = classObject.GetValueFromNode(node);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetValueFromNode_Integer()
        {
            ListNode node = new() { val = 1 };
            int expected = 1;
            Solution classObject = new();
            int actual = classObject.GetValueFromNode(node);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLastNodeInList_ArgumentNullException()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            ListNode list = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Solution classObject = new();
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
#pragma warning disable CS8604 // Possible null reference argument.
                classObject.GetLastNodeInList(list);
#pragma warning restore CS8604 // Possible null reference argument.
            }
            catch (ArgumentNullException e)
            {
                return;
            }
#pragma warning restore CS0168 // Variable is declared but never used

            Assert.Fail("The expected ArgumentNullException was not thrown.");
        }

        [TestMethod]
        public void GetLastNodeInList_ListNextNull()
        {
            ListNode list = new() { val = 1, next = null };
            ListNode expected = list;
            Solution classObject = new();
            ListNode actual = classObject.GetLastNodeInList(list);
            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next, actual.next);
        }

        [TestMethod]
        public void GetLastNodeInList_TwoSizeLastNode()
        {
            ListNode list = new() { val = 1, next = new ListNode { val = 5, next = null } };
            ListNode expected = new ListNode { val = 5, next = null };
            Solution classObject = new();
            ListNode actual = classObject.GetLastNodeInList(list);
            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next, actual.next);
        }

        [TestMethod]
        public void GetLastNodeInList_MoreThanTwoSizeLastNode()
        {
            ListNode list = new() { val = 1, next = new ListNode { val = 5, next = new ListNode { val = 9, next = null } } };
            ListNode expected = new ListNode { val = 9, next = null };
            Solution classObject = new();
            ListNode actual = classObject.GetLastNodeInList(list);
            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next, actual.next);
        }

        [TestMethod]
        public void AddValueToList_ListIsNull()
        {
            ListNode? list = null;
            int expectedVal = 9;
            ListNode expected = new ListNode { val = expectedVal, next = null };
            Solution classObject = new();
            classObject.AddValueToList(ref list, expectedVal);
            Assert.AreEqual(expected.val, list?.val);            
        }

        [TestMethod]
        public void AddValueToList_ListIsNotNull()
        {
            ListNode? list = new ListNode { val = 1, next = null };
            int expectedVal = 9;
            ListNode expected = new ListNode { val = 1, next = new ListNode { val = expectedVal, next = null } };
            Solution classObject = new();
            classObject.AddValueToList(ref list, expectedVal);
            Assert.AreEqual(expected.next.val, list?.next?.val);
        }
    }
}