using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void loadnewleavel()
    {
        SceneManager.LoadScene("123");
    }
    public void quitgame() 
    {
        Application.Quit();
    }
}
