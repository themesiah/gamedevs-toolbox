using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Values/Double")]
    public class ScriptableDoubleValue : ScriptableValue<double>
    {
        #region Public Methods
        public override void IncrementValue(double increment)
        {
            Value += increment;
        }
        #endregion
    }
}