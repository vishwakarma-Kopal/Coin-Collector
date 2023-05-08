using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI countText,winText;

    private Rigidbody rb;
    private int count;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count= 0;
    }


    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0,moveVertical);
        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "Count - " + count.ToString();
            if (count>=9)
                winText.gameObject.SetActive(true);

        }
    }
}