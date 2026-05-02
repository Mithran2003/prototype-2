using System;
using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] animalPrefab ;
    private  float xSpwanRange ;
    private float  zSpwanRange ;
    private Vector3 spawnPoint ;
    private short animalIndex ;
    private float waitFor;
    [SerializeField]
    private bool playerIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(randomSpwaner());
    }
    IEnumerator randomSpwaner ()
    {
        while(playerIsAlive) 
        {
            yield return new WaitForSeconds(waitFor);
            Instantiate(animalPrefab[animalIndex],spawnPoint,animalPrefab[animalIndex].transform.rotation);
        }
            
        }
        
       

    // Update is called once per frame
    void Update()
    {
        xSpwanRange = UnityEngine.Random.Range(-23,23);
        zSpwanRange = UnityEngine.Random.Range(18,30);
        spawnPoint = new Vector3(xSpwanRange,0f,zSpwanRange);
        waitFor = UnityEngine.Random.Range(0,4);
        animalIndex = Convert.ToInt16(UnityEngine.Random.Range(0,4));
        
    }
    
}
