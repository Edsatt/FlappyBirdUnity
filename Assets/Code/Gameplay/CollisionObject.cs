using Code.Managers;
using UnityEngine;

namespace Code.Gameplay
{ 
    public class CollisionObject : MonoBehaviour
    { 
        protected bool CollisionEndsGame { private get; set; }
        
        protected bool CollisionIncreasesScore { private get; set; }

        protected virtual void Start()
        {
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (CollisionEndsGame)
            {
                if (collision.gameObject.layer is 3)
                {
                    GameManager.Instance.EndGame();
                }
            }
        }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (CollisionEndsGame)
            {
                if (collision.gameObject.layer is 3)
                {
                    GameManager.Instance.EndGame();
                }
            }

            if (CollisionIncreasesScore)
            {
                if (collision.gameObject.layer is 3)
                {
                    GameManager.Instance.AddScore(1);
                }
            }
        }
    }
}