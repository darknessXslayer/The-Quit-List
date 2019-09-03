using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonRoulette2 : MonoBehaviour
{

    public List<Button> screen01;
    public List<Button> screen02;
    public List<Button> screen03;
    public int currentButton;
    public int cutoff;
    private int time;

    // Start is called before the first frame update
    void Start()
    {
        screen02[currentButton].Select();
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if(time >= cutoff)
        {
            currentButton++;
            time = 0;
            screen02[currentButton].Select();
        }


    }
}
