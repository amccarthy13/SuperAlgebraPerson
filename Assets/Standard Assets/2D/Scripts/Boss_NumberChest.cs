using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_NumberChest : MonoBehaviour
{
	public int value = 0;
    public int var = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
    	if (col.gameObject.tag == "Player")
    	{
            if (var == 1)
            {
	    	 	Boss_GameControl.var1 = value;
            }
            else if (var == 2)
            {
                Boss_GameControl.var2 = value;
            }
            else 
            {
                Boss_GameControl.var3 = value;
            }
	    }
    }
}
