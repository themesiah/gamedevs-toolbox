using UnityEngine;
using UnityEngine.Events;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    public class ScriptableValueListener<T,T2> : MonoBehaviour where T : System.IEquatable<T> where T2 : ScriptableValue<T>
    {
        [SerializeField]
        private T2 valueReference = default;
        [SerializeField]
        private UnityEvent<T> OnValueChangedEvent = default;

        private void Start()
        {
            OnValueChanged(valueReference.Value);
        }

        private void OnEnable()
        {
            valueReference.OnValueChangedEvent += OnValueChanged;
        }

        private void OnDisable()
        {
            valueReference.OnValueChangedEvent -= OnValueChanged;
        }

        private void OnValueChanged(T newValue)
        {
            OnValueChangedEvent?.Invoke(newValue);
        }
    }
}