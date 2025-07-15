using UnityEngine;

public class MergeSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    void Start()
    {
        Debug.Log("���� �� : " + string.Join(",", array));

        MSort(array, 0, array.Length - 1);
        Debug.Log("���� �� : " + string.Join(",", array));
    }

    /// <summary>
    /// ����
    /// </summary>
    private void MSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MSort(arr, left, mid);
            MSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    /// <summary>
    /// �պ�
    /// </summary>
    private void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1; // ���� �迭�� ũ��
        int n2 = right - mid; // ������ �迭�� ũ��

        // �ӽ� �迭 ũ�� ����
        int[] leftArr = new int[n1]; 
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++) // ���� �迭 �� �ʱ�ȭ
            leftArr[i] = arr[left + i];

        for (int i = 0; i < n2; i++) // ������ �迭 �� �ʱ�ȭ
            rightArr[i] = arr[mid + 1 + i];

        int j = left; // ���� �迭�� ������
        int u = 0, v = 0; // �ݺ��� ����� �ӽ� ����

        while (u < n1 && v < n2)
        {
            if (leftArr[u] <= rightArr[v]) // ���� ���� ������ ������ �۴ٸ�
            {
                arr[j] = leftArr[u];
                u++;
            }
            else // ������ ���� ���� ������ �۴ٸ�
            {
                arr[j] = rightArr[v];
                v++;
            }

            j++;
        }

        // ���� �迭�� �ִٸ� ���ľ���
        while (u < n1) // ���� �迭�� ���Ҵٸ�
        {
            arr[j] = leftArr[u];
            u++;
            j++;
        }

        while (v < n2) // ������ �迭�� ���Ҵٸ�
        {
            arr[j] = rightArr[v];
            v++;
            j++;
        }
    }
}