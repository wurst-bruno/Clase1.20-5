using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    public float speed;
    public bool toright;

    public GameObject baseizq;
    public GameObject baseder;

    public GameObject prefab1;
    public GameObject prefab2;

    int yOffset;

    // Start is called before the first frame update
    void Start()
    {
        toright = true;
        yOffset = 1;


    }

    // Update is called once per frame
    void Update()
    {
        if (toright)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x > baseder.transform.position.x -1)
        {
            toright = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseder.transform.position + new Vector3(0,yOffset,0);
        }
        if (transform.position.x < baseizq.transform.position.x + 1)
        {
            toright = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseizq.transform.position + new Vector3(0, yOffset +1, 0);
            yOffset++;


        }

    }
}
