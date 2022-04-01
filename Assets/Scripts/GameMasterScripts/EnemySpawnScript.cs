using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{

    private GameObject enemySpawnTrigger;
    public GameObject[] prefab;

    private void Start()
    {
        enemySpawnTrigger = GameObject.FindWithTag("SpawnTrigger");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Trigger was entered");
            for (int x = 0; x < prefab.Length; x++)
            {
                Instantiate(prefab[x], new Vector2(1, 1), Quaternion.identity);
            }
            enemySpawnTrigger.SetActive(false);
        }
    }
}
