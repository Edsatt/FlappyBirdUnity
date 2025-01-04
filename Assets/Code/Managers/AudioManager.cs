using JetBrains.Annotations;
using UnityEngine;

namespace Code.Managers
{
    public class AudioManager : MonoBehaviour
    {
        public AudioSource audioSource;
        
        private static AudioManager _instance;

        public static AudioManager Instance
        {
            get
            {
                if (_instance is null)
                {
                    Debug.LogError("AudioManager is null!");
                }
                return _instance;
            }
        }

        private void Awake()
        {
            _instance = this;
        }

        public void PlayOneShot(AudioClip clip)
        {
            audioSource.PlayOneShot(clip);
        }

        public void PlayAudio([CanBeNull] AudioClip audioClip)
        {
            if (audioClip is null)
            {
                Debug.LogError("Audio clip is null!");
                return;
            }
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
