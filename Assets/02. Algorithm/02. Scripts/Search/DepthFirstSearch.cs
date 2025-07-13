using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSearch : MonoBehaviour
{
    private int[,] nodes = new int[8, 8]
    {
      // 0  1  2  3  4  5  6  7
        {0, 1, 1, 1, 0, 0, 0, 0}, // 0
        {1, 0, 0, 0, 1, 1, 0, 0}, // 1
        {1, 0, 0, 0, 0, 0, 0, 0}, // 2
        {1, 0, 0, 0, 0, 0, 1, 0}, // 3
        {0, 1, 0, 0, 0, 1, 0, 0}, // 4
        {0, 1, 0, 0, 1, 0, 0, 1}, // 5
        {0, 0, 0, 1, 0, 0, 0, 0}, // 6
        {0, 0, 0, 0, 0, 1, 0, 0}, // 7
    };

    public Stack<int> stack = new Stack<int>();
    private bool[] visited = new bool[8];

    void Start()
    {
        DFSearch(0);
    }

    private void DFSearch(int start)
    {
        stack.Push(start);

        while (stack.Count > 0) // �湮 �������� 1���� �����ִٸ� ��� ��
        {
            int index = stack.Pop(); // �湮�� ��ȣ�� ����

            if (!visited[index]) // �湮 �ߴ��� ���ߴ���
            {
                visited[index] = true; // �湮 �ߴٰ� ����
                Debug.Log($"{index}�� ��忡 �湮");

                for (int i = nodes.GetLength(0) - 1; i >= 0; i--) // ���̴� 8�ε� �ε����� 7���� �����ϴϱ� -1
                {
                    if (nodes[index, i] == 1 && !visited[i])
                    {
                        stack.Push(i);
                    }
                }
            }
        }
    }
}
