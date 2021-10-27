using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

     
    // Start is called before the first frame update
    bool paused = false;
    public Canvas pauseCanv;
    public Canvas mainCanv;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
          pauseMenu();
        }
    }


    public void pauseMenu()
    {
        if (paused)
        {
            Time.timeScale = 0;
            pauseCanv.gameObject.SetActive(true);
            mainCanv.gameObject.SetActive(false);
            
        }
        else
        {
            pauseCanv.gameObject.SetActive(false);
            pauseCanv.gameObject.SetActive(true);
            Time.timeScale = 1;
        }

        paused = !paused;
    }


    public void quit()
    {
        Application.Quit();
    }
}
