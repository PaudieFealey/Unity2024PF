using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;

public class collisionscript : MonoBehaviour
{
    Animator goblinmove;
    // Start is called before the first frame update
    void Start()
    {
        Animator goblinmove = GetComponent<Animator>();
        if (goblinmove != null)
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

            goblinmove.SetBool("isRunning", true);
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
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

        collision.gameObject.transform.position += Vector3.forward;
    }
}
