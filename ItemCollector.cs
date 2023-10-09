using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    

    private int xuong = 0;
    [SerializeField]private Text xuongText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Bones"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            xuong ++;
            xuongText.text = ": "+ xuong;
        }
    }
}
