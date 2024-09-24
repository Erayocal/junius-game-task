
using System.Collections.Generic;
using UnityEngine;

public class Ast_spawner : MonoBehaviour
{

    /*[SerializeField] private GameObject smallAstPrefab;
    [SerializeField] private GameObject mediumAstPrefab;
    [SerializeField] private GameObject largeAstPrefab;

    
    
    private ObjectPool<Ast_movment> smallAstPool;
    private ObjectPool<Ast_movment> mediumAstPool;
    private ObjectPool<Ast_movment> largeAstPool;*/
    [SerializeField] private Astroit_Objectpool asteroidPool; // Merkezi havuz
    [SerializeField] private int poolSize;

    private void Awake()
    {
        /*smallAstPool = new ObjectPool<Ast_movment>(smallAstPrefab.GetComponent<Ast_movment>(), poolSize);
        mediumAstPool = new ObjectPool<Ast_movment>(mediumAstPrefab.GetComponent<Ast_movment>(), poolSize);
        largeAstPool = new ObjectPool<Ast_movment>(largeAstPrefab.GetComponent<Ast_movment>(), poolSize);*/
    }
    private void Start()
    {
        InvokeRepeating("CreateAsteroid", 0, 1f);
    }

    private void CreateAsteroid()
    {
        /*AsteroidType AsteroidTypes = (AsteroidType)Random.Range(0, 3); // Rastgele bir asteroit türü seçiyoruz.

        Ast_movment ast = null;
        GameObject ast_ = asteroidPool.GetAst(AsteroidTypes);

        switch (AsteroidTypes)
        {
            case AsteroidType.Small:
                ast = smallAstPool.Get();
                break;
            case AsteroidType.Medium:
                ast = mediumAstPool.Get();
                break;
            case AsteroidType.Large:
                ast = largeAstPool.Get();
                break;
        }

        Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(-11f, 11f);
        ast.transform.position = spawnPosition;
        ast.gameObject.SetActive(true);
        */
        // Rastgele bir asteroid tipi seçiyoruz
        AsteroidType asteroidType = (AsteroidType)Random.Range(0, 3);

        GameObject ast = asteroidPool.GetAst(asteroidType); // Merkezi havuzdan al

        Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(-11f, 11f);
        ast.transform.position = spawnPosition;
        ast.transform.rotation = Quaternion.identity;
    }

    public void ReturnAstToPool(GameObject ast, AsteroidType type)
    {
        /*  switch (type)
          {
              case AsteroidType.Small:
                  smallAstPool.ReturnToPool(ast1);
                  break;
              case AsteroidType.Medium:
                  mediumAstPool.ReturnToPool(ast1);
                  break;
              case AsteroidType.Large:
                  largeAstPool.ReturnToPool(ast1);
                  break;
          }
          asteroidPool.ReturnAst(ast1, type);
        */
        asteroidPool.ReturnAst(ast, type); // Merkezi havuza geri koy
    }


}
