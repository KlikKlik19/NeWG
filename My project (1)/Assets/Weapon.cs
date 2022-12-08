using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage;
    public Camera cam;
    public LayerMask Layer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown( KeyCode.Mouse0 ))
        {
        Shoot();
        }
    }
    void Shoot()
    {
        Ray ray =  new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit,Layer))
        {
            Debug.Log("пиу"+ hit.collider);
        }
    }
}
