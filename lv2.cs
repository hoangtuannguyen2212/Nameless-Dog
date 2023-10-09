using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lv2 : MonoBehaviour
{
   public void Nextlv2(){
    SceneManager.LoadSceneAsync("Level 2");
    Time.timeScale = 1;
   }
}
