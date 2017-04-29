using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fireplayer: MonoBehaviour {

    //bullet Prefab
    public GameObject bullet;
    public int bullets;
    public int totalbullet;
    public Text text;
    

	// Use this for initialization
	void Start () {
        bullets = 6;
        contadorbalas();

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && !(Input.GetKey(KeyCode.RightArrow)) && !(Input.GetKey(KeyCode.LeftArrow))&&bullets> 0)
        {
           
            //genra la bullet(bala)
            GameObject g = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
            //ignorar colision entre bullet y jugador
            Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(), transform.parent.GetComponent<Collider2D>());
            bullets--;
            contadorbalas();

        }
       
	}

    public void contadorbalas()
    {
        text.text = "munición: " + bullets;
    }

    //Para que te devuelva el valor de tu variable
    public int  getbalas()
    {
        return bullets;
    }
    //funcion para sumar balas desde otro script
    public void setbalas(int balas)   
    {
        bullets =bullets+balas;
    }

}
