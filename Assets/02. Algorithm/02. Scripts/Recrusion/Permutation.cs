using UnityEngine;

public class Permutation : MonoBehaviour
{
    public int[] array = new int[3] { 1, 2, 3 };

    void Start()
    {
        PermutationFunction(array, 0);
    }

    private void PermutationFunction(int[] arr, int startIndex)
    {
        if (startIndex == arr.Length) // exit ���
        {
            Debug.Log(string.Join(",", arr));
            return;
        }

        for (int i = startIndex; i < arr.Length; i++)
        {
            // Swap : �ڸ� �ٲٱ�
            var temp = arr[startIndex];
            arr[startIndex] = arr[i];
            arr[i] = temp;

            PermutationFunction(arr, startIndex + 1);

            // ���󺹱� BackTracking
            temp = arr[startIndex];
            arr[startIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
