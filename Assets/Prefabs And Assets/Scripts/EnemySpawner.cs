using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Random = System.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public int EnemQuantity = 20;
    [SerializeField] public GameObject ePrefab;
    [SerializeField] public GameObject[] posArr;
    [SerializeField] public GameObject targ;
    private int saveIndex;
    private int enemiesSpawned = 0;
    Vector3 arbPos;
    
    Random rand = new Random();

    // Update is called once per frame
    void FixedUpdate()
    {
        while(enemiesSpawned < EnemQuantity)
        {
            
            int arbIndex = rand.Next(posArr.Length);
            if (saveIndex == arbIndex)
            {
                arbIndex = rand.Next(posArr.Length);
            }
            arbPos = posArr[arbIndex].transform.position;
            Instantiate(ePrefab, arbPos, Quaternion.identity);
            saveIndex = arbIndex;
            enemiesSpawned++;
        }
    }
}
