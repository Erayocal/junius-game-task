
using System.Reflection;
using UnityEngine;

public class Player_fire : MonoBehaviour
{

    [SerializeField] private GameObject fuzePrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fuzesp;
    [SerializeField] private int poolSize;

    private ObjectPool<Fuze_controle> fuzePool;

    private void Awake()
    {
        fuzePool = new ObjectPool<Fuze_controle>(fuzePrefab.GetComponent<Fuze_controle>(), poolSize, this.transform);
    }


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Fire();
        }

    }
    private void Fire()
    {
        // Havuzdan füze al ve ateþle
        Fuze_controle fuze = fuzePool.Get();
        fuze.transform.position = firePoint.position;
        fuze.transform.rotation = firePoint.rotation;
        fuze.Initialize(fuzesp);
    }

    public void ReturnMissileToPool(Fuze_controle missile)
    {
        fuzePool.ReturnToPool(missile);
    }

    
}
