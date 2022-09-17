using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class esya_respawn : MonoBehaviour
{
    private static int skoru = 0;
    public TextMeshProUGUI skor,Bitis;
    private void Start()
    {
        skoru = 0;
    }
    private void Update()
    {
        skor.text = skoru.ToString();
        Bitis.text = "Oyun Bitti! \n Skorunuz: " + skoru.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float rastgeleX = Random.Range(-3.90f, 4f);
        float rastgeleY = Random.Range(5.50f, 9.50f);

        if (collision.gameObject.tag == "kontrol")
        {
            transform.position=new Vector3(rastgeleX, rastgeleY,-1);
            skoru += 10;
        }else if(collision.gameObject.tag == "karakter")
        {
            transform.position = new Vector3(rastgeleX, rastgeleY, -1);
            Can.hak--;
        }
    }
}
