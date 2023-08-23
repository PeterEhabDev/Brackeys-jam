using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderTile_behaviour : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (transform.position.y >= 14)
        {
            transform.position = new Vector2(transform.position.x, -14f);
        }

    }
}
