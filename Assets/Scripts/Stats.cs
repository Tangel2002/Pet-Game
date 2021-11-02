using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{

    bool tgl = false;

    float countdown = 3f;
    float statCD = 1.5f;
    
    public int hunger = 100;
    public int hygiene = 100;
    public int boredom = 0;
    
    
    public GameObject HuText; //Hunger Text
    public GameObject HyText; //Hygiene Text
    public GameObject BoText; //Boredom Text

    public GameObject ball;
    public GameObject foodBowl;
    public GameObject showerHead;

    // Update is called once per frame
    void Update()
    {
        countdown -= 1 * Time.deltaTime;
        if (countdown <= 0){
            hunger -= 3;
            hygiene -= 1;
            boredom += 2;

            countdown = 3;
            
            HuText.GetComponent<TextMeshProUGUI>().text= hunger.ToString() + " / 100";
            HyText.GetComponent<TextMeshProUGUI>().text = hygiene.ToString() + " / 100";
            BoText.GetComponent<TextMeshProUGUI>().text = boredom.ToString() + " / 100";

            
        }
        if (tgl)
        {
            statCD -= 1 * Time.deltaTime;

        }

        
    }

    public void toggle(string stat)
    {
        if (tgl)
        {
            tgl = false;
        }
        else
        {
            tgl = true;
            addStats(stat);
        }
    }


    public void addStats(string stat)
    {
        if(statCD <= 0)
        {
            if(stat == "Hunger")
            {
                hunger += 3;
                HuText.GetComponent<TextMeshProUGUI>().text = hunger.ToString() + " / 100";
            }
            statCD = 1.5f;
        }
    }
}
