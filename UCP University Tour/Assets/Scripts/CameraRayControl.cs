using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraRayControl : MonoBehaviour
{
    public static CameraRayControl instance;
    [HideInInspector] public Text infoText;
    [HideInInspector] public Slider timeSlider;
    [HideInInspector] public float delayTimer = 0f;
   
    void Awake() 
    {
        instance=this;
    }
    void Start()
    {
        infoText = GameObject.Find("InfoText").GetComponent<Text>();
        timeSlider = GameObject.Find("Slider").GetComponent<Slider>();
        infoText.enabled = false;
        timeSlider.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // origin: Vector3(0,1,-10)
        bool didHit = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit);
        if (didHit) 
        {
            if (hit.transform.gameObject.tag == "Interact") 
            {
               hit.transform.gameObject.GetComponent<IInteract>().Interact();
            }
          
        } 
        else 
        {
            ResetHit();
        }
    }
  
    void ResetHit() {
        infoText.enabled = false;
        delayTimer = 0f;
        timeSlider.gameObject.SetActive(false);
    }

   
}
