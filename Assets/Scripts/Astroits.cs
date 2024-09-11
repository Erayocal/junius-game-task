
using UnityEngine;
using UnityEngine.UI;

public class Astroits : MonoBehaviour
{
    static public Astroits instance;
    [SerializeField] private GameObject[] astroidPrefabs;

    public float sayac;
    public Text ast_sayac;
    void Start()
    {
        instance = this;
        InvokeRepeating("CreateAsteroid",0, 1f);
    }
    private void Update()
    {
        ast_sayac.text= sayac.ToString();
    }


    private void CreateAsteroid()
    {
        //astreoit yaratmak için 
        GameObject selectedPrefab = astroidPrefabs[Random.Range(0, astroidPrefabs.Length)];
        Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(-11f, 11f);
        Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);

    }

}
