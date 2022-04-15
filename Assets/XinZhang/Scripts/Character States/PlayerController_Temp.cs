using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController_Temp : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public Vector3 forwardDistance;
    public float radius;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Movement();

        //see result in function OnDrawGizmosSelected
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(gameObject.transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-gameObject.transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-gameObject.transform.right * speed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(gameObject.transform.right * speed * Time.deltaTime, ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            checkItem();
        }
    }

    private void checkItem()
    {
        var checkItems = Physics.OverlapSphere(transform.forward + forwardDistance, radius);
        foreach (var item in checkItems)
        {
            if(item.gameObject.CompareTag("item"))
            {
                //check if the item is weapon or not;
                if(true)
                {

                }
                else
                {

                }
                Destroy(item.gameObject);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.forward + forwardDistance, radius);
    }
}
