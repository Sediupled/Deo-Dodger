using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AiChase : MonoBehaviour
{
    RaycastHit2D hit;
    float maxDist = 50;
    public Transform rayPoint;


    void Start()
    {
        rayPoint = gameObject.transform.GetChild(0);
    }

    void Update()
    {
        hit = Physics2D.Raycast
        (rayPoint.position,transform.right,maxDist);

        if(hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject);
            Debug.DrawRay(rayPoint.position, hit.point, Color.green);
        }
    }
}