using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using UnityEngine.UI;
using Firebase.Unity.Editor;
public class DataBridge : MonoBehaviour {
    public InputField emailinput;
    public InputField passwordinput;
    private string data;
    private string url = "https://ar-treasure-hunt-c5748.firebaseio.com/";
    private DatabaseReference databaseReference;

	// Use this for initialization
	void Start () {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl(url);
        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;

        
            }
    public void SaveData()
    {
        
    }
    public void LoadData()
    {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
