using UnityEngine;
using UnityEngine.Events;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [System.Serializable]
    public class ScriptableValue<T> : ScriptableObject where T : System.IEquatable<T>
    {
        [SerializeField]
        private T value = default;

        [SerializeField]
        [Tooltip("A default value may come in handy to reset it at the start of a level, for example.")]
        private T defaultValue = default;

        [SerializeField]
        private bool resetOnAwake = false;

        private T lastValue;
        public event UnityAction<T> OnValueChangedEvent = delegate { };

        private void Awake()
        {
            if (resetOnAwake)
            {
                Debug.LogFormat("ScriptableValue {0} reseted on awake", name);
                ResetValue();
            }
        }

        #region IScriptableValue implementation
        public virtual T Value
        {
            get => value;
            set
            {
                lastValue = this.value;
                this.value = value;
                InvokeOnChangeAction();
            }
        }

        public virtual void IncrementValue(T increment) { }

        public void ResetValue()
        {
            Value = defaultValue;
        }
        #endregion

        #region Private Methods
        private void InvokeOnChangeAction()
        {
            if (OnValueChangedEvent != null && !lastValue.Equals(value))
            {
                OnValueChangedEvent.Invoke(value);
            }
        }
        #endregion
    }
}