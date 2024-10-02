using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class movehero : MonoBehaviour
{ Animator animator2;
    // Start is called before the first frame update
    void Start()
    {
        Animator animator2= GetComponent<Animator>();
        if (animator2 != null)
            print("Could not find Animator Component");
        else
            print("Animator Component found");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            animator2.SetBool("isRunning", true);
        }
       

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 60 * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -60 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.position -= transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position += transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
            transform.position += Vector3.up * Time.deltaTime;
    }
}
