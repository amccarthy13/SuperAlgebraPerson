using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox : MonoBehaviour
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
	    	if (35 == GameControl.var1 + 11)
	    	{
	    		GameControl.finish = true;
	    	}
	 		else
	 		{
                GameControl.health -= 1;
	 			incorrectText.gameObject.SetActive(true);
	 			yield return new WaitForSeconds(3.0f);
	 			incorrectText.gameObject.SetActive(false);
	 		}
	    }
    }
}
