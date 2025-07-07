using System.Collections.Generic;
using UnityEngine;

public class StudyQueue : MonoBehaviour
{
    public Queue<int> queue = new Queue<int>();

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            queue.Enqueue(i); // 1 ~10���� �߰�
        }

        int output = queue.Dequeue(); // ���� ����
        Debug.Log(output);
        
        Debug.Log(queue.Peek());

        queue.Contains(5);

        queue.Clear();

        Debug.Log(queue.Count);
    }
}
