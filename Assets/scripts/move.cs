using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class move : MonoBehaviour
{
    public float topspeed = 10.0f;
    public Fireplayer fireplayer;
    public int vidas;
    public GameObject boom;
    public Text Text2;
   

    void Start()
    {
        //para utilizar una variable de otro script, debemos instanciar a partir del gameobject que utiliza ese script 
        fireplayer = GameObject.Find("BulletSpawnLeft").GetComponent<Fireplayer>();
        vidas = 0;
    }

    // fixed update sirve para dotar de cualidades fisicas a un objeto
    void FixedUpdate()
    {
        //obtner la dirección del movimiento
        float horizontalDirection = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalDirection * topspeed, GetComponent<Rigidbody2D>().velocity.y);

        if (horizontalDirection == 0)
        {
            GetComponent<Animator>().SetBool("left", false);
            GetComponent<Animator>().SetBool("right", false);

        }

        if (horizontalDirection < 0)
        {
            GetComponent<Animator>().SetBool("left", true);
            GetComponent<Animator>().SetBool("right", false);

        }

        if (horizontalDirection > 0)
        {
            GetComponent<Animator>().SetBool("right", true);
            GetComponent<Animator>().SetBool("left", false);

        }

    }
    void Update()
    {
        Text2.text = "choques: " + vidas+"/5";
        dead();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("gun", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("gun", false);
        }
    }

    private void dead()
    {
        if (vidas == 5)
        {
            Destroy(this.gameObject);
            Instantiate(boom, transform.position, Quaternion.identity);
           
        }
    }

    //trigger(disparador), asignamos un tag al objeto paquete, si el tag es igual a paquete se destruye este objeto
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "paquete")
        {
            Destroy(other.gameObject);
            //una vez instanciado el gameobject podemos usar sus metodos
            fireplayer.setbalas(6);
        }


    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "others" || coll.gameObject.tag == "enemy"|| coll.gameObject.tag== "camion_explosivos")
        {
            vidas++;
        }
    }
}