using UnityEngine;
using UnityEngine.Pool;

public class PoolManager : Singleton<PoolManager>
{
    public ObjectPool<GameObject> pool;
    public GameObject prefab;

    void Awake()
    {
        // pool = new ObjectPool<GameObject>(CreateObject, OnGetObject, OnReleaseObject, OnDestroyObject, maxSize: 100);
        pool = new ObjectPool<GameObject>(CreateObject);
    }

    private GameObject CreateObject() // 생성
    {
        GameObject obj = Instantiate(prefab);
        obj.SetActive(false);
        Debug.Log("오브젝트 생성");

        return obj;
    }

    /*
    private void OnGetObject(GameObject obj) // 넣음
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        obj.SetActive(true);
    }

    private void OnReleaseObject(GameObject obj) // 꺼냄
    {
        obj.SetActive(false);
    }

    private void OnDestroyObject(GameObject obj) // 파괴
    {
        Destroy(obj);
    } */

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = pool.Get(); // Pool에서 오브젝트를 하나 꺼내는 방법
            obj.SetActive(true);
        }
    }
}
