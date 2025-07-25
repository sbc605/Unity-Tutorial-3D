using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BubbleSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    void Start()
    {
        Debug.Log("정렬 전 : " + string.Join(", ", array));

        Bubble(array);
        Debug.Log("정렬 후 : " + string.Join(", ", array));
    }

    private void Bubble(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n -i -1; j++) // 확정값에서 하나씩 빼느라 -i-1
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j +1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
