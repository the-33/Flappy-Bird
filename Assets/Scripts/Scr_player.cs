using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scr_player : MonoBehaviour
{
    public float fuerzasalto;
    public bool volando;
    public int puntos;
    public Text puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            volando = true;
            gameObject.GetComponent<Animator>().SetBool("Flying", true);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 2;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzasalto));
            gameObject.GetComponent<Animator>().Play("Pajaro batiendo alas");
        }

        if (volando)
        {
            puntuacion.text = puntos.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {      
            SceneManager.LoadScene("scene1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        puntos++;
        Destroy(collision.gameObject);
    }
}
