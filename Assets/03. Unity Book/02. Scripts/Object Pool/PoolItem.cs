using UnityEngine;

public class PoolItem : MonoBehaviour
{
    private bool isInit = false;

    private void OnEnable()
    {
        if (!isInit)
            isInit = true;
        else
            Invoke("ReturnObject", 3f);
    }

    private void ReturnObject()
    {
        PoolManager.Instance.pool.Release(gameObject);
    }
}
