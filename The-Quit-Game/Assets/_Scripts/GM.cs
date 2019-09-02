using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

    public int lives = 7;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject gameOver;
    public GameObject youQuit;
    public static GM instance = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void CheckGameOver()
    {
        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }
    }

    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
