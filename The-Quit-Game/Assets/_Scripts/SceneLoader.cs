using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance = null;

    public void LoadSecondMenu()
    {
        SceneManager.LoadScene(1);
    }
}
