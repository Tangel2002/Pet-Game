using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clean : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shower;
    bool showerStatus = false;
    // Update is called once per frame

    public void showerToggle()
    {
        if (!showerStatus)
        {
            shower.SetActive(true);
            
        }
        else
        {
            shower.SetActive(false);
        }

        showerStatus = !showerStatus;
    }
}
