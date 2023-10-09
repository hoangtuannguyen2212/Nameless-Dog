using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    private Animator ani;
    private float dirX = 0f;
    private SpriteRenderer sprite;
    private BoxCollider2D col;
    [SerializeField]private LayerMask NhayDc;

    [SerializeField] private AudioSource jumpSoundEffect;
    private void Start (){
        ani = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<BoxCollider2D>();
    }
    private void Update(){
        dirX = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(dirX * 7f, GetComponent<Rigidbody2D>().velocity.y);
        if(Input.GetKeyDown("space") && IsGrounded()){
            jumpSoundEffect.Play();
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,10f);
        }
        UpdateAnimation();
    }
    private void UpdateAnimation(){
        if(dirX > 0f){
            ani.SetBool("running", true);
            sprite.flipX = false;
        }
        else if(dirX < 0f){
            ani.SetBool("running",true);
            sprite.flipX = true;
        } 
        else{
            ani.SetBool("running",false);
        }
    }
    private bool IsGrounded(){
        return Physics2D.BoxCast(col.bounds.center,col.bounds.size,0f,Vector2.down,.1f,NhayDc);
    }
    
}
