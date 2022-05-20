using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Values/Short")]
    public class ScriptableShortValue : ScriptableValue<short>
    {
        #region Public Methods
        public override void IncrementValue(short increment)
        {
            Value += increment;
        }
        #endregion
    }
}