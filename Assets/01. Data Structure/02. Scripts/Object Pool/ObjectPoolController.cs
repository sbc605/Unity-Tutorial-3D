using UnityEngine;

public class ObjectPoolController : MonoBehaviour
{
    public ObjectPoolQueue pool;
    public Transform shootPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Ǯ���� ���� ���
            GameObject bullet = pool.DequeueObject();
            bullet.transform.position = shootPos.position;
        }
    }
}
