using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public KeyCode _key;

    private Button _button;

    void Awake()
    {
        _button = GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            FadeToColor(_button.colors.pressedColor);
            _button.onClick.Invoke();
        }
        else if (Input.GetKeyUp(_key))
        {
            FadeToColor(_button.colors.normalColor);
        }
    }

    void FadeToColor(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, _button.colors.fadeDuration, true, true);
    }


    public void PlayGame()
    {
        //SceneManager.LoadScene("Level1Test");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit.");
        Application.Quit();
    }
}
