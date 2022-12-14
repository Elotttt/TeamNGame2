using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    public int speed = 10;
    public GameObject playerReference;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, Random.Range(0.0f, 360.0f), 0);
        StartCoroutine(WaitAndDestroy());
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
        yield return new WaitForSeconds(30f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(0, 0, 0);
            Debug.Log("Hit!");
        }
    }
}