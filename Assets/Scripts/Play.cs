using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    bool playing = false;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void useBall()
    {
        playCube();
    }

    public void playCube()
    {
        if (!playing)
        {
            Ball.gameObject.SetActive(true);
        }
        else
        {
            Ball.gameObject.SetActive(false);
        }
        playing = !playing;
    }
}
