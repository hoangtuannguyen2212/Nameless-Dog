using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator ani;
    private Rigidbody2D rb;

    [SerializeField] private AudioSource deathSoundEffect;
    // Start is called before the first frame update
   private void Start(){
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
   }
   private void OnCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.CompareTag("Trap")){
        Die();
    }
   }
   private void Die()
   {
     deathSoundEffect.Play();
     rb.bodyType = RigidbodyType2D.Static;
     ani.SetTrigger("death");
   }
   private void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
