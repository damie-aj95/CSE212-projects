using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add one item and remove it
    // Expected Result: The same item is returned
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 1);
        var result = queue.Dequeue();

        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Add two items with different priorities
    // Expected Result: Item with highest priority is returned first
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 1);
        queue.Enqueue("B", 5);

        var result = queue.Dequeue();
        Assert.AreEqual("B", result);
    }

   [TestMethod]
// Scenario: Add multiple items with same priority
// Expected Result: Items are returned in FIFO order
// Defect(s) Found:
// The queue did not preserve FIFO order when priorities were equal.
public void TestPriorityQueue_FIFO()
{
    var queue = new PriorityQueue();

    queue.Enqueue("A", 5);
    queue.Enqueue("B", 5);

    var first = queue.Dequeue();
    var second = queue.Dequeue();

    Assert.AreEqual("A", first);
    Assert.AreEqual("B", second);
}

[TestMethod]
// Scenario: Add multiple items with mixed priorities
// Expected Result: Items are removed from highest to lowest priority
// Defect(s) Found:
// The queue failed to correctly evaluate all elements when determining
// the highest priority item.
public void TestPriorityQueue_Mixed()
{
    var queue = new PriorityQueue();

    queue.Enqueue("A", 1);
    queue.Enqueue("B", 3);
    queue.Enqueue("C", 2);

    Assert.AreEqual("B", queue.Dequeue());
    Assert.AreEqual("C", queue.Dequeue());
    Assert.AreEqual("A", queue.Dequeue());
}

[TestMethod]
// Scenario: Attempt to dequeue from an empty queue
// Expected Result: InvalidOperationException with correct message
// Defect(s) Found:
// The queue either did not throw an exception or used the wrong message/type.
public void TestPriorityQueue_Empty()
{
    var queue = new PriorityQueue();

    try
    {
        queue.Dequeue();
        Assert.Fail("Exception should have been thrown.");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}
}