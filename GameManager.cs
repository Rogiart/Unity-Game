using TMPro;
using UnityEngine;

public class GameManager
    : MonoBehaviour
{
    public TMP_Text scoreText;

    float score;

    void Update()
    {
        score += Time.deltaTime;

        scoreText.text =
            "ê∂ë∂éûä‘ : "
            + ((int)score);
    }
}