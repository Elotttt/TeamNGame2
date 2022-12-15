using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComet : MonoBehaviour
{
    public float spawnTimer = 0.5f;
    public GameObject comet;
    //public List<GameObject> comets;
    private int xPos;
    private int zPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CometSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CometSpawn()
    {
        while (true)
        {
            xPos = Random.Range(-150, 150);
            zPos = Random.Range(-150, 150);
            //Instantiate(comets[Random.Range(0, comets.Count)], new Vector3(xPos, 1, zPos), Quaternion.identity);
            Instantiate(comet, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnTimer);
        }
    }
}