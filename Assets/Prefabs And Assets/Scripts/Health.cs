using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float HealthBar = 100f;

    public void HealthSelect(int i)
    {
        switch (i)
        {
            case 1:
                HealthBar -= 5;
                break;

            case 2:
                HealthBar -= 30;
                break;

            case 3:
                HealthBar -= 50;
                break;

            case 4:
                HealthBar -= 80;
                break;

            case 5:
                HealthBar += 10;
                break;

            case 6:
                HealthBar += 40;
                break;

            case 7:
                HealthBar += 70;
                break;

            case 8:
                HealthBar += 100;
                break;

            default:
                Debug.LogError("Invalid Number");
                break;
        }

    }

    void Update()
    {
        // Call the CheckHealth function to maintain health and check for death
        CheckHealth();
    }

    // Health Maintenance and Death functions
    void CheckHealth()
    {
        if (HealthBar >= 100)
        {
            HealthBar = 100;
        }
        else if (HealthBar <= 0)
        {
            HealthBar = 0;
            Destroy(gameObject);
        }
    }
}
