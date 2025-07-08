using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    /*
    private object[] array = new object[3]; // � Ÿ���̵� �� �� �ִ� objectŸ���� �迭
    // �����迭�� ũ�Ⱑ ������ ����

    void Add(object o)
    {
        int newSize = array.Length * 2;
        var temp = new object[newSize];
        // var temp = new object[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }

        array = temp;
        array[array.Length -1] = o;
    } */

    /*
    private List<int> list1 = new List<int>();
    private List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };
    public List<int> list3;
    [SerializeField] private List<int> list4;

    private void Start()
    {
        // ����Ʈ(�����迭)�� �� 10 �߰�
        list1.Add(10);
        list2.Add(10);
        list3.Add(10);
        list4.Add(10);

        list3.Add(20);
    } */

    public List<int> list1 = new List<int>();

    private void Start()
    {
        for (int i = 1; i <= 10; i++) // 1 ~ 10���� ���� list1�� �߰�
        {
            list1.Add(i);
        }

        // list1.Insert(5, 100);
        // list1.Remove(5); // �� 5 ����
        // list1.RemoveAt(5); // Index 5���� ����
        // list1.RemoveRange(1, 3); // Index 1������ 3������ ����
        //list1.Clear(); // ������ ��� ����
        // list1.RemoveAll(x => x >5); // ���� List �ȿ��� x >5 ���� ��� ����

        // List�� �ִ� ��� ���� Ȯ���ϴ� ���
        string str = string.Empty; // ""
        foreach (var x in list1)
        {
            str += x.ToString() + " / ";
        }
        Debug.Log(str);

        if (list1.Contains(10)) // List���� 10�̶�� ���� ������ true
        {
            Debug.Log("�� 10�� ���� o");
        }
        else
        {
            Debug.Log("�� 10�� ���� x");
        }
    }
}
