using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            // PlayerFire.Instance.bulletObjPool.Add(other.gameObject); // ÃÑ¾Ë
            PlayerFire.Instance.bulletObjPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false);
        }
        else
        {
            // EnemyManager.Instance.enemyObjPool.Add(other.gameObject);
            EnemyManager.Instance.enemyObjPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false); // Enemy
        }            
    }
}