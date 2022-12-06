using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    public PoolType cometType;
    public int speed = 10;

    public CometPooler cometPooler;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0, Random.Range(0.0f, 360.0f), 0);
        StartCoroutine(WaitAndDestroy());
        cometPooler = FindObjectOfType<CometPooler>();
    }

    // Update is called once per frame
    void Update()
    {
        CometMove();
    }

    public void CometMove()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    IEnumerator WaitAndDestroy()
    {
        //Destroy(gameObject);
        cometPooler.AddToPool(gameObject.GetComponent<Comet>().cometType, gameObject);
        yield return new WaitForSeconds(30f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hit!");
        }
    }
}