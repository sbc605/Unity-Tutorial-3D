using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                var t = FindFirstObjectByType<T>();

                if (t != null)
                {
                    instance = t;
                }
                else
                {
                    var newObj = new GameObject(typeof(T).ToString());
                    newObj.AddComponent<T>();

                    instance = newObj.GetComponent<T>();
                }
            }

            return instance;
        }
    }

    protected virtual void Awake() // 선택적 재정의
    {
        if (instance == null)
        {
            instance = this as T; // T가 명확하지 않아서
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
