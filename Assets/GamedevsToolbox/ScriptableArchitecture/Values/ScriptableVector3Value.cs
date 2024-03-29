﻿#pragma warning disable CS0649
using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Values/Vector3")]
    public class ScriptableVector3Value : ScriptableValue<Vector3>
    {
        #region Public Methods
        public override void IncrementValue(Vector3 increment)
        {
            Value += increment;
        }
        #endregion
    }
}