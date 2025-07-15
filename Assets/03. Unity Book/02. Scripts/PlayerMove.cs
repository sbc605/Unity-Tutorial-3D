using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update()
    {
        // ���� ���� �̵�
        transform.position += Vector3.forward * 5 * Time.deltaTime;

        // ���� ���� �̵�
        transform.Translate(Vector3.forward * 5 * Time.deltaTime); // Space.Self

        // ���� ���� �̵�
        transform.Translate(Vector3.forward * 5 * Time.deltaTime, Space.World);

        transform.rotation = Quaternion.identity; // (0, 0, 0)
        transform.rotation = Quaternion.Euler(new Vector3(30, 60, 120)); // ���Ϸ� -> ���ʹϾ�

        Debug.Log(transform.rotation.eulerAngles); // ���ʹϾ� -> ���Ϸ�

        var newRotation = transform.rotation.eulerAngles + Vector3.up * 5 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(newRotation);

        transform.Rotate(Vector3.up * 5 * Time.deltaTime); // Space.Self
        transform.Rotate(Vector3.up * 5 * Time.deltaTime, Space.World);
        
        transform.RotateAround(Vector3.zero, Vector3.up, 5 * Time.deltaTime); // (Ÿ��, ���� ��, ����)

        transform.LookAt(Vector3.zero); // Ư�� Ÿ���� �ٶ󺸴� ��
    }
}
