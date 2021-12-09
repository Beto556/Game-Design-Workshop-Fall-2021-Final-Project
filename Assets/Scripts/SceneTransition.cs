using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public GameObject guiObject;
    public string levelToLoad;

    void Start()
    {
        guiObject.SetActive(false);
    }

    void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Scene transition successful");
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }

    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
