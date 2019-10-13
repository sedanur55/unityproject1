using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topkontorol : MonoBehaviour
{
    Rigidbody fizik;
    public int hız;
    int sayac = 0;
    public int toplanacakobjesayisi;
    public Text sayacText;
    public Text oyunbittitext;



    void Start()
    {
        fizik = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec*hız);
        //Debug.Log("yatay=" +yatay+ "dikey=" +dikey);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "engel")
        {
            other.gameObject.SetActive(false);
            sayac++;
            sayacText.text = "SKOR :" + sayac;
            if(sayac==toplanacakobjesayisi)
            {
                oyunbittitext.text = "GAME OVER";
            }
          
        }
       
    }
}
