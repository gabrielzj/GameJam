using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 5;
    private bool temFonte = false;
    public GameObject Square;
    public GameObject vit;
    public GameObject s1, s2, s3;
    //private Vector2 teleporte;
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        //wall = true;
        if (collision.gameObject.CompareTag("braia")) {
            collision.gameObject.SetActive(false);
            vel = 10;
            Debug.Log("powered up");
            yield return new WaitForSeconds(5);
            vel = 5;
            Debug.Log("End of power up");
        }
        if (collision.gameObject.tag == "font")
        {
            temFonte = true;
            collision.gameObject.SetActive(false);
            Debug.Log("TemFonte: " + temFonte);
        }
        if (collision.gameObject.tag == "nobraia")
        {
            collision.gameObject.SetActive(false);
            vel = 3;
            Debug.Log("lento");
            yield return new WaitForSeconds(5);
            vel = 5;
            Debug.Log("normal");
        }
        if (collision.gameObject.tag == "map")
        {
            collision.gameObject.SetActive(false);
            Square.SetActive(false);
            yield return new WaitForSeconds(5);
            Square.SetActive(true);
        }
        if(collision.gameObject.tag == "vic")
        {
            vitoria();
        }
        if (collision.gameObject.tag == "teleport")
        {
            collision.gameObject.SetActive(false);
            teleportar();

        }
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0)
            rbd.velocity = new Vector2(x * vel, 0);
        else if (y != 0)
            rbd.velocity = new Vector2(0, y * vel);

    }

    void teleportar()
    {
        GameObject[] spawns = { s1, s2, s3 };
        int index = Random.Range(0,3);
        GameObject ponto = spawns[index];
        gameObject.transform.position = ponto.transform.position;
    }

    private void vitoria()
    {
        Vector2 saida = new Vector2(11,-15);
        //Vector2.Equals(saida, transform.position);
        if (temFonte)
        {
            SceneManager.LoadScene(2);
        }else if (!temFonte)
        {
            transform.position = vit.transform.position;
        }
    }

}
