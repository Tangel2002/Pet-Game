using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{

    public Button but;
    Color bcolor;

    public bool hungTgl = false;
    public bool hygTgl = false;
    public bool boredTgl = false;


    float hungCD = 1.2f;
    float hygCD = 1.2f;
    float boredCD = 1.2f;

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
            ColorBlock cb = but.colors;
            cb.normalColor = Color.gray;
            cb.selectedColor = Color.gray;
            but.colors = cb;

            hungCD -= 1 * Time.deltaTime;
            if(hungCD <= 0)
            {
                if(hunger <= 100)
                {
                    hunger += 5;
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
        else
        {
            ColorBlock cb = but.colors;
            cb.normalColor = Color.white;
            cb.selectedColor = Color.white;
            but.colors = cb;
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
                    boredom -= 4;
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
