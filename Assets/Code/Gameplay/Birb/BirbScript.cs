using Code.Managers;
using UnityEngine;

namespace Code.Gameplay.Birb
{
    public class BirbScript : CollisionObject
    {
        private bool _isFirstFlap = true;
        [SerializeField] private AudioClip flapSound1;
        [SerializeField] private AudioClip flapSound2;
        public Rigidbody2D rigidBody;
        public float flapStrength;
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && !GameManager.Instance.IsGameOver)
            {
                rigidBody.linearVelocity = Vector2.up * flapStrength;
                if (_isFirstFlap)
                {
                    AudioManager.Instance.PlayOneShot(flapSound1);
                    _isFirstFlap = false;
                }
                else
                {
                    AudioManager.Instance.PlayOneShot(flapSound2);
                }
            }
        }
    }
}
