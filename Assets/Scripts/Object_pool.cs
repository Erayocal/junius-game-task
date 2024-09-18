
using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    private List<T> pool;
    private T prefab;
    private Transform parentTransform;

    public ObjectPool(T prefab, int poolSize, Transform parentTransform = null)
    {
        this.prefab = prefab;
        this.parentTransform = parentTransform;
        pool = new List<T>();

        for (int i = 0; i < poolSize; i++)
        {
            T obj = GameObject.Instantiate(prefab, parentTransform);
            obj.gameObject.SetActive(false);
            pool.Add(obj);
        }
    }

    public T Get()
    {
        foreach (T obj in pool)
        {
            if (!obj.gameObject.activeInHierarchy)
            {
                obj.gameObject.SetActive(true);
                return obj;
            }
        }

        
        T newObj = GameObject.Instantiate(prefab, parentTransform);
        newObj.gameObject.SetActive(true);
        pool.Add(newObj);
        return newObj;
    }

    public void ReturnToPool(T obj)
    {
        obj.gameObject.SetActive(false);
    }
    
}


