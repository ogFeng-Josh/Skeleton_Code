/*
Unity Skeleton Script
Written by Josh Y. (ogfeng)
Contact - ogfeng.streamers.site
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Additional Libraries:
//================================
//using System; //Allows us to use Array.ETC
//using UnityEngine.Audio; //Libraries Assets for Unity Audio System
//using UnityEngine.UI; //Libraries Assets for Unity UI
using UnityEngine.SceneManagement; //Libraries Assets for Unity Scene Transition/Management
//using UnityEngine.Video; //Libraries Assets for Unity Video Component

//Documentations:
//================================
//[HelpUrl("URL")] Allows user to set a link to a documentation for reference

public class mainmenu : MonoBehaviour
{
    //================================
    #region Variables:
    //[Header("Variables:")]
    //int i1;
    //string s1;
    //float f1;
    //bool b1;
    
    //[Space]
    #endregion

    //================================

    #region Unity Methods:

    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    
    private void Start()
    {
        //DeclaredVariable = GameObject.Find("gameObjectName").GetComponent<ComponentName>();
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
    public void solo1()
    {
        SceneManager.LoadScene("SP_arenaIMP");
        //Debug.Log("Map SP_arena loaded!");
    }
    public void solo2()
    {
        SceneManager.LoadScene("SP_arenaIMP2");
        //Debug.Log("Map SP_arena loaded!");
    }
    public void solo3()
    {
        SceneManager.LoadScene("SP_arenaIMP3");
        //Debug.Log("Map SP_arena loaded!");
    }
    public void solo4()
    {
        SceneManager.LoadScene("SP_arenaIMP4");
        //Debug.Log("Map SP_arena loaded!");
    }

    public void local3()
    {
        SceneManager.LoadScene("lc_arena3");
        //Debug.Log("Map SP_arena loaded!");
    }
    public void local5()
    {
        SceneManager.LoadScene("lc_arena5");
        //Debug.Log("Map SP_arena loaded!");
    }
    public void local7()
    {
        SceneManager.LoadScene("lc_arena7");
        //Debug.Log("Map SP_arena loaded!");
    }
    public void localUnlimited()
    {
        SceneManager.LoadScene("lc_arenaINF");
        //Debug.Log("Map SP_arena loaded!");
    }

    public void difficulty()
    {
        //Set up difficulty by adding level indicated into a script manager for a difficulty system
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game has Quit!");
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