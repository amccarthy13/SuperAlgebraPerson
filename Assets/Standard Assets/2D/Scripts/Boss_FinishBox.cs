using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_FinishBox : MonoBehaviour
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
	    	if (19 == (Boss_GameControl.var1 * 7 - Boss_GameControl.var2))
	    	{
	    		Boss_GameControl.finish = true;
	    	}
	 		else
	 		{
                if (Boss_GameControl.recently_hit <= 0)
                {
                    Boss_GameControl.health -= 1;
                    Boss_GameControl.recently_hit = 500;
                }
                
	 			incorrectText.gameObject.SetActive(true);
	 			yield return new WaitForSeconds(3.0f);
	 			incorrectText.gameObject.SetActive(false);
	 		}
	    }
    }
}
