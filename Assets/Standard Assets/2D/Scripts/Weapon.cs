using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public int interval = 0;
    public GameObject bulletPrefab;
    // Update is called once per frame
    void Update()
    {
        if (interval < 500)
        {
            interval += 1;
        }
        else if (interval == 500)
        {
            //fire
            Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
            interval = 0;
        }
    }
}
