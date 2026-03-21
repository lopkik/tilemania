 using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    // ─── Singleton ───────────────────────────────────────────────────────
    public static GameSession Instance { get; private set; }

    // ─── State ───────────────────────────────────────────────────────────
    [SerializeField] int lives = 1;
    int score = 0;

    void Awake()
    {
        // Singleton pattern — one GameSession persists across scenes
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // ─── Score ───────────────────────────────────────────────────────────
    public void AddScore(int points)
    {
        score += points;
        // TODO: Update score UI
    }

    public int GetScore() => score;

    // ─── Lives ───────────────────────────────────────────────────────────
    public void ProcessPlayerDeath()
    {
        lives--;
        if (lives > 0)
            ReloadCurrentScene();
        else
            LoadGameOver();
    }

    // ─── Scene Loading ───────────────────────────────────────────────────
    void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void LoadGameOver()
    {
        int GameOverIndex = 4;  // Update if Game Over scene index changes
        SceneManager.LoadScene(GameOverIndex);
        Destroy(gameObject);  // Reset session
    }

    public void LoadNextLevel()
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        int lastLevelIndex = 3;  // Update if more levels are added
        int WinIndex = 5;
        if (nextIndex <= lastLevelIndex)
            SceneManager.LoadScene(nextIndex);
        else
            SceneManager.LoadScene(WinIndex);
    }
}