using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox1 : MonoBehaviour
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
	    	if (35 == GameControl_1.var1 + 11)
	    	{
	    		GameControl_1.finish = true;
	    	}
	 		else
	 		{
                if (GameControl_1.recently_hit == 0)
                {
                    GameControl_1.health -= 1;
                    GameControl_1.recently_hit = 500;
                }
	 			incorrectText.gameObject.SetActive(true);
	 			yield return new WaitForSeconds(3.0f);
	 			incorrectText.gameObject.SetActive(false);
	 		}
	    }
    }
}
