using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicao = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        this.transform.position = posicao; //iguala a posição com o player
    }
}
