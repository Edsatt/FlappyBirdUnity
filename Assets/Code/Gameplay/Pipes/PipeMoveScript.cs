using UnityEngine;

namespace Code.Gameplay.Pipes
{
    public class PipeMoveScript : MonoBehaviour
    {
        public float moveSpeed = 5;
        public float deadZone = -44;
        
        void Update()
        {
            transform.position += Vector3.left * (moveSpeed * Time.deltaTime);

            if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        }
    }
}
