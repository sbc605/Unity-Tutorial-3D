using UnityEngine;

public class SingletonEx3 : MonoBehaviour
{
    private static SingletonEx3 instance = new SingletonEx3(); // 내부 변수
    public static SingletonEx3 Instance
    {
        get
        {
            if (Instance == null)
            {
                instance = new SingletonEx3();
            }

            return instance;
        }
    }
}
