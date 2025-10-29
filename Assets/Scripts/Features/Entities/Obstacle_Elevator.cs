using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Elevator : InteractionObject
{
    //// 스위치 인덱스랑 같아야 함
    //public int elevatorIndex = 0;
    //public float speed = 2.0f;
    //Rigidbody2D rb;

    public override void Interact()
    {

    }

    //void Start()
    //{
    //    rb = gameObject.GetComponent<Rigidbody2D>();
    //}

    //private void Update()
    //{
    //    if (switchIndexArray[elevatorIndex] != null)
    //        return;

    //    ElevatorMove();
    //}

    //private void ElevatorMove()
    //{
    //    if (switchIndexArray[elevatorIndex] == 1)
    //    {
    //        if (isSwitching && isFire)
    //        {
    //            rb.AddForce(Vector3.up * speed);
    //        }
    //        else if (isSwitching && isWater)
    //        {
    //            rb.AddForce(Vector3.up * speed);
    //        }
    //    }
    //}
}
