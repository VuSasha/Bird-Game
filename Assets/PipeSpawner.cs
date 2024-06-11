using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 3;
    private float  Timer = 0;
    public float heightOffSett = 10;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < spawnRate)
        {
            Timer += Time.deltaTime;

        }
        else
        {
            spawnPipe();
            Timer = 0;
        }

        if (transform.position.x< -40)
        {
            Destroy(gameObject);
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSett;
        float highestPoint = transform.position.y + heightOffSett;



        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),transform.position.z), transform.rotation);
    }
}
