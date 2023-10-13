using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public static class GameEvent
    {
        public static System.Action onCollisionStones;
        public static event System.Action onCollisionEnter;

        public static void CollisionStoneInvoke()
        {
            onCollisionStones?.Invoke();
        }
    }

}
