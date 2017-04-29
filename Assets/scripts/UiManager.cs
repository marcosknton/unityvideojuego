using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public Button[] Buttons;
    public Text tiempo;
    public static int  itiempo=0;
    public static int  minutos=0;
    
   
 
	// Use this for initialization
	void Start () {
        
        InvokeRepeating("tiempoupdate", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update() {
        if (GameObject.Find("run") == null)
        {
            gameOverActivated();
        }
        else { 

            if (itiempo == 60)
            {
                itiempo = 0;
                minutos += 1;
             }
        tiempo.text = "tiempo: " + minutos + " ' " + itiempo + " '' ";
        
        
        }
         
    }
    public void Play()
    {
        //sustituyes una escana por otra
       SceneManager.LoadScene("coche", LoadSceneMode.Single);
        minutos = 0;
        itiempo = 0;
    }

	
	public void Exit(){
       
        Application.Quit();
    }

    public void gameOverActivated ()
    {
       
        foreach (Button button in Buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    void tiempoupdate()
    {
        itiempo += 1;
        changeScene();
      
    } 

    public int getmin()
    {
        return minutos;
    }

    public int getseg()
    {
        return itiempo;
    }

    public void changeScene()
    {
        if (minutos == 0 && itiempo == 30)
        {
            SceneManager.LoadScene("coche2", LoadSceneMode.Single);
            
        }
        if (minutos == 1 && itiempo==1)
        {
            SceneManager.LoadScene("coche3", LoadSceneMode.Single);
        }

    }


}
