using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{

    float countdown = 2;
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
    }

    public void addStats(string stat)
    {
        float timer = 1.5f;
        if (stat == "Hunger")
        {
            while (foodBowl.activeInHierarchy)
            {
                timer -= 1 * Time.deltaTime;
               if(timer <= 0)
                {
                    hunger += 5;
                    HuText.GetComponent<TextMeshProUGUI>().text = hunger.ToString() + " / 100";
                }
                timer = 1.5f;
            }
        }
    }
}
