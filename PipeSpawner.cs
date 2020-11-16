using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime = 1f;
    private float timer = 0f;
    public GameObject pipe;
    public float height;
    
    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime) {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 10);
            timer = 0f;
        }
        timer += Time.deltaTime;
    }
}
