using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 dir;
    public float speed = 5;

    public GameObject explosionFactory;

    void OnEnable()
    {
        int ranValue = UnityEngine.Random.Range(0, 10);

        if (ranValue < 3) // 30%
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position; // 플레이어를 바라보는 방향 값
            dir.Normalize();
        }
        else // 70%
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        /* 
        // 점수 증가
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();

        // sm.SetScore(sm.GetScore() + 1); // 책에 적힌 거
        var score = sm.GetScore() + 1;
        sm.SetScore(score); */

        // ScoreManager.Instance.SetScore(ScoreManager.Instance.GetScore() + 1);
        ScoreManager.Instance.Score++;

        // 파티클 생성
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        // 파괴 기능
        if (other.gameObject.name.Contains("Bullet"))
        {          
            // PlayerFire.Instance.bulletObjPool.Add(other.gameObject);

            PlayerFire.Instance.bulletObjPool.Enqueue(other.gameObject);

            other.gameObject.SetActive(false); // 총알 오브젝트 비활성화
        }
        else
        {
            Destroy(other.gameObject); // 플레이어
        }

        // EnemyManager.Instance.enemyObjPool.Add(this.gameObject);
        EnemyManager.Instance.enemyObjPool.Enqueue(gameObject);
        gameObject.SetActive(false); // Enemy
    }
}