using System.Collections.Generic;
using UnityEngine;

public class StudyLinkedList : MonoBehaviour
{
    public LinkedList<int> linkedList1 = new LinkedList<int>();

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            linkedList1.AddLast(i); // 1 ~ 10���� �߰�
        }

        linkedList1.AddFirst(100); // ���� �տ� ����
        linkedList1.AddLast(200); // ���� �ڿ� ����

        var node = linkedList1.AddFirst(1);
        LinkedListNode<int> node2 = linkedList1.AddFirst(2);

        linkedList1.AddBefore(node, 200); // Ư�� ��� ���� ����
        linkedList1.AddAfter(node2, 300); // Ư�� ��� ���Ŀ� ����
    }
}
