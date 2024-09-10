
using UnityEngine;

public class Astroits : MonoBehaviour
{
    [SerializeField] private GameObject[] astroidPrefabs;
    void Start()
    {
        InvokeRepeating("CreateAsteroid",0, 1f);
    }

   

    private void CreateAsteroid()
    {
        //astreoit yaratmak için 
        GameObject selectedPrefab = astroidPrefabs[Random.Range(0, astroidPrefabs.Length)];
        Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(-11f, 11f);
        Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);

    }

}
