using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public static class GameEvent
    {
        public static System.Action onCollisionStones;
        public static event System.Action onStickHit;

        public static void CollisionStoneInvoke(Collision collision)
        {
            onCollisionStones?.Invoke();
        }

        public static void StickHit()
        {
            onStickHit?.Invoke();
        }
    }

}
