using UnityEngine;

namespace Code.Gameplay.Pipes
{
    public class PipeSpawnScript : MonoBehaviour
    {
        private float _timer;
        public GameObject pipe;
        public float spawnRate;
        public float heightOffset = 10;
        
        void Start()
        {
            SpawnPipe();
        }
        
        void Update()
        {
            if (_timer < spawnRate)
            {
                _timer += Time.deltaTime;
            }
            else
            {
                SpawnPipe();
                _timer = 0;
            }
        }

        private void SpawnPipe()
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            Instantiate(
                pipe,
                new Vector3(
                    x: transform.position.x,
                    y: Random.Range(lowestPoint, highestPoint),
                    z: 1),
                transform.rotation);
        }
    }
}
