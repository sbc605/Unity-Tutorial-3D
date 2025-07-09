using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Rigt }
    public BarType barType;

    public Stack<GameObject> barStack = new Stack<GameObject>();

    private void OnMouseDown()
    {
        if (!HanoiTower.isSelected) // ����x ����
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else // ����o ����
        {            
            PushDonut(HanoiTower.selectedDonut);
        }        
    }

    public bool CheckDonut(GameObject donut) // ���� �ѹ� Ȯ��
    {
        if (barStack.Count > 0)
        {
            int pushNumber = donut.GetComponent<Donut>().donutNumber;

            GameObject peekDonut = barStack.Peek();
            int peekNumber = peekDonut.GetComponent<Donut>().donutNumber;

            if (pushNumber < peekNumber)
            {
                return true;
            }
            else
            {
                Debug.Log ($"���� �������� ������ {pushNumber}�̰�, �ش� ����� ���� �� ������ {peekNumber}�Դϴ�.");
                return false;
            }
        }

        return true;
    }


    public void PushDonut(GameObject donut)
    {
        if (!CheckDonut(donut))        
            return;

        HanoiTower.isSelected = false;
        HanoiTower.selectedDonut = null;

        donut.transform.position = transform.position + Vector3.up * 5f; // Vector3(0,1,0);
        // �ڽ� ����� ��ġ�� y = 5f ��ġ�� ����
        donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        barStack.Push(donut); // Stack�� GameObject�� �ִ� ���
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop(); // Stack���� GameObject�� ������ ���

        return donut; // ���� ������ ��ȯ
    }
}
