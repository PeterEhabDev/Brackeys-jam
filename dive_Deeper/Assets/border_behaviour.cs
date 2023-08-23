using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border_behaviour : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] Transform leftBorder;
    [SerializeField] Transform rightBorder;
    List<SpriteRenderer> BorderChildren = new List<SpriteRenderer>();
    byte colorX = 255;
    byte colorY = 255;
    byte colorZ = 255;
    bool switchX = true;
    bool switchY = true;
    bool switchZ = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (SpriteRenderer child in GetComponentsInChildren<SpriteRenderer>())
        {
            child.color = (Color)(new Color32(colorX, colorY, colorZ, 255));
        }
    }
    private void FixedUpdate()
    {
        int ran = Random.Range(1, 4);
        if (ran == 1)
        {
            changeColor(ref colorX,ref switchX);
        }
            if (ran == 2)
        {
            changeColor(ref colorY, ref switchY);
        }
        if (ran == 3)
        {
            changeColor(ref colorZ, ref switchZ);
        }
    }
    void changeColor(ref byte colorCor,ref bool switcher)
    {  
            if (switcher)
            {
                colorCor -= 1;
                if (colorCor <= 0)
                {
                    switcher = false;
                }
            }
            else
            {
                colorCor += 1;
                if (colorCor >= 255)
                {
                    switcher = true;
                }

            }
        }
}
