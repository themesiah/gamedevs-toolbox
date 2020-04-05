using UnityEngine;

namespace GamedevsToolbox.ScriptableArchitecture.Values
{
    [CreateAssetMenu(menuName = "Scriptable Architecture/Random/Integer")]
    public class ScriptableRandomInt : ScriptableObject
    {
        [SerializeField]
        private ScriptableIntReference min = default;
        [SerializeField]
        private ScriptableIntReference max = default;

        public int GetValue()
        {
            return Random.Range(min.GetValue(), max.GetValue());
        }

        public void SetValue(int value)
        {
        }
    }
}