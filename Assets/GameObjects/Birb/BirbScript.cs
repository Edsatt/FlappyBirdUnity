using System;
using GameObjects.Logic;
using UnityEngine;

namespace GameObjects.Birb
{
    public class BirbScript : MonoBehaviour
    {
        public Rigidbody2D rigidBody;
        public float flapStrength;
        public LogicScript logicScript;
        public bool birbIsAlive;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
            birbIsAlive = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && birbIsAlive)
            {
                rigidBody.linearVelocity = Vector2.up * flapStrength;
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            logicScript.GameOver();
            birbIsAlive = false;
        }
    }
}
