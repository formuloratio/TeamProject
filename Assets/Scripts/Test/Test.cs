using Core;
using Features.Entities;
using UnityEngine;

namespace Test
{
    public class Test : MonoBehaviour
    {
        private AchievementManager _achievementManager;

        void Awake()
        {
            _achievementManager = AchievementManager.Instance;
        }
        void Start()
        {

        }
    }
}
