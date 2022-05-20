#pragma warning disable CS0649
using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Values/Vector2")]
    public class ScriptableVector2Value : ScriptableValue<Vector2>
    {
        #region Public Methods
        public override void IncrementValue(Vector2 increment)
        {
            Value += increment;
        }
        #endregion
    }
}