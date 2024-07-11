using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChase : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, speed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, newDirection);
    }


}
