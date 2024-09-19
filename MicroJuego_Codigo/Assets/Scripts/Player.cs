using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public float fuerzaEmpuje = 100f;
    public float fuerzaRotacion = 70f;
    public GameObject prefabBala, gun;
    private Rigidbody rigid;
    public static int SCORE = 0;



    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float empuje = Input.GetAxis("Vertical") * Time.deltaTime;
        float rotacion = Input.GetAxis("Horizontal") * Time.deltaTime;

        Vector3 posEmpuje = transform.right;

        rigid.AddForce(posEmpuje * empuje * fuerzaEmpuje);

        transform.Rotate(Vector3.forward, -rotacion * fuerzaRotacion);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bala = Instantiate(prefabBala, gun.transform.position, Quaternion.identity);
            Bullet bulletScript = bala.GetComponent<Bullet>();
            bulletScript.targetVector = transform.right;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
        SceneManager.LoadScene("SampleScene");
        Player.SCORE = 0;
        }
    }
}
