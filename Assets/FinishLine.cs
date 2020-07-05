using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private Image image;
    bool isEnable = false;
    public Rigidbody rb;

    void Start()
    {
        image.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (isEnable == false)
            {
                image.enabled = true;
            }
            //yield return new WaitForSeconds(2);
            Time.timeScale = 0;
        }
    }


        void OnCollisionEnter(Collision collide)
        {
            Debug.Log(collide.collider.name);
            Time.timeScale = 0;
        }
}
