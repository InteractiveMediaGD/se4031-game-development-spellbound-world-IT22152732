using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddScore()
    {
        score++;
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Crystals Collected: " + score;
    }
}