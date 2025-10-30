using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    // 스위치 인덱스랑 같아야 함
    public int elevatorIndex = 0;

    public float speed = 2.0f;
    Rigidbody2D rb;

    public float maxLine = 3.0f;
    public float minLine = 1.5f;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (SwitchingManager.Instance.isSwitching == true && SwitchingManager.Instance.switchTagCompare[elevatorIndex] == 1)
        {
            ElevatorMoveUp();
        }
        else if (SwitchingManager.Instance.isSwitching == false)
        {
            ElevatorMoveDown();
        }
    }

    private void ElevatorMoveUp()
    {
        if (this.gameObject.transform.position.y < maxLine)
            rb.AddForce(Vector3.up * speed);
    }

    private void ElevatorMoveDown()
    {
        if (this.gameObject.transform.position.y > minLine)
            rb.AddForce(Vector3.down * speed);
    }
}
