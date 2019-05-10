using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class AuthController : MonoBehaviour {

    public InputField EmailInput;
    public InputField passwordInput;
    public GameObject ArCamera;
    public GameObject Login;

    public void Start()
    {
        ArCamera.SetActive(false);
        
    }

    public void LoginUser()
    {
        string userid = EmailInput.text;
        Debug.Log(EmailInput.text);

        FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(EmailInput.text, passwordInput.text).ContinueWith(task =>
        {
            if(task.IsCanceled)
            {
                return;
            }
            if(task.IsFaulted)
            {
                SSTools.ShowMessage("Sign-In Failed Please try again ", SSTools.Position.bottom, SSTools.Time.twoSecond);
                Firebase.FirebaseException e = task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;
                GetErrorMessage((AuthError)e.ErrorCode);
                return;
            }
            if(task.IsCompleted)
            {
                PlayerPrefs.SetString("User",EmailInput.text);
                
                print("login Succesfull");
                ArCamera.SetActive(true);
                Login.SetActive(false);
            }
           
        });
        Debug.Log(EmailInput.text + " " + passwordInput.text);

    }
    public void LogOut()
    {
        if(FirebaseAuth.DefaultInstance.CurrentUser != null)
        {
            FirebaseAuth.DefaultInstance.SignOut();
        }
    }
    public void RegisterUser()
    {
        if(EmailInput.text.Equals("") && passwordInput.text.Equals(""))
        {
            SSTools.ShowMessage("Please enter Email and password ", SSTools.Position.bottom, SSTools.Time.twoSecond); 
            return;
        }
        FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(EmailInput.text,
            passwordInput.text).ContinueWith((task =>
            {   
                if(task.IsCanceled)
                {
                    return;
                }
                if(task.IsFaulted)
                {
                    SSTools.ShowMessage("Registration failed check your internet connection ", SSTools.Position.bottom, SSTools.Time.twoSecond);
                    Firebase.FirebaseException e = task.Exception.Flatten().InnerExceptions[0] as Firebase.FirebaseException;
                    GetErrorMessage((AuthError)e.ErrorCode);
                    return;

                }
                if(task.IsCompleted)
                {
                    SSTools.ShowMessage("Registration succesful ", SSTools.Position.bottom, SSTools.Time.twoSecond);
                    print("Registration succesful");
                }

            }));
    }
    void GetErrorMessage(AuthError authError)
    {
        string msg = "";
        msg = authError.ToString();
        print(msg);
    }
}
