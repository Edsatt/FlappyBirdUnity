using GameObjects.Logic;
using UnityEngine;

namespace GameObjects.Pipes
{
    public class PipeMiddleScipt : MonoBehaviour
    {
        public LogicScript logicScript;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer is 3)
            {
                logicScript.AddScore(1);
            }
        }
    }
}
