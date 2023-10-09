using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lv1 : MonoBehaviour
{
   public void Nextlv1(){
    SceneManager.LoadSceneAsync("Level 1");
    Time.timeScale = 1;
   }
}
