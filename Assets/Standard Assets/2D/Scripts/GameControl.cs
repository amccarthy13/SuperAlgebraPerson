﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameControl : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, incorrectText, character;
    public static int health, recently_hit;
    public static bool finish;
    public static int var1, var2, var3;
    public GameObject var1Obj, var2Obj, var3Obj;


    void Start()
    {


        health = 3;
        recently_hit = 0;
        
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);

        incorrectText.gameObject.SetActive(false);

        var1Obj.GetComponent<UnityEngine.UI.Text>().text = "X";
        var2Obj.GetComponent<UnityEngine.UI.Text>().text = "Y";
        var3Obj.GetComponent<UnityEngine.UI.Text>().text = "Z";

        var1 = 0;
        var2 = 0;
        var3 = 0;

        finish = false;
    }
    void Update()
    {
        if (finish) 
        {
            finish = false;

            var1 = 0;
            var2 = 0;
            var3 = 0;

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
                LevelSelector.LoadDeathLevel();
                break;
        } 
    }
}