using System;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(UnityEngine.Random.Range(-20), 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }

    private void Instantiate(GameObject gameObject, Vector3 vector3)
    {
        throw new NotImplementedException();
    }
}
