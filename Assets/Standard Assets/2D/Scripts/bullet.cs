using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 10f;
    public int timer = 0;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -(transform.right * speed);
    }
    void Update()
    {
        if (timer < 1000)
        {
            timer += 1;
        }
        else if (timer == 1000)
        {
            timer = 0;
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        Destroy(gameObject);
        if (Boss_GameControl.recently_hit == 0 && !string.Equals(col.name, "birdboss"))
        {
            Boss_GameControl.health -= 1;
            Boss_GameControl.recently_hit = 500;
        }
    }


}