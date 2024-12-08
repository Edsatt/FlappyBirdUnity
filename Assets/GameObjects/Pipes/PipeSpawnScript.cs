using UnityEngine;

namespace GameObjects.Pipes
{
    public class PipeSpawnScript : MonoBehaviour
    {
        private float _timer = 0;
        public GameObject pipe;
        public float spawnRate;
        public float heightOffset = 10;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SpawnPipe();
        }

        // Update is called once per frame
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
