using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage;
    public Camera cam;
    public float MaxSpeedFire;
    float speedFire;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey( KeyCode.Mouse0 )&& speedFire <= 0)
        {
            Shoot();
            speedFire = MaxSpeedFire;
        }
        if (speedFire>0){
            speedFire -= Time.deltaTime;
        }
    }
    void Shoot()
    {
        Ray ray =  new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            Debug.Log("пиу"+ hit.collider);
            if (hit.collider.tag == "Player")
            {
                hit.collider.GetComponent<HpController>().ChangeHP(-damage);
            }
        }
    }
}
