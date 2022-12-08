using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform Pointer;
    
    public GameObject teleportPoin;
    public float dictance;
    public Transform player;
    float cooldown;
    public float MaxCooldown;
    
    bool isCooldown;
    void Start(){
        isCooldown = false;
    }
    
    void LateUpdate()
    {
        
        Ray ray= new Ray(transform.position, transform.forward);
        
        Debug.DrawRay(transform.position,transform.forward*dictance, Color.blue);
        RaycastHit hit;
        cooldown -= Time.deltaTime;
        
        if(Physics.Raycast(ray,out hit,dictance))
            {
                Pointer.position = hit.point;
            }
        else{
            Pointer.position = player.position;
        }
        if(isCooldown){
            if( Input.GetKeyDown( KeyCode.Mouse1 ))
            {
            teleportPoin.SetActive(true);
            
            }
            if( Input.GetKeyUp( KeyCode.Mouse1 ))
            {
                player.position = Pointer.position;
                teleportPoin.SetActive(false);
                cooldown = MaxCooldown;
                isCooldown = false;
            }
            }
        if(cooldown <= 0f){
            isCooldown = true;
        }

        
    }
}
