using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HpController : MonoBehaviour
{
    Text HpText;
    float health;
    // Start is called before the first frame update
    public void ChangeHP(float count){
        health = health + count;
        if(health<=0){
            Destroy(gameObject);
        }
    }
    void Start()
    {
        ChangeHP(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
