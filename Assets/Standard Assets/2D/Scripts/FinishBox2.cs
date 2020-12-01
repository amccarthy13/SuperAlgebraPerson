using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox2 : MonoBehaviour
{
	public GameObject incorrectText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnCollisionEnter2D(Collision2D col)
    {
    	if (col.gameObject.tag == "Player")
    	{
	    	if (11 == (0.5 * GameControl_2.var1) / 2 + GameControl_2.var2 - GameControl_2.var3)
	    	{
	    		GameControl_2.finish = true;
	    	}
	 		else
	 		{
                if (GameControl_2.recently_hit <= 0)
                {
                    GameControl_2.health -= 1;
                    GameControl_2.recently_hit = 500;
                }
                
	 			incorrectText.gameObject.SetActive(true);
	 			yield return new WaitForSeconds(3.0f);
	 			incorrectText.gameObject.SetActive(false);
	 		}
	    }
    }
}