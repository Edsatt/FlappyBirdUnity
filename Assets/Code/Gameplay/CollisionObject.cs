using Code.Managers;
using JetBrains.Annotations;
using UnityEngine;

namespace Code.Gameplay
{ 
    public class CollisionObject : MonoBehaviour
    { 
        [SerializeField] [CanBeNull] private AudioClip scoreSound;
        [SerializeField] [CanBeNull] private AudioClip collisionSound;
        [SerializeField] [CanBeNull] private AudioClip fallSound;
        protected bool CollisionEndsGame { private get; set; }
        
        protected bool CollisionIncreasesScore { private get; set; }

        protected virtual void Start()
        {
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (CollisionEndsGame)
            {
                if (collision.gameObject.layer is 3 && !GameManager.Instance.IsGameOver)
                {
                    GameManager.Instance.EndGame();
                    AudioManager.Instance.PlayAudio(collisionSound);
                }
            }
        }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (CollisionEndsGame)
            {
                if (collision.gameObject.layer is 3 && !GameManager.Instance.IsGameOver)
                {
                    GameManager.Instance.EndGame();
                    AudioManager.Instance.PlayAudio(fallSound);
                }
            }

            if (CollisionIncreasesScore)
            {
                if (collision.gameObject.layer is 3 && !GameManager.Instance.IsGameOver)
                {
                    GameManager.Instance.AddScore(1);
                    AudioManager.Instance.PlayAudio(scoreSound);
                }
            }
        }
    }
}