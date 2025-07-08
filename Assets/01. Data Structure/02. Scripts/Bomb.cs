using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private Rigidbody bombRb;
    public float bombTime = 4f;
    public float bombRange = 10f;
    public LayerMask layerMask;

    void Awake()
    {
        bombRb = GetComponent<Rigidbody>();
    }

    // ���ϴ� Ÿ�ֿ̹� ��ź ȿ�� ����
    IEnumerator Start()
    {
        yield return new WaitForSeconds(bombTime);

        BombForce();
    }  
    
    private void BombForce()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, bombRange, layerMask);

        foreach (var collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            // AddExplosionForce(���� �Ŀ�, ���� ��ġ, ���� ����, ���� ����)
            rb.AddExplosionForce(500f, transform.position, bombRange, 1f);
        }

        Destroy(gameObject);
    }
}
