using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    public int poolSize = 10;
    //public GameObject[] enemyObjPool;
    public Transform[] spawnPos;

    // public List<GameObject> enemyObjPool;
    public Queue<GameObject> enemyObjPool;

    private float currentTime; // 타이머

    private float minTime = 1;
    private float maxTime = 5;
    
    public float createTime = 1f; // 생성 주기

    public GameObject enemyFactory;

    void Start()
    {
        createTime = Random.Range(minTime, maxTime);

        // enemyObjPool = new GameObject[poolSize];
        // enemyObjPool = new List<GameObject>();
        enemyObjPool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyFactory);

            // enemyObjPool[i] = enemy;
            // enemyObjPool.Add(enemy);
            enemyObjPool.Enqueue(enemy);
            enemy.SetActive(false);
        }
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > createTime) // 랜덤 타임에 랜덤 위치에 Enemy 생성
        {
            if (enemyObjPool.Count > 0)
            {
                currentTime = 0f;
                createTime = Random.Range(minTime, maxTime);

                GameObject enemy = enemyObjPool.Dequeue();

                int ranIndex = Random.Range(0, spawnPos.Length);
                Transform spawnPoint = spawnPos[ranIndex];
                enemy.transform.position = spawnPoint.position;

                enemy.SetActive(true);

            }


            /* 리스트
            if (enemyObjPool.Count > 0)
            {
                currentTime = 0f;
                createTime = Random.Range(minTime, maxTime);

                GameObject enemy = enemyObjPool[0];

                int ranIndex = Random.Range(0, spawnPos.Length);
                Transform spawnPoint = spawnPos[ranIndex];
                enemy.transform.position = spawnPoint.position;

                enemyObjPool.Remove(enemy);
                enemy.SetActive(true);
            } */

                /* 배열
                for (int i = 0; i < poolSize; i++)
                {     
                    GameObject enemy = enemyObjPool[i];
                    if (!enemy.activeSelf)
                    {
                        int ranIndex = Random.Range(0, spawnPos.Length);
                        Transform spawnPoint = spawnPos[ranIndex];

                        enemy.transform.position = spawnPoint.position;
                        enemy.SetActive(true);

                        break;
                    } */
        }
    }    
}