using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireenemy : MonoBehaviour {

    // the bullet prefab
    public GameObject bullet;

    //tiempo que tarda en invocar el metodo
    public float interval =0.1f;
    //tiempo que tarda en repetir la invocación
    public float repeat=0.6f;
    

	void Start () {
        //invoca al métod fire
        InvokeRepeating("Fire", interval, repeat);
	}
	
	void Fire () {

        //genra la bullet(bala)
        GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
        //ignorar colision entre bullet y jugador
        Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), transform.parent.GetComponent<Collider2D>());
    }
}
