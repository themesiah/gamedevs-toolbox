using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Values/Float")]
    [System.Serializable]
    public class ScriptableFloatValue : ScriptableValue<float>
    {
        [SerializeField]
        private float maxValue = default;

        [SerializeField]
        private bool useMaxValue = false;

        #region Public Methods
        public override void IncrementValue(float increment)
        {
            Value += increment;
        }

        public override float Value {
            get => base.Value;
            set
            {
                if (useMaxValue && value > maxValue)
                    base.Value = maxValue;
                else
                    base.Value = value;
            }
        }
        #endregion
    }
}