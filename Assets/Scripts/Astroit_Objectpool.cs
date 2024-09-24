
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Ast_spawner;

public class Astroit_Objectpool : MonoBehaviour
{
    private Dictionary<AsteroidType, Queue<GameObject>> asteroidPools = new Dictionary<AsteroidType, Queue<GameObject>>();
    /*private Queue<GameObject> smallAsteroidPool = new Queue<GameObject>();
    private Queue<GameObject> mediumAsteroidPool = new Queue<GameObject>();
    private Queue<GameObject> largeAsteroidPool = new Queue<GameObject>();
    */
    [SerializeField] private GameObject smallAsteroidPrefab;
    [SerializeField] private GameObject mediumAsteroidPrefab;
    [SerializeField] private GameObject largeAsteroidPrefab;

    private void Awake()
    {
        asteroidPools[AsteroidType.Small] = new Queue<GameObject>();
        asteroidPools[AsteroidType.Medium] = new Queue<GameObject>();
        asteroidPools[AsteroidType.Large] = new Queue<GameObject>();
    }
    /*public GameObject GetAst(AsteroidType type)
    {
        GameObject ast = null;

        switch (type)
        {
            case AsteroidType.Small:
                if (smallAsteroidPool.Count > 0)
                {
                    ast = smallAsteroidPool.Dequeue();
                }
                else
                {
                    ast = Instantiate(smallAsteroidPrefab);
                }
                break;

            case AsteroidType.Medium:
                if (mediumAsteroidPool.Count > 0)
                {
                    ast = mediumAsteroidPool.Dequeue();
                }
                else
                {
                    ast = Instantiate(mediumAsteroidPrefab);
                }
                break;

            case AsteroidType.Large:
                if (largeAsteroidPool.Count > 0)
                {
                    ast = largeAsteroidPool.Dequeue();
                }
                else
                {
                    ast = Instantiate(largeAsteroidPrefab);
                }
                break;
        }

        ast.SetActive(true);
        return ast;
    }

    public void ReturnAst(GameObject ast, AsteroidType type)
    {
        ast.SetActive(false);

        switch (type)
        {
            case AsteroidType.Small:
                smallAsteroidPool.Enqueue(ast);
                break;

            case AsteroidType.Medium:
                mediumAsteroidPool.Enqueue(ast);
                break;

            case AsteroidType.Large:
                largeAsteroidPool.Enqueue(ast);
                break;
        }
    }
    */
    private GameObject GetPrefab(AsteroidType type)
    {
        switch (type)
        {
            case AsteroidType.Small: return smallAsteroidPrefab;
            case AsteroidType.Medium: return mediumAsteroidPrefab;
            case AsteroidType.Large: return largeAsteroidPrefab;
            default: return null;
        }
    }
    public GameObject GetAst(AsteroidType type)
    {
        GameObject ast = null;

        if (asteroidPools[type].Count > 0)
        {
            ast = asteroidPools[type].Dequeue();
        }
        else
        {
            ast = Instantiate(GetPrefab(type));
        }

        ast.SetActive(true);
        return ast;
    }
    public void ReturnAst(GameObject ast, AsteroidType type)
    {
        ast.SetActive(false);
        asteroidPools[type].Enqueue(ast);
    }

}
