using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public enum DoorType { Left, Right }
public class Door : MonoBehaviour
{
    public DoorType doorType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (doorType == DoorType.Left && collision.CompareTag("PlayerFire"))
        {
            GameClearManager.Instance.FireOnLeftDoor = true;
        }
        else if (doorType == DoorType.Right && collision.CompareTag("PlayerWater"))
        {
            GameClearManager.Instance.WaterOnRightDoor = true;
        }

        CheckGameClear();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (doorType == DoorType.Left && collision.CompareTag("PlayerFire"))
        {
            GameClearManager.Instance.FireOnLeftDoor = false;
        }
        else if (doorType == DoorType.Right && collision.CompareTag("PlayerWater"))
        {
            GameClearManager.Instance.WaterOnRightDoor = false;
        }
    }

    //게임 클리어 성공 요건.
    private void CheckGameClear()
    {
        if (GameClearManager.Instance.FireOnLeftDoor &&
            GameClearManager.Instance.WaterOnRightDoor &&
            GameManager.Instance.CurrentTime > 0f)
        {
            GameClearManager.Instance.ShowClearPanel();
        }
    }
}
