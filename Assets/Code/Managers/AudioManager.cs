using UnityEngine;

namespace Code.Managers
{
    public class AudioManager : MonoBehaviour
    {
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
    }
}
