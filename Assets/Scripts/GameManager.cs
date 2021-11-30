using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 3f;

   // public Text gameOverText;
   // public Text highScoreText;

   // public Button restartButton;
   // public Button quitButton;

    private void Awake()
    {
        gameHasEnded = false;
       // highScoreText.enabled = false;
       // gameOverText.enabled = false;
       // restartButton.enabled = false;
       // quitButton.enabled = false;
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
           // gameOverText.enabled = true;
           // highScoreText.enabled = true;
           // restartButton.enabled = true;
           // quitButton.enabled = true;
           /// restartButton.onClick.Invoke(Restart, restartDelay);
            Invoke("Restart", restartDelay);
        }
    }
       


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
