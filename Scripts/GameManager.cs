using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public GameObject gameOverText;
    public GameObject clearText;
    public GameObject restartButton;

    public float score = 0;

    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded) return;

        score += Time.deltaTime;

        scoreText.text =
            "Time : " + ((int)score);

        // 60•b‚ÅƒNƒŠƒA
        if (score >= 60f)
        {
            ClearGame();
        }
    }

    public void GameOver()
    {
        if (gameEnded) return;

        gameEnded = true;

        gameOverText.SetActive(true);
        restartButton.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ClearGame()
    {
        if (gameEnded) return;

        gameEnded = true;

        clearText.SetActive(true);
        restartButton.SetActive(true);

        Time.timeScale = 0f;
    }
}