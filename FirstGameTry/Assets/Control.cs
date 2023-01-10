using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
  /*  private void OnCollisionEnter(Collision collision) // collider olmak zorunda ve en az birinde rigidbody olmak zorunda
    {
        print("Deydim ben  " + collision.transform.localPosition);
        print("\n"+collision.gameObject.name);
    }*/
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
    }
}
