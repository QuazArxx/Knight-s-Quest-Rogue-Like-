using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{

    private GameObject enemySpawnTrigger;

    private void Start()
    {
        enemySpawnTrigger = GameObject.FindWithTag("SpawnTrigger");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Trigger was entered");
            enemySpawnTrigger.SetActive(false);
        }
    }
}
