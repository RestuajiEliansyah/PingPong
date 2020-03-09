using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallController : MonoBehaviour
{
    GameObject panelSelesai;
    Text txPemenang; 
    Text scoreUIP1;
    Text scoreUIP2;
    int scoreP1;
    int scoreP2;
   public int force;
    Rigidbody2D rigid;
    
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D> ();
        Vector2 arah = new Vector2 (2, 0).normalized;
        rigid.AddForce (arah * force);
        scoreP1 = 0;
        scoreP2 = 0;
        scoreUIP1 = GameObject.Find ("Score1").GetComponent<Text> ();
        scoreUIP2 = GameObject.Find ("Score2").GetComponent<Text> ();
        panelSelesai = GameObject.Find ("PanelSelesai");
        panelSelesai.SetActive (false);
    }
 
    // Update is called once per frame
    void Update () {
    
    }
    void ResetBall(){
        transform.localPosition = new Vector2(0,0);
        rigid.velocity = new Vector2(0,0);
    }
    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.name == "GawangKanan"){
            ResetBall();
            Vector2 arah = new Vector2(2,0).normalized;
            rigid.AddForce(arah * force);
            scoreP1 += 1;
            TampilkanScore();
            if (scoreP1 == 5) {
            panelSelesai.SetActive (true);
            txPemenang = GameObject.Find ("Pemenang").GetComponent<Text> ();
            txPemenang.text = "Player Biru Pemenang!";
            Destroy (gameObject);
            return;
} 
        }
        if(coll.gameObject.name == "GawangKiri"){
            ResetBall();
            Vector2 arah = new Vector2(-2,0).normalized;
            rigid.AddForce(arah * force);
            scoreP2 += 1;
            TampilkanScore();
            if (scoreP2 == 5) {
            panelSelesai.SetActive (true);
            txPemenang = GameObject.Find ("Pemenang").GetComponent<Text> ();
            txPemenang.text = "Player Merah Pemenang!";
            Destroy (gameObject);
            return;
        }
        if (coll.gameObject.name == "Player1" || coll.gameObject.name == "Player2") {
            float sudut = (transform.position.y - coll.transform.position.y) * 5f;
            Vector2 arah = new Vector2(rigid.velocity.x, sudut).normalized;
            rigid.velocity = new Vector2(0, 0);    
            rigid.AddForce(arah * force * 2);
        }
    }
    void TampilkanScore () {
  Debug.Log ("Score P1: " + scoreP1 + " Score P2: " + scoreP2);
  scoreUIP1.text = scoreP1 + "";
  scoreUIP2.text = scoreP2 + "";
}
}