using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Switch : InteractionObject
{
    // ������ ����Ǵ� ����ġ ��ȣ
    public int switchIndex = 0;

    public override void Interact()
    {

    }

    void Start()
    {
        Transform parentTransform = this.transform;
        for (int i = 0; i < parentTransform.childCount; i++)
        {
            Transform childTransform = parentTransform.GetChild(i);

            if (childTransform.gameObject.activeSelf)
            {
                obstacleIndex = i;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //�÷��̾ ���� ��
        if (collider.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == waterIndex) //���� ���̸�
            {
                //����ġ ����
                isSwitching = true;
                isWater = true;
                switchIndexArray[switchIndex] = 1;
                Debug.Log("�� ����ġ ON");
            }
        }
        //�÷��̾ ���� ��
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == fireIndex) //���� ���̸�
            {
                //����ġ ����
                isSwitching = true;
                isFire = true;
                switchIndexArray[switchIndex] = 1;
                Debug.Log("�� ����ġ ON");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        //�÷��̾ ���� ��
        if (collider.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == waterIndex) //���� ���̸�
            {
                //����ġ ����
                isSwitching = false;
                isWater = false;
                Debug.Log("�� ����ġ OFF");
            }
        }
        //�÷��̾ ���� ��
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == fireIndex) //���� ���̸�
            {
                //����ġ ����
                isSwitching = false;
                isFire = false;
                Debug.Log("�� ����ġ OFF");
            }
        }
    }
}
