using UnityEngine;

public class StudyString : MonoBehaviour
{
    public string str1 = "Hello World***"; // �׳� string

    public string[] str2 = new string[3] { "Hello", "Unity", "World" }; // string �迭


    void Start()
    {
        /*
        Debug.Log(str1[0]); // H
        Debug.Log(str1[2]); // l

        Debug.Log(str2[0]); // Hello
        Debug.Log(str2[2]); // World

        Debug.Log(str1.Length); // ���ڿ��� ����
        Debug.Log(str1.Trim()); // �յ� ���� ���� // " Hello World " �̷��� �Ǿ������� �յ� ���� �ڸ�
        Debug.Log(str1.Trim('*')); // �յ� ���� '*' ����
        */

        /*
        Debug.Log(str1.Contains('H')); // H�� �ִ���
        Debug.Log(str1.Contains('h')); // h�� �ִ���


        Debug.Log(str1.Contains("Hello")); // Hello�� �ִ���

        Debug.Log(str1.ToUpper()); // �빮�� ��ȯ
        Debug.Log(str1.ToLower()); // �ҹ��� ��ȯ
        */

        // Debug.Log(str1.Replace("World", "Unity"));
        str1 = str1.Replace("World", "Unity");
        Debug.Log(str1);

        string text = "Apple,Banana,Orange,Melon,Water Melon,Mango";

        string[] fruits = text.Split(','); // Ư�� ���ڷ� �ɰ���

        foreach (var fruit in fruits)
        {
            Debug.Log(fruit);
        }
    }
}
