using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Values/Integer")]
    public class ScriptableIntValue : ScriptableValue<int>
    {
        #region Public Methods
        public override void IncrementValue(int increment)
        {
            Value += increment;
        }
        #endregion
    }
}