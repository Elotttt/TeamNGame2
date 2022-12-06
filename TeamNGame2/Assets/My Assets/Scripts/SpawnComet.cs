using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComet : MonoBehaviour
{
    public int spawnTimer = 1;
    public GameObject comet;
    //public List<GameObject> comets;
    private int xPos;
    private int zPos;

    private CometPooler cometPooler;
    public PoolType cometType;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(CometSpawn());
        cometPooler = FindObjectOfType<CometPooler>();
    }

    // Update is called once per frame
    void Update()
    {
        CometSpawn();
    }
    public void CometSpawn()
    {
        //Instantiate(comets[Random.Range(0, comets.Count)], new Vector3(xPos, 1, zPos), Quaternion.identity);
        //Instantiate(comet, new Vector3(xPos, 1, zPos), Quaternion.identity);
        GameObject newSpawnedObject = cometPooler.GetFromPool(cometType);
        xPos = Random.Range(-150, 150);
        zPos = Random.Range(-150, 150);
        newSpawnedObject.transform.position = new Vector3(xPos, 0, zPos);
        newSpawnedObject.transform.rotation = Quaternion.identity;
        newSpawnedObject.transform.Rotate(0, Random.Range(0.0f, 360.0f), 0);
        newSpawnedObject.SetActive(true);
    }
}