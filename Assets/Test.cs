using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            transform.position = transform.position + Vector3.up;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
