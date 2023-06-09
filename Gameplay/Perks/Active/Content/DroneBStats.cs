﻿using Sirenix.OdinInspector;
using UnityEngine;

namespace Gameplay.Perks.Active.Content
{
    [System.Serializable]
    public class DroneBStats
    {
        [Space(20)]
        [GUIColor(1.0f, 0.7f, 0.0f)] public float damage = 10;
      //  [GUIColor(1.0f, 0.5f, 0.0f)] public float attackSpeed;
        //[GUIColor(0.9f, 0.9f, 0.9f)] public int count = 1;
        [GUIColor(1.0f, 0.5f, 0.0f)] public int count = 1;
        [GUIColor(1.0f, 0.7f, 0.0f)] public float cooldown = 4;
    }
}