using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("FKFKFKFK");
        transform.position = new Vector3(x, y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x += 1 * Time.deltaTime;
        transform.position = new Vector3(x, y);
    }
}
