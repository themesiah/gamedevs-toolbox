using UnityEngine;

namespace GamedevsToolbox.Examples
{
    public class DictTest : MonoBehaviour
    {
        public Dictionary.SerializableDictionary<string, GamedevsToolbox.ScriptableArchitecture.Values.ScriptableIntReference> dictionary;

        private void Awake()
        {
            foreach(var values in dictionary)
            {
                Debug.LogFormat("{0}: {1}", values.Key, values.Value.Value);
            }
        }
    }
}