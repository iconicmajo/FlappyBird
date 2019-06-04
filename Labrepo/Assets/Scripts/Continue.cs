using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas panel;
    public static bool pause;

    void Start()
    {

    }

    // Update is called once per frame
    public void ContinueGame()
    {

        if (panel.gameObject.tag == "Pause")
        {
            Time.timeScale = 1f;
            panel.gameObject.SetActive(false);
            pause = false;
        }

    }
}
