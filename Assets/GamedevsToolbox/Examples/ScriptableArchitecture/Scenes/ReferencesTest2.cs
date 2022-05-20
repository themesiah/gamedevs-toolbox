using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamedevsToolbox.ScriptableArchitecture.Values;

namespace GamedevsToolbox.Examples
{
    public class ReferencesTest2 : MonoBehaviour
    {
        [SerializeField]
        public ScriptableFloatReference floatValue;
        [SerializeField]
        public ScriptableBoolReference boolValue;
        [SerializeField]
        public ScriptableDoubleReference doubleValue;
        [SerializeField]
        public ScriptableIntReference intValue;
        [SerializeField]
        public ScriptableLongReference longValue;
        [SerializeField]
        public ScriptableShortReference shortValue;
        [SerializeField]
        public ScriptableStringReference stringValue;
        [SerializeField]
        public ScriptableVector2Reference vec2Value;
        [SerializeField]
        public ScriptableVector3Reference vec3Value;

        private void Start()
        {
            Debug.Log(floatValue.Value.ToString());
            Debug.Log(boolValue.Value.ToString());
            Debug.Log(doubleValue.Value.ToString());
            Debug.Log(intValue.Value.ToString());
            Debug.Log(longValue.Value.ToString());
            Debug.Log(shortValue.Value.ToString());
            Debug.Log(stringValue.Value.ToString());
            Debug.Log(vec2Value.Value.ToString());
            Debug.Log(vec3Value.Value.ToString());
        }
    }
}