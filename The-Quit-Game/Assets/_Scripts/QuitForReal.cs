using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitForReal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void fixedUpdate()
    {
        {
            Application.Quit();
            Debug.Log("Quit Attempted");
        }
    }
}
