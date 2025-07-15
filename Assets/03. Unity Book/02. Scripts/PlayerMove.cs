using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update()
    {
        // 월드 방향 이동
        transform.position += Vector3.forward * 5 * Time.deltaTime;

        // 로컬 방향 이동
        transform.Translate(Vector3.forward * 5 * Time.deltaTime); // Space.Self

        // 월드 방향 이동
        transform.Translate(Vector3.forward * 5 * Time.deltaTime, Space.World);

        transform.rotation = Quaternion.identity; // (0, 0, 0)
        transform.rotation = Quaternion.Euler(new Vector3(30, 60, 120)); // 오일러 -> 쿼터니언

        Debug.Log(transform.rotation.eulerAngles); // 쿼터니언 -> 오일러

        var newRotation = transform.rotation.eulerAngles + Vector3.up * 5 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(newRotation);

        transform.Rotate(Vector3.up * 5 * Time.deltaTime); // Space.Self
        transform.Rotate(Vector3.up * 5 * Time.deltaTime, Space.World);
        
        transform.RotateAround(Vector3.zero, Vector3.up, 5 * Time.deltaTime); // (타겟, 도는 축, 각도)

        transform.LookAt(Vector3.zero); // 특정 타켓을 바라보는 것
    }
}
