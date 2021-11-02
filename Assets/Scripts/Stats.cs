using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{


    public bool hungTgl = false;
    public bool hygTgl = false;
    public bool boredTgl = false;


    float hungCD = 1.5f;
    float hygCD = 1.5f;
    float boredCD = 1.5f;

    float countdown = 3f;
    
    public int hunger = 100;
    public int hygiene = 100;
    public int boredom = 0;
    
    
    public GameObject HuText; //Hunger Text
    public GameObject HyText; //Hygiene Text
    public GameObject BoText; //Boredom Text



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
        //Lose Condition Section
        if (hunger < 0)
        {
                SceneManager.LoadScene("Endscreen");
        }
        if (hygiene < 0)
        {
            SceneManager.LoadScene("Endscreen");
        }
        if (boredom > 100)
        {
            SceneManager.LoadScene("Endscreen");
        }


        if (hungTgl)
        {
            hungCD -= 1 * Time.deltaTime;
            if(hungCD <= 0)
            {
                if(hunger <= 100)
                {
                    hunger += 2;
                    HuText.GetComponent<TextMeshProUGUI>().text = hunger.ToString() + " / 100";
                    hungCD = 1.5f;
                }
                if(hunger > 100)
                {
                    hunger = 100;
                    HuText.GetComponent<TextMeshProUGUI>().text = hunger.ToString() + " / 100";
                }
                
            }
            
        }
        if (hygTgl)
        {
            hygCD -= 1 * Time.deltaTime;
            if (hygCD <= 0)
            {
                if (hygiene <= 100)
                {
                    hygiene += 2;
                    HyText.GetComponent<TextMeshProUGUI>().text = hygiene.ToString() + " / 100";
                    hygCD = 1.5f;
                }
                if (hygiene > 100)
                {
                    hygiene = 100;
                    HyText.GetComponent<TextMeshProUGUI>().text = hygiene.ToString() + " / 100";
                }
                if (hygiene <= 0)
                {
                    SceneManager.LoadScene("Endscreen");
                }
            }

        }
        if (boredTgl)
        {
            boredCD -= 1 * Time.deltaTime;
            if (boredCD <= 0)
            {
                if (boredom >= 0)
                {
                    boredom -= 2;
                    BoText.GetComponent<TextMeshProUGUI>().text = boredom.ToString() + " / 100";
                    boredCD = 1.5f;
                    
                }
                if (boredom < 0)
                {
                    boredom = 0;
                    BoText.GetComponent<TextMeshProUGUI>().text = boredom.ToString() + " / 100";

                }
                if (boredom >= 100)
                {
                    SceneManager.LoadScene("Endscreen");
                }
            }

        }

    }


    public void hungerToggle()
    {
        if (hungTgl)
        {
            hungTgl = false;
        }
        else
        {
            hungTgl = true;
        }
        
    }

    public void hygieneToggle()
    {
        if (hygTgl)
        {
            hygTgl = false;
        }
        else
        {
            hygTgl = true;
        }

    }

    public void bordeomToggle()
    {
        if (boredTgl)
        {
            boredTgl = false;
        }
        else
        {
            boredTgl = true;
        }

    }
}
