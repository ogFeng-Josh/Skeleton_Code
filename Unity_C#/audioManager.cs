/*
Unity Skeleton Script
Written by Josh Y. (ogfeng)
Contact - ogfeng.streamers.site
Setup Proccess
Go into specific script that will play the audio source and use line...
FindObjectOfType<AudioManager>().Play("PlayerDeath");
AudioManager References this script while playerdeath references the audio clip created
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Additional Libraries:
//================================
using System; //Allows us to use Array.ETC
using UnityEngine.Audio; //Libraries Assets for Unity Audio System
//using UnityEngine.UI; //Libraries Assets for Unity UI
//using UnityEngine.SceneManagement; //Libraries Assets for Unity Scene Transition/Management
//using UnityEngine.Video; //Libraries Assets for Unity Video Component

//Documentations:
//================================
//[HelpUrl("URL")] Allows user to set a link to a documentation for reference

public class audioManager : MonoBehaviour
{
    //================================
    #region Variables:
    //[Header("Variables:")]
    //int i1;
    //string s1;
    //float f1;
    //bool b1;
    
    [Header("Audio Manager")]
    //Set public and the Array name of the AUDIO SCRIPT so if script is named hi, use hi[]
    public sound01[] sounds;

    //With duplication check of AudioManager explained below...
    public static audioManager instance;

    //[Space]
    #endregion

    //================================

    #region Unity Methods:

    // Start is called before the first frame update
    private void Awake()
    {
        //Checks if theres a duplicate of AudioManager before starting another
        if(instance == null)
        {
            instance = this;
        }
        else{
            Destroy(gameObject);
            return;
        }
        //Won't destroy when loading into next scene
        DontDestroyOnLoad(gameObject);

        //Setup for Audio Sources
        foreach(sound01 s in sounds)
        {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
        }
    }
    
    private void Start()
    {
        //DeclaredVariable = GameObject.Find("gameObjectName").GetComponent<ComponentName>();
        //Play("Theme"); //Play Main theme song on start
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }
    //[Space]
    #endregion

    //================================

    #region Methods:
    /*
    private void methodName()
    {
        //Do Something()
    }
    */

    //Plays specific audio source from sound01 script
    public void Play(string name)
    {
        sound01 s = Array.Find(sounds, sounds => sounds.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    //[Space]
    #endregion

    //================================

    #region Collision Check:
    /*
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        Do Something();
    }
    */

    //[Space]
    #endregion

    //================================

    #region RNG Systems:
    /*
    //StartCoroutine(MethodName());
    IEnumerator MethodName()
    {
        yield return new WaitForSeconds(#f);
    }
    */

    //[Space]
    #endregion
    //================================
}

//================================
/*
[RequireComponent(typeof(ComponentName))]
Script requires specific component if needed
Player & Inventory script, attach both script to work or it 
will auto add required script/component if needed
[HideInInspector]
Hides the specific attributes if needed
[Tooltip("This is a definintion")]
Helps define what certain attributes do when you hover your mouse over the attributes title
[Range(0, 20)]
Adds a slider and type option for setting attributes for your Inspector
[DisallowedMultipleComponents]
//Prevents duplicates of same scripts/asses
[Multiline]
Multiple Lines to allow a better view of your paragraph inspector sentences
[System.Serializable]
Shows anything below declared header on Unity Inspector Menu
Also, if you have a class that isn't a Mono-behavior. Having this above the class will show the member of the class
Use an array to have multiple or list to have multiple and add ons with class members showcasing for each attributes
Use dot OP to access 
*/
//================================