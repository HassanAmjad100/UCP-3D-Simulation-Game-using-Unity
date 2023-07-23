using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject MenuObj;
    private bool isClosed;
    private void Awake() 
    {
        DontDestroyOnLoad(this);
    }

     private void Start() 
    {
        OpenCloseMenu(false);
    }
    private void Update() 
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isClosed)
            {
                OpenCloseMenu(true);
                isClosed=false;
            }
            else
            {
                OpenCloseMenu(false);
                isClosed=true;
            }
        }
    }
 
    public void OpenCloseMenu(bool condition)
    {
        if(condition)
        {
            MenuObj.SetActive(true);
        }
        else
        {
             MenuObj.SetActive(false);
        }
    }
}
