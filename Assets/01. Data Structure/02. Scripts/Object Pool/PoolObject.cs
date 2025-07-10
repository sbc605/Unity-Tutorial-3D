using UnityEngine;

public class PoolObject : MonoBehaviour
{
    private ObjectPoolQueue pool; // ���ư� Ǯ��
    public float bulletSpeed = 70f;

    void Awake()
    {
        pool = FindFirstObjectByType<ObjectPoolQueue>();
    }

    private void OnEnable()
    {
        Invoke("RetrunPool", 3f);
    }

    private void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * bulletSpeed;
    }

    void RetrunPool()
    {
        pool.EnqueueObject(gameObject);
    }
}
