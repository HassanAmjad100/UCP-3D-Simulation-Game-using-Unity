using UnityEngine;

public class RoomObject : MonoBehaviour,IInteract
{
    // Start is called before the first frame update
  public void Interact()
   {
      
         CameraRayControl.instance.infoText.enabled = true;
         CameraRayControl.instance.infoText.text = "This is a "+ gameObject.name;
        
   }
}
