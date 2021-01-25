using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BulletScript : MonoBehaviour
{


    float bulletDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)     //this method is called when bullet hits something
    {
        Destroy(gameObject);


        if(collision.gameObject.CompareTag("Player"))
        {

            if(collision.gameObject.GetComponent<PhotonView>().IsMine)
            {
                collision.gameObject.GetComponent<PhotonView>().RPC("DoDamage", RpcTarget.AllBuffered, bulletDamage);     //means that dodamage will be called for every player in the game

            }
           
        }
    }


    public void Initialize(Vector3 _direction, float speed, float damage)
    {
        bulletDamage = damage;

        transform.forward = _direction;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = _direction * speed;


    }
    



}
