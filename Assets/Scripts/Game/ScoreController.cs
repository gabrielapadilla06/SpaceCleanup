using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreLabel;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    public void AddPoints(int points)
    {
        score += points;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreLabel.text = $"Puntuación: {score}";
    }
}
