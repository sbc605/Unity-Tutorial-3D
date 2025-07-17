using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : Singleton<PlayerFire>
{
    public GameObject bulletFactory;
    public GameObject firePosition;

    public int poolSize = 10;
    // public GameObject[] bulletObjectPool;
    // public List<GameObject> bulletObjPool;
    public Queue<GameObject> bulletObjPool;

    private void Start()
    {
        // bulletObjectPool = new GameManager[poolSize];
        // bulletObjPool = new List<GameObject>();
        bulletObjPool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            // bulletObjPool[i] = bullet; // 배열
            // bulletObjPool.Add(bullet); // 리스트
            bulletObjPool.Enqueue(bullet); // 큐

            bullet.SetActive(false); // 풀에 들어갈 때니까 끔
        }
    }

    void Update()
    {
#if UNITY_STANDARDALONE || UNITY_EDITOR
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log ("마우스 클릭");

            if (bulletObjPool.Count > 0)
            {
                GameObject bullet = bulletObjPool.Dequeue();
                bullet.SetActive(true);
                bullet.transform.position = firePosition.transform.position;
            }
            /* 리스트 방식 
            if (bulletObjPool.Count > 0)
            {
                
                GameObject bullet = bulletObjPool[0]; // 가져올 오브젝트 선택
                bullet.SetActive(true); //오브젝트 사용

                bulletObjPool.Remove(bullet); // Pool에서 오브젝트 제거

                bullet.transform.position = firePosition.transform.position;                
            } */

            /* 배열 방식
            for (int i = 0; i < poolSize; i++)
            {
                GameObject bullet = bulletObjPool[i];

                if (!bullet.activeSelf) // 선택한 총알 오브젝트가 off상태인지 확인
                {
                    bullet.SetActive(true); // 총알 사용하기 위해 활성화
                    bullet.transform.position = firePosition.transform.position; // 발사 위치 조정

                    break; // 반복문 끝
                }
            }     */
                        
#endif
        }
}
}