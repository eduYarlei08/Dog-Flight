using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private int teste;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject player;

    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (player == null)
        {
            ShowGameOver();
        }
    }

    private void ShowGameOver()
    {
        if (gameOverPanel != null && !gameOverPanel.activeSelf)
            gameOverPanel.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
