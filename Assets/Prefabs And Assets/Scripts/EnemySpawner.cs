using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;
using Random = System.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public int EnemQuantity = 5;
    [SerializeField] public GameObject ePrefab;
    [SerializeField] public GameObject[] posArr;
    [SerializeField] public GameObject targ;
    private int saveIndex;
    private int enemiesSpawned = 0;
    Vector3 arbPos;
    

    // Update is called once per frame
    void Update()
    {
        while(enemiesSpawned < EnemQuantity)
        {
            var rand = new Random();
            int arbIndex = rand.Next(posArr.Length);
            if (saveIndex == arbIndex)
            {
                arbIndex = rand.Next(posArr.Length);
            }
            arbPos = posArr[arbIndex].transform.position;
            Instantiate(ePrefab, arbPos, Quaternion.identity);
            ePrefab.GetComponent<AIDestinationSetter>().target = targ.transform;
            saveIndex = arbIndex;
            enemiesSpawned++;
        }
    }
}
