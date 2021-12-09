using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;

    //public Text highscoreText;
    //public Text scoreText;
    private TextMeshProUGUI TextMeshProObject;

    int score = 0;
    //int highscore = 0;

    // Update is called once per frame

    private void Awake()
    {
        TextMeshProObject = GetComponent<TextMeshProUGUI>();
        instance = this; 
    }

    void Start()
    {
        //highscore = PlayerPrefs.GetInt("highscore", 0);
        TextMeshProObject.text = "Score: " + score.ToString();
        //highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 100;
        TextMeshProObject.text = "Score: " + score.ToString();
        //if(highscore < score)
        //PlayerPrefs.SetInt("highscore", score);
    }


}
