using System.Collections.Generic;
using UnityEngine;

public class PersonData
{
    public int age;
    public string name;
    public float height;
    public float weight;

    public PersonData(int age, string name, float height, float weight)
    {
        this.age = age;
        this.name = name;
        this.height = height;
        this.weight = weight;
    }

    public PersonData(int age, float height, float weight) // �����ε�
    {
        this.age = age;
        this.height = height;
        this.weight = weight;
    }
}

public class StudyDictionary : MonoBehaviour
{
    public Dictionary<string, PersonData> persons = new Dictionary<string, PersonData>();

    void Start()
    {
        persons.Add("ö��", new PersonData(10, "ö��", 150f, 30f));
        persons.Add("����", new PersonData(10, 150f, 30f));
        persons.Add("����", new PersonData(10, "����", 150f, 30f));

        Debug.Log(persons["ö��"].age);
        Debug.Log(persons["ö��"].name);
        Debug.Log(persons["ö��"].height);
        Debug.Log(persons["ö��"].weight);
    }    
}
