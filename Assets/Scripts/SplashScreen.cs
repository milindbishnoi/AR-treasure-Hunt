using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {
    public float delay;
    
	// Use this for initialization
	void Start () {
        
        
        Invoke("Changecene", 5);
	}
	
	public void Changecene()
    {
        SceneManager.LoadScene(1);
    }
}
