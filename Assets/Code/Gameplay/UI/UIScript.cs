using Code.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI
{
    public class UIScript : MonoBehaviour
    {
        [SerializeField]
        private GameObject gameOverScreen;
        
        [SerializeField]
        private TextMeshProUGUI scoreText;
        
        [SerializeField]
        private Button restartButton;

        private void Start()
        {
            if (GameManager.Instance is null)
            {
                Debug.LogError("Game Manager is null on start.");
            }
            else
            {
                GameManager.Instance.OnScoreChanged += UpdateScoreText;
                GameManager.Instance.OnGameOver += DisplayGameOverScreen;
                
                UpdateScoreText(GameManager.Instance.CurrentScore);
                gameOverScreen.SetActive(GameManager.Instance.IsGameOver);
                restartButton.onClick.AddListener(() => GameManager.Instance.RestartGame());
            }
        }

        private void OnDisable()
        {
            if (GameManager.Instance is null)
            {
                Debug.LogError("Game Manager is null when UI script is disabled.");
            }
            else
            {
                GameManager.Instance.OnScoreChanged -= UpdateScoreText;
                GameManager.Instance.OnGameOver -= DisplayGameOverScreen;
            }
        }

        private void DisplayGameOverScreen()
        {
            gameOverScreen.SetActive(true);
        }

        private void UpdateScoreText(int score)
        {
            scoreText.text = score.ToString();
        }
    }
}