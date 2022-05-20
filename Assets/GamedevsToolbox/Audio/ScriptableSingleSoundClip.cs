using UnityEngine;

namespace GamedevsToolbox.Audio
{
    [CreateAssetMenu(menuName = "Audio/Scriptable Single Sound Clip")]
    public class ScriptableSingleSoundClip : ScriptableAudioClip
    {
        [SerializeField]
        private AudioClip clip = default;
        [SerializeField]
        private ScriptableArchitecture.Values.ScriptableFloatReference pitch = default;
        [SerializeField]
        private ScriptableArchitecture.Values.ScriptableFloatReference volume = default;

        public override AudioClip GetClip()
        {
            return clip;
        }

        public override float GetPitch()
        {
            return pitch.Value;
        }

        public override float GetVolume()
        {
            return volume.Value;
        }
    }
}