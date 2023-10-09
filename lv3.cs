using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lv3 : MonoBehaviour
{
   public void Nextlv3(){
    SceneManager.LoadSceneAsync("Level 3");
    Time.timeScale = 1;
   }
}