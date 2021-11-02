using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public GameObject foodBowl;
    bool bowlStatus = false;
    // Update is called once per frame

    public void bowlToggle()
    {
        if (!bowlStatus)
        {
            foodBowl.SetActive(true);

        }
        else
        {
            foodBowl.SetActive(false);
        }

        bowlStatus = !bowlStatus;
    }
}
