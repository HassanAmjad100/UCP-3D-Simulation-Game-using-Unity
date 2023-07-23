using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour,IInteract
{
    public string SceneName;
    public void Interact()
    {
        Debug.Log("i am interaction");
        CameraRayControl.instance.delayTimer = CameraRayControl.instance.delayTimer + Time.deltaTime;
        CameraRayControl.instance.timeSlider.gameObject.SetActive(true);
        CameraRayControl.instance.timeSlider.value = CameraRayControl.instance.delayTimer;

        if (CameraRayControl.instance.delayTimer > 2) 
        {
            SceneManager.LoadScene(SceneName);
        }
    }
    
}
