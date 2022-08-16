using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{ 
  private float TimeElapsed;
    
  private void Update()
 {
     TimeElapsed = TimeElapsed + Time.timeSinceLevelLoad;
     if(TimeElapsed > 400)
      {
        SceneManager.LoadScene(13);
       }
   }
}
