using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    //Fire
    private RaycastHit hit;


    //Movement
    public float speed;
    public GameObject player;
    public Joystick jt;


    //tps
    private bool is_tps;


    //flashlight
    private bool is_on;
    private void Start()
    {
        is_tps = true;
        is_on = true;
    }
    private void Update()
    {

       //Vector3 playerInput = new Vector3(jt.Horizontal, 0, jt.Vertical);
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveVelocity = playerInput * Time.deltaTime * speed;

        // player.transform.position += moveVelocity ;// burda sadece yürütüyoruz istediğimiz yöne değil sadece a s d w yönü
        player.transform.Translate(moveVelocity);





        //TPS

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (is_tps) { 
            transform.localPosition = new Vector3(0, 1f, -1.8f);
            transform.localRotation = Quaternion.Euler(60, 0, 0);
            is_tps = false;
             }
            else
            {
            transform.localPosition = new Vector3(0, 0, 0.3f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            is_tps = true;
            }
        }
       

        




        //flashlight
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (is_on)
            {
                GetComponent<Light>().enabled = false;
                is_on = false;
            }
            else
            {
                GetComponent<Light>().enabled = true;
                is_on = true;
            }

        }

        //Fire
        //if (Input.GetKeyDown(KeyCode.Mouse0))// Kullanılabilir fakat kötü bir yazımdır doğrusu alttadır
        if (Input.GetMouseButtonDown(0)/*|| Input.GetTouch(0).tapCount==1*/)
        {
            if(Physics.Raycast(Camera.main.transform.position,transform.forward,out hit, Mathf.Infinity))
            {
                if(hit.collider.gameObject.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
