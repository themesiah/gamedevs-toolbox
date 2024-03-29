﻿using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Values/Long")]
    public class ScriptableLongValue : ScriptableValue<long>
    {
        #region Public Methods
        public override void IncrementValue(long increment)
        {
            Value += increment;
        }
        #endregion
    }
}