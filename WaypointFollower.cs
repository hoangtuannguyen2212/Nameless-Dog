using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }
    void Update(){
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform){
            rb.velocity = new Vector2(speed , 0);
        }else {
            rb.velocity = new Vector2(-speed, 0 );
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform){
            flip();
            currentPoint = pointA.transform;
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform){
            flip();
            currentPoint = pointB.transform;
        }
    }
    void flip(){
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
