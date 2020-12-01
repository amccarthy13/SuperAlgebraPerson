using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberChest2 : MonoBehaviour
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
	    	    GameControl_2.var1 = value;
            }
            else if (var == 2)
            {
                GameControl_2.var2 = value;
            }
            else 
            {
                GameControl_2.var3 = value;
            }
	    }
    }
}
