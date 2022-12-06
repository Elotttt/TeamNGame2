using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //Allows use of enum in editor
public enum PoolType { comet1, comet2, comet3 }; //Identify different comets with an enum

[System.Serializable] //Allows use of class in editor
public class CometPool //Creating object pool class
{
    public PoolType poolType; //Can set which type of objects will be stored in this pool
    public GameObject prefabObject; //Stores the prefab gameobject which will be used in this pool
    public Queue<GameObject> objectQueue; //Stores all the object that are unused
}

public class CometPooler : MonoBehaviour
{
    public CometPool[] cometPools; //Array to store all the pools

    // Start is called before the first frame update
    void Start()
    {
        Initialisation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Functions
    /// </summary>
    #region
    public void Initialisation() //Initialises the object pools
    {
        foreach (CometPool cometPool in cometPools) //For each pool class in the array...
        {
            cometPool.objectQueue = new Queue<GameObject>(); //Create a new queue for that class
        }
    }

    public CometPool FindByPoolType(PoolType poolType) //Finds the correct pool by type
    {
        CometPool result = null; //Local variable to store the result

        foreach (CometPool cometPool in cometPools) //For each pool class in the array...
        {
            if (cometPool.poolType == poolType) //If this pool is of the type we are looking for...
            {
                result = cometPool; //Updates result
            }
        }
        return result; //Returns result
    }

    public void AddToPool(PoolType poolType, GameObject item)
    {
        item.SetActive(false); //Deactivates object
        FindByPoolType(poolType).objectQueue.Enqueue(item);
    }

    public GameObject GetFromPool(PoolType poolType)
    {
        CometPool cometPool = FindByPoolType(poolType); //Gets a pool by type
        if (cometPool.objectQueue.Count > 0) //If there are objects in the queue...
        {
            return cometPool.objectQueue.Dequeue(); //Take them out of the queue
        }
        else //Otherwise...
        {
            return Instantiate(cometPool.prefabObject); //Creates a new object
        }
    }
    #endregion
}
