
using UnityEngine;

public class shield : MonoBehaviour
{
    public GameObject shieldPrefab;
    public Vector2 spX = new Vector2(-10f, 10f);
    public Vector2 spY = new Vector2(-3f, 4f);
    private void Start()
    {
        InvokeRepeating("CreateShield", 5, 20f);
    }

    private void CreateShield()
    {

        Vector3 randomPos = new Vector3(
                  Random.Range(spX.x, spX.y),
                  Random.Range(spY.x, spY.y), 0);
                    
        Instantiate(shieldPrefab, randomPos, Quaternion.identity);
    }
}
