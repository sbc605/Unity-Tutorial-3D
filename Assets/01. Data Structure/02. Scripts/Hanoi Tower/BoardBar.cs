using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Rigt }
    public BarType barType;

    public Stack<GameObject> barStack = new Stack<GameObject>();

    private void OnMouseDown()
    {
        if (!HanoiTower.isSelected) // 선택x 상태
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else // 선택o 상태
        {            
            PushDonut(HanoiTower.selectedDonut);
        }        
    }

    public bool CheckDonut(GameObject donut) // 도넛 넘버 확인
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
                Debug.Log ($"현재 넣으려는 도넛은 {pushNumber}이고, 해당 기둥의 제일 위 도넛은 {peekNumber}입니다.");
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
        // 자신 막대기 위치의 y = 5f 위치에 생성
        donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        barStack.Push(donut); // Stack에 GameObject를 넣는 기능
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop(); // Stack에서 GameObject를 꺼내는 기능

        return donut; // 꺼낸 도넛을 반환
    }
}
