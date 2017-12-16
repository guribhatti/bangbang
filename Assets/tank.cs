using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tank : MonoBehaviour {
    public float MovementSpeed = 1;
    public float MovementSpeed1 = 2;
    [SerializeField]
    GameObject mExplosionPrefab;
    bool starttime;
    float timer = 3f;

    public Image HealthBar;
    public float Health = 1;

    [SerializeField]
    GameObject m2ExplosionPrefab;

    // Use this for initialization

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (transform.position.x >= -4.17 && transform.position.x <= 4.17) ;
        transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * MovementSpeed;
        float vertical = Input.GetAxisRaw("Vertical");
        if (transform.position.x >= -4.17 && transform.position.x <= 4.17) ;
        transform.position += new Vector3(0, vertical, 0) * Time.deltaTime * MovementSpeed1;

        if (HealthBar.fillAmount == 0)
        {
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            starttime = true;

        }
        if (starttime)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene("endgame");
            Destroy(gameObject);
        }

        HealthBar.fillAmount = Health;
    }



    void TakeDamage(int damage)
    {
        Debug.Log("Taking Damage: " + damage);
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.layer == LayerMask.NameToLayer("man"))
        {

            Health -= .10f;
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(obj.gameObject);
            
        }
    }
        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.layer == LayerMask.NameToLayer("powerup"))
            {
                Health = 1f;
                Destroy(coll.gameObject);
            }
        }
        

 }
  
