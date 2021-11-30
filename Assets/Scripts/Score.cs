using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score instance;

    public Text highscoreText;
    public Text scoreText;

    int score = 0;
    int highscore = 0;

    // Update is called once per frame

    private void Awake()
    {
        instance = this; 
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " Points";
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 100;
        scoreText.text = score.ToString() + " Points";
        if(highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

}
