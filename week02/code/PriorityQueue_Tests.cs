using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:
    // Add three items with different priorities.
    // Expected Result:
    // Dequeue returns the value with the highest priority.
    // Defect(s) Found:
    // - Last element was not checked
    // - Item was not removed from queue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario:
    // Add multiple items with the same highest priority.
    // Expected Result:
    // The first item added (FIFO) with that priority is removed.
    // Defect(s) Found:
    // - FIFO rule violated when priorities were equal
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }
}
