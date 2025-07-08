using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    /*
    private object[] array = new object[3]; // 어떤 타입이든 들어갈 수 있는 object타입의 배열
    // 정적배열은 크기가 변하지 않음

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
        // 리스트(동적배열)에 값 10 추가
        list1.Add(10);
        list2.Add(10);
        list3.Add(10);
        list4.Add(10);

        list3.Add(20);
    } */

    public List<int> list1 = new List<int>();

    private void Start()
    {
        for (int i = 1; i <= 10; i++) // 1 ~ 10까지 값을 list1에 추가
        {
            list1.Add(i);
        }

        // list1.Insert(5, 100);
        // list1.Remove(5); // 값 5 제거
        // list1.RemoveAt(5); // Index 5번을 제거
        // list1.RemoveRange(1, 3); // Index 1번에서 3개까지 제거
        //list1.Clear(); // 데이터 모두 제거
        // list1.RemoveAll(x => x >5); // 현재 List 안에서 x >5 값은 모두 제거

        // List에 있는 모든 값을 확인하는 방법
        string str = string.Empty; // ""
        foreach (var x in list1)
        {
            str += x.ToString() + " / ";
        }
        Debug.Log(str);

        if (list1.Contains(10)) // List에서 10이라는 값이 있으면 true
        {
            Debug.Log("값 10이 존재 o");
        }
        else
        {
            Debug.Log("값 10이 존재 x");
        }
    }
}
