using System.Collections.Generic;
using UnityEngine;

public class StudyLinkedList : MonoBehaviour
{
    public LinkedList<int> linkedList1 = new LinkedList<int>();

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            linkedList1.AddLast(i); // 1 ~ 10까지 추가
        }

        linkedList1.AddFirst(100); // 가장 앞에 넣음
        linkedList1.AddLast(200); // 가장 뒤에 넣음

        var node = linkedList1.AddFirst(1);
        LinkedListNode<int> node2 = linkedList1.AddFirst(2);

        linkedList1.AddBefore(node, 200); // 특정 대상 전에 넣음
        linkedList1.AddAfter(node2, 300); // 특정 대상 이후에 넣음
    }
}
