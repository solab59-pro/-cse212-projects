/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    // Add to BACK of queue
    public void Enqueue(Person person)
    {
        _queue.Add(person);
    }

    // Remove from FRONT of queue
    public Person Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        Person person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}
