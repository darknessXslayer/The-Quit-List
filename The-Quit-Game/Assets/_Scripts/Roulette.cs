using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Roulette : MonoBehaviour
{
    public string key;
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(key))
        {
            EventSystem.current.SetSelectedGameObject(this.gameObject);
        }
    }
}
