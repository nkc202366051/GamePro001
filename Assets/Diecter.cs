using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diecter : MonoBehaviour
{
    public GameObject Enemy_0;
    float span = 2.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0);
            int px =Random.Range(-10, 7);
            go.transform.position =new Vector3(px, 0, 29);
        }
    }
}
