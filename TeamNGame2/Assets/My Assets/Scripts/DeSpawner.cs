using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    private CometPooler cometPooler;

    // Start is called before the first frame update
    void Start()
    {
        cometPooler = FindObjectOfType<CometPooler>();
        StartCoroutine(Despawn());
    }

    public IEnumerator Despawn()
    {
        cometPooler.AddToPool(gameObject.GetComponent<Comet>().cometType, gameObject); //!!!
        yield return new WaitForSeconds(30);
    }
}
