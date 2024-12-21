using Code.Managers;
using UnityEngine;

namespace Code.Gameplay.Birb
{
    public class BirbScript : CollisionObject
    {
        public Rigidbody2D rigidBody;
        public float flapStrength;
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && !GameManager.Instance.IsGameOver)
            {
                rigidBody.linearVelocity = Vector2.up * flapStrength;
            }
        }
    }
}
