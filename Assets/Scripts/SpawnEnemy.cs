using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public GameObject[] waypoints;
    public GameObject testEnemyPrefab;
    public GameObject testEnemyPrefab2;

    private void Start()
    {
        Instantiate(testEnemyPrefab).GetComponent<MoveEnemy>().waypoints = waypoints;
        Instantiate(testEnemyPrefab2).GetComponent<MoveEnemy>().waypoints = waypoints;
    }
}
