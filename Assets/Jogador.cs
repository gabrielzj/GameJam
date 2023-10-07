using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 5;
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0)
            rbd.velocity = new Vector2(x * vel, 0);
        else if (y != 0)
            rbd.velocity = new Vector2(0, y * vel);
    }
}
