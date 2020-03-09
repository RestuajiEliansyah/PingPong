using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float batasAtas;
    public float batasBawah;
    public float batasKiri;
    public float batasTengah;
    public float kecepatan;
    public string axisVertical,axisHorizontal;
 
    // Use this for initialization
    void Start () {
 
    }
    
    // Update is called once per frame
    void Update () {
        float gerakVertical = Input.GetAxis (axisVertical) * kecepatan * Time.deltaTime;
        float gerakHorizontal = Input.GetAxis (axisHorizontal) * kecepatan * Time.deltaTime;
        float nextPosVertical = transform.position.y + gerakVertical;
        float nextPosHorizontal = transform.position.x + gerakHorizontal;
        if (nextPosVertical > batasAtas) {
            gerakVertical = 0;
        }
        if (nextPosVertical < batasBawah) {
            gerakVertical = 0;
        }
        if (nextPosHorizontal > batasTengah){
            gerakHorizontal = 0;
        }
        if (nextPosHorizontal < batasKiri){
            gerakHorizontal = 0;
        }
        transform.Translate (gerakHorizontal, gerakVertical, 0);
    }
}