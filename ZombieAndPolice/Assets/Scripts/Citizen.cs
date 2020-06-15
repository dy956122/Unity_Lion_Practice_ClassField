using UnityEngine;

public class Citizen : MonoBehaviour
{
    public float speed;

    public Animator characterAni;

    public Rigidbody rigi;

    private Vector3 angle;

    protected void RandomMove() // 隨機移動功能
    {
        float v = Random.Range(0, 100);
        float h = Random.Range(0, 100);

        rigi.AddForce(transform.forward * speed * v);
        rigi.AddForce(transform.right * speed * h);

        if (v <= 5) angle = new Vector3(0, v * h, 0); // 隨機奔跑角度(想要多一些修改,使旋轉角度正常一些)
        transform.eulerAngles = angle;
    } // 隨機移動功能 結束


    private void Hurt() //
    {
        if (tag == "Zombie")
        {
           
        }
    } //


    void Update()
    {
        RandomMove();
    }
}
