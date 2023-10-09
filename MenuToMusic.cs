using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToMusic : MonoBehaviour
{
    public GameObject MusicPanel;

    
     public void MusicEnter(){
        MusicPanel.SetActive(true);
    }
    public void MusicExit(){
        MusicPanel.SetActive(false);
}
}
