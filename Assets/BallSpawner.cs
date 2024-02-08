using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int randomNum;
    public Transform spawnTransform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)) 
        {
            Vector3 spawnPosition = spawnTransform.position;
            randomNum = Random.Range(2, 12);
            spawnPosition.z = randomNum;
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
