/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    public GameObject imag1;
    


    public GameObject PAtH_A_1;
    public GameObject PAtH_A_2;
    public GameObject PAtH_A_3;
    public GameObject PAtH_A_4;
    public GameObject PAtH_A_5;
    public GameObject PAtH_A_6;


    public GameObject PAtH_B_1;
    public GameObject PAtH_B_2;
    public GameObject PAtH_B_3;
    public GameObject PAtH_B_4;
    public GameObject PAtH_B_5;
    public GameObject PAtH_B_6;

    public GameObject PAtH_C_1;
    public GameObject PAtH_C_2;
    public GameObject PAtH_C_3;
    public GameObject PAtH_C_4;
    public GameObject PAtH_C_5;
    public GameObject PAtH_C_6;

    public GameObject final;

   
    public string userid;
    private string data;
    private string url = "https://ar-treasure-hunt-c5748.firebaseio.com/";

    DatabaseReference reference ;
    #region PROTECTED_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl(url);
        reference = FirebaseDatabase.DefaultInstance.RootReference;

        if (PlayerPrefs.HasKey("User"))
        {
           string tempuserid= PlayerPrefs.GetString("User");

            for(int i=0;i<tempuserid.Length;i++)
            {   if (tempuserid[i] != '_' && tempuserid[i] != '@' && tempuserid[i] != '.')
                { userid = userid + tempuserid[i]; }
                else
                {
                    break;
                }
            }
        }
        else
        {
            userid = "Anonymous";
        }

        //IMAGE 1  
        if (PlayerPrefs.HasKey("imag1"))
        {
            if (PlayerPrefs.GetInt("imag1") == 1)
            {
                imag1.SetActive(true);
            }
            else
            {
                imag1.SetActive(true);
            }
        }
        else
        {
            PlayerPrefs.SetInt("imag1", 0);
            imag1.SetActive(false);
        }

        //PATH_A_1
        if (PlayerPrefs.HasKey("PAtH_A_1"))
        {
            if (PlayerPrefs.GetInt("PAtH_A_1") == 1)
            {
                PAtH_A_1.SetActive(true);
            }
            else
            {
                PAtH_A_1.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_A_1", 0);
            PAtH_A_1.SetActive(false);
        }

        //PATH_A_2
        if (PlayerPrefs.HasKey("PAtH_A_2"))
        {
            if (PlayerPrefs.GetInt("PAtH_A_2") == 1)
            {
                PAtH_A_2.SetActive(true);
            }
            else
            {
                PAtH_A_2.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_A_2", 0);
            PAtH_A_2.SetActive(false);
        }

        //PATH_A_3
        if (PlayerPrefs.HasKey("PAtH_A_3"))
        {
            if (PlayerPrefs.GetInt("PAtH_A_3") == 1)
            {
                PAtH_A_3.SetActive(true);
            }
            else
            {
                PAtH_A_3.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_A_3", 0);
            PAtH_A_3.SetActive(false);
        }

        //PATH_A_4
        if (PlayerPrefs.HasKey("PAtH_A_4"))
        {
            if (PlayerPrefs.GetInt("PAtH_A_4") == 1)
            {
                PAtH_A_4.SetActive(true);
            }
            else
            {
                PAtH_A_4.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_A_4", 0);
            PAtH_A_4.SetActive(false);
        }

        //PATH_A_5
        if (PlayerPrefs.HasKey("PAtH_A_5"))
        {
            if (PlayerPrefs.GetInt("PAtH_A_5") == 1)
            {
                PAtH_A_5.SetActive(true);
            }
            else
            {
                PAtH_A_5.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_A_5", 0);
            PAtH_A_5.SetActive(false);
        }

        //PATH_A_6
        if (PlayerPrefs.HasKey("PAtH_A_6"))
        {
            if (PlayerPrefs.GetInt("PAtH_A_6") == 1)
            {
                PAtH_A_6.SetActive(true);
            }
            else
            {
                PAtH_A_6.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_A_6", 0);
            PAtH_A_6.SetActive(false);
        }
        //PATH_B_1
        if (PlayerPrefs.HasKey("PAtH_B_1"))
        {
            if (PlayerPrefs.GetInt("PAtH_B_1") == 1)
            {
                PAtH_B_1.SetActive(true);
            }
            else
            {
                PAtH_B_1.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_B_1", 0);
            PAtH_B_1.SetActive(false);
        }

        //PATH_B_2
        if (PlayerPrefs.HasKey("PAtH_B_2"))
        {
            if (PlayerPrefs.GetInt("PAtH_B_2") == 1)
            {
                PAtH_B_2.SetActive(true);
            }
            else
            {
                PAtH_B_2.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_B_2", 0);
            PAtH_B_2.SetActive(false);
        }

        //PATH_B_3
        if (PlayerPrefs.HasKey("PAtH_B_3"))
        {
            if (PlayerPrefs.GetInt("PAtH_B_3") == 1)
            {
                PAtH_B_3.SetActive(true);
            }
            else
            {
                PAtH_B_3.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_B_3", 0);
            PAtH_B_3.SetActive(false);
        }

        //PATH_B_4
        if (PlayerPrefs.HasKey("PAtH_B_4"))
        {
            if (PlayerPrefs.GetInt("PAtH_B_4") == 1)
            {
                PAtH_B_4.SetActive(true);
            }
            else
            {
                PAtH_B_4.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_B_4", 0);
            PAtH_B_4.SetActive(false);
        }

        //PATH_B_5
        if (PlayerPrefs.HasKey("PAtH_B_5"))
        {
            if (PlayerPrefs.GetInt("PAtH_B_5") == 1)
            {
                PAtH_B_5.SetActive(true);
            }
            else
            {
                PAtH_B_5.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_B_5", 0);
            PAtH_B_5.SetActive(false);
        }

        //PATH_B_6
        if (PlayerPrefs.HasKey("PAtH_B_6"))
        {
            if (PlayerPrefs.GetInt("PAtH_B_6") == 1)
            {
                PAtH_B_6.SetActive(true);
            }
            else
            {
                PAtH_B_6.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_B_6", 0);
            PAtH_B_6.SetActive(false);
        }


        //PATH_C_1
        if (PlayerPrefs.HasKey("PAtH_C_1"))
        {
            if (PlayerPrefs.GetInt("PAtH_C_1") == 1)
            {
                PAtH_C_1.SetActive(true);
            }
            else
            {
                PAtH_C_1.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_C_1", 0);
            PAtH_C_1.SetActive(false);
        }

        //PATH_C_2
        if (PlayerPrefs.HasKey("PAtH_C_2"))
        {
            if (PlayerPrefs.GetInt("PAtH_C_2") == 1)
            {
                PAtH_C_2.SetActive(true);
            }
            else
            {
                PAtH_C_2.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_C_2", 0);
            PAtH_C_2.SetActive(false);
        }

        //PATH_C_3
        if (PlayerPrefs.HasKey("PAtH_C_3"))
        {
            if (PlayerPrefs.GetInt("PAtH_C_3") == 1)
            {
                PAtH_C_3.SetActive(true);
            }
            else
            {
                PAtH_C_3.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_C_3", 0);
            PAtH_C_3.SetActive(false);
        }

        //PATH_C_4
        if (PlayerPrefs.HasKey("PAtH_C_4"))
        {
            if (PlayerPrefs.GetInt("PAtH_C_4") == 1)
            {
                PAtH_C_4.SetActive(true);
            }
            else
            {
                PAtH_C_4.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_C_4", 0);
            PAtH_C_4.SetActive(false);
        }

        //PATH_C_5
        if (PlayerPrefs.HasKey("PAtH_C_5"))
        {
            if (PlayerPrefs.GetInt("PAtH_C_5") == 1)
            {
                PAtH_C_5.SetActive(true);
            }
            else
            {
                PAtH_C_5.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_C_5", 0);
            PAtH_C_5.SetActive(false);
        }

        //PATH_C_6
        if (PlayerPrefs.HasKey("PAtH_C_6"))
        {
            if (PlayerPrefs.GetInt("PAtH_C_6") == 1)
            {
                PAtH_C_6.SetActive(true);
            }
            else
            {
                PAtH_C_6.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("PAtH_C_6", 0);
            PAtH_C_6.SetActive(false);
        }
        //Final
        if (PlayerPrefs.HasKey("final"))
        {
            if (PlayerPrefs.GetInt("final") == 1)
            {
                final.SetActive(true);
            }
            else
            {
                final.SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetInt("final", 0);
            final.SetActive(false);
        }
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();

            if (mTrackableBehaviour.TrackableName == "20NOTE")
            {
                Debug.Log(10);
                PAtH_A_1.SetActive(true);
                PlayerPrefs.SetInt("PAtH_A_1", 1);
                PAtH_B_1.SetActive(true);
                PlayerPrefs.SetInt("PAtH_B_1", 1);
                PAtH_C_1.SetActive(true);
                PlayerPrefs.SetInt("PAtH_C_1", 1);

                WriteNewUser(userid, "1 hint");
            }

            //PATH 1
            if (mTrackableBehaviour.TrackableName == "Chairman" && PAtH_A_1.activeSelf)
            {
                PAtH_A_2.SetActive(true);
                PlayerPrefs.SetInt("PAtH_A_2", 1);
                imag1.SetActive(false);
                PlayerPrefs.SetInt("imag1", 0);
                WriteNewUser(userid, "PATH A 1 hint");
            }
            else if(mTrackableBehaviour.TrackableName == "10NOTE" && PAtH_A_2.activeSelf)
            {
                PAtH_A_3.SetActive(true);
                PlayerPrefs.SetInt("PAtH_A_3", 1);
                WriteNewUser(userid, "PATH A 2 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "MechNext" && PAtH_A_3.activeSelf)
            {
                PAtH_A_4.SetActive(true);
                PlayerPrefs.SetInt("PAtH_A_4", 1);
                WriteNewUser(userid, "PATH A 3 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "Jhonny" && PAtH_A_4.activeSelf)
            {
                PAtH_A_5.SetActive(true);
                PlayerPrefs.SetInt("PAtH_A_5", 1);
                WriteNewUser(userid, "PATH A 4 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "TPO" && PAtH_A_5.activeSelf)
            {
                PAtH_A_6.SetActive(true);
                PlayerPrefs.SetInt("", 1);
                WriteNewUser(userid, "PATH A 5 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "DEEWAR" && PAtH_A_6.activeSelf)
            {
                final.SetActive(true);
                PlayerPrefs.SetInt("final", 1);
                WriteNewUser(userid, "PATH A 6 hint");
            } 
            else if(mTrackableBehaviour.TrackableName=="Final" && final.activeSelf)
            {
                WriteNewUser(userid, "WInner");
            }

            //PATH B
            if (mTrackableBehaviour.TrackableName == "YMCAMAP2" && PAtH_B_1.activeSelf)
            {
                PAtH_B_2.SetActive(true);
                PlayerPrefs.SetInt("PAtH_B_2", 1);
                imag1.SetActive(false);
                PlayerPrefs.SetInt("imag1", 0);
                WriteNewUser(userid, "PATH B 1 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "20NOTE" && PAtH_B_2.activeSelf)
            {
                PAtH_B_3.SetActive(true);
                PlayerPrefs.SetInt("PAtH_B_3", 1);
                WriteNewUser(userid, "PATH B 2 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "goku" && PAtH_B_3.activeSelf)
            {
                PAtH_B_4.SetActive(true);
                PlayerPrefs.SetInt("PAtH_B_4", 1);
                WriteNewUser(userid, "PATH B 3 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "MARY_KOM" && PAtH_B_4.activeSelf)
            {
                PAtH_B_5.SetActive(true);
                PlayerPrefs.SetInt("PAtH_B_5", 1);
                WriteNewUser(userid, "PATH B 4 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "MotherDairy" && PAtH_B_5.activeSelf)
            {
                PAtH_B_6.SetActive(true);
                PlayerPrefs.SetInt("PAtH_B_6", 1);
                WriteNewUser(userid, "PATH B 5 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "RAAM_LAKHAN" && PAtH_B_6.activeSelf)
            {
                final.SetActive(true);
                PlayerPrefs.SetInt("final", 1);
                WriteNewUser(userid, "PATH B 6 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "Final" && final.activeSelf)
            {
                WriteNewUser(userid, "WInner");
            }

            //PATH C
            if (mTrackableBehaviour.TrackableName == "YMCAMAP3" && PAtH_C_1.activeSelf)
            {
                PAtH_C_2.SetActive(true);
                PlayerPrefs.SetInt("PAtH_C_2", 1);
                imag1.SetActive(false);
                PlayerPrefs.SetInt("imag1", 0);
                WriteNewUser(userid, "PATH C 1 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "50NOTE" && PAtH_C_2.activeSelf)
            {
                PAtH_C_3.SetActive(true);
                PlayerPrefs.SetInt("PAtH_C_3", 1);
                WriteNewUser(userid, "PATH C 2 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "powerpuffgirl" && PAtH_C_3.activeSelf)
            {
                PAtH_C_4.SetActive(true);
                PlayerPrefs.SetInt("PAtH_C_4", 1);
                WriteNewUser(userid, "PATH C 3 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "MechNext" && PAtH_C_4.activeSelf)
            {
                PAtH_C_5.SetActive(true);
                PlayerPrefs.SetInt("PAtH_C_5", 1);
                WriteNewUser(userid, "PATH C 4 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "BAsketBall" && PAtH_C_5.activeSelf)
            {
                PAtH_C_6.SetActive(true);
                PlayerPrefs.SetInt("PAtH_C_6", 1);
                WriteNewUser(userid, "PATH C 5 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "TEERANGA" && PAtH_C_6.activeSelf)
            {
                final.SetActive(true);
                PlayerPrefs.SetInt("final", 1);
                WriteNewUser(userid, "PATH C 6 hint");
            }
            else if (mTrackableBehaviour.TrackableName == "Final" && final.activeSelf)
            {
                WriteNewUser(userid, "WInner");
            }



        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }
    public class User
    {
        public string level;
       

        public User()
        {

        }

        public User(string level)
        {
            this.level = level;
            
        }
    }
    private void WriteNewUser(string userId, string level)
    {
        User user = new User(level);
        string json = JsonUtility.ToJson(user);

        reference.Child("users").Child(userId).SetRawJsonValueAsync(json);
    }
    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;
    }

    

    #endregion // PROTECTED_METHODS
}
