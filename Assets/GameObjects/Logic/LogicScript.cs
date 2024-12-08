using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameObjects.Logic
{
    public class LogicScript : MonoBehaviour
    {
        public int score = 0;
        public Text scoreText;
        public GameObject gameOverScreen;
    
        [ContextMenu("Increase score")]
        public void AddScore(int scoreToAdd)
        {
            score += scoreToAdd;
            scoreText.text = score.ToString();
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void GameOver()
        {
            gameOverScreen.SetActive(true);
        }
    }
}