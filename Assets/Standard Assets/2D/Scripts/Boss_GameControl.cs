using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Boss_GameControl : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, incorrectText;
    public static int health, recently_hit;
    public static bool finish;
    public static int var1, var2;
    public GameObject var1Obj, var2Obj;

    void Start()
    {
        recently_hit = 0;
        health = 3;
        
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);

        incorrectText.gameObject.SetActive(false);

        var1Obj.GetComponent<UnityEngine.UI.Text>().text = "X";
        var2Obj.GetComponent<UnityEngine.UI.Text>().text = "Y";

        var1 = 0;
        var2 = 0;

        finish = false;
    }
    void Update()
    {
        if (finish) 
        {
            finish = false;

            var1 = 0;
            var2 = 0;

            LevelSelector.LoadVictoryLevel();

        }
        if (var1 == 0)
        {
            var1Obj.GetComponent<UnityEngine.UI.Text>().text = "X";
        }
        else 
        {
            var1Obj.GetComponent<UnityEngine.UI.Text>().text = var1.ToString();
        }

        if (var2 == 0) 
        {
            var2Obj.GetComponent<UnityEngine.UI.Text>().text = "Y";
        }
        else 
        {
            var2Obj.GetComponent<UnityEngine.UI.Text>().text = var2.ToString();
        }

        if (recently_hit > 0)
        {
            recently_hit -= 1;
        }
        
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                
                var1 = 0;
                var2 = 0;

                LevelSelector.LoadDeathLevel();
                break;

        }
    }
}