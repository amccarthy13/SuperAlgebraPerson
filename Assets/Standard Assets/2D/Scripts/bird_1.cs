using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_1 : MonoBehaviour
{
    public float speed;
    public bool MoveSide = true;
    public bool MoveVert = true;
    public int MoveRight = 0;
    public int MoveLeft = 0;
    public int MoveUp = 0;
    public int MoveDown = 0;

    void Update()
    {
        if (MoveSide)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            if (MoveRight < 500)
            {
                MoveRight += 1;
            }
            else if (MoveRight >= 500)
            {
                MoveSide = false;
                MoveRight = 0;
            }
        }
        else if (!MoveSide)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            if (MoveLeft < 500)
            {
                MoveLeft += 1;
            }
            else if (MoveLeft >= 500)
            {
                MoveSide = true;
                MoveLeft = 0;
            }
        }
        if (MoveVert)
        {
            transform.Translate(0, Time.deltaTime * speed, 0);
            if (MoveUp < 100)
            {
                MoveUp += 1;
            }
            else if (MoveUp >= 100)
            {
                MoveVert = false;
                MoveUp = 0;
            }
        }
        else if (!MoveVert)
        {
            transform.Translate(0, -Time.deltaTime * speed, 0);
            if (MoveDown < 100)
            {
                MoveDown += 1;
            }
            else if (MoveDown >= 100)
            {
                MoveVert = true;
                MoveDown = 0;
            }
        }

    }
    void OnTriggerEnter2D (Collider2D col)
    {
        if (GameControl_1.recently_hit <= 0)
        {
            GameControl_1.health -= 1;
            GameControl_1.recently_hit = 500;
        }
    }
}