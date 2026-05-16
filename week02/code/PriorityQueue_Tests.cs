using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and then dequeue them
    // Expected Result: Items are dequeued in order of highest to lowest priority
    // Defect(s) Found: Did not remove dequeued from the list, and did not correctly find the highest priority item
    public void TestPriorityQueue_BasicDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        string firstDequeued = priorityQueue.Dequeue();
        Assert.AreEqual("B", firstDequeued);
        Assert.AreEqual("[A (1), C (2)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Dequeue until empty and try to dequeue again
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: Did not handle empty queue correctly
    public void TestPriorityQueue_DequeueUntilEmpty()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty.");
    }

    // Add more test cases as needed below.
}