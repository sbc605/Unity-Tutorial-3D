using UnityEngine;

public class SingletonEx5 : MonoBehaviour
{
    private static SingletonEx5 instance;
    public static SingletonEx5 Instance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindFirstObjectByType<SingletonEx5>(); // ã�ƺ��� ���

                if (obj != null) // ã�� ���
                {
                    instance = obj;     
                }
                else
                {
                    var newObj = new GameObject("Singleton"); // Singleton�̶�� �̸��� ������Ʈ ����
                    newObj.AddComponent<SingletonEx5>();

                    instance = newObj.GetComponent<SingletonEx5>();
                }
            }

            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null) // �Ҵ��ؼ� �̱���ȭ
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else // �ߺ� ����
        {
            Destroy(gameObject);
        }
    }
}
