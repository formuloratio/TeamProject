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
            Achievement clear = _achievementManager.GetAchievement("Clear_Equal_1");
            Achievement death = _achievementManager.GetAchievement("Death_Over_2");

            Debug.Log($"clear: {clear.AchievementData.clearType} + {clear.AchievementData.targetCount} + {clear.AchievementData.displayName} + {clear.AchievementData.achievementType}");
        }
    }
}
