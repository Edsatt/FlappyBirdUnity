using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        
        public bool IsGameOver { get; private set; }
        public int CurrentScore { get; private set; }
        
        public event Action OnGameOver;
        public event Action<int> OnScoreChanged;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject); // Destroy duplicate GameManager
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
        private void OnDestroy()
        {
            OnGameOver = null;
            OnScoreChanged = null;
        }
        
        public void RestartGame()
        {
            IsGameOver = false;
            CurrentScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void EndGame()
        {
            IsGameOver = true;
            OnGameOver?.Invoke();
        }
        
        [ContextMenu("Increase score")]
        public void AddScore(int scoreToAdd)
        {
            if (!IsGameOver)
            {
                CurrentScore += scoreToAdd;
                OnScoreChanged?.Invoke(CurrentScore);
            }
        }
    }
}