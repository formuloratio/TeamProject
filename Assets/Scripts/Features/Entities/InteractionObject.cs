using UnityEngine;

namespace Features.Entities
{
    public abstract class InteractionObject : MonoBehaviour
    {
        protected GameObject obstacleFire;
        protected GameObject obstacleWater;

        protected int obstacleIndex { get; set; }
        protected int fireIndex { get { return 0; } }
        protected int waterIndex { get { return 1; } }

        protected bool isFire { get; set; }
        protected bool isWater { get; set; }
        protected int[] switchIndexArray;

        public virtual void GetObjectIndex() //������Ʈ ������ ���� �ε��� ����
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
    }
}