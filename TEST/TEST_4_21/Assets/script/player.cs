using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private UnityEngine.AI.NavMeshAgent agent; //3.17 滑鼠

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();//3.17 滑鼠點

        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);


        RaycastHit hit;    //滑鼠點
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                agent.SetDestination(hit.point);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("block"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 3)
        {
            winText.text = "You Win!";
        }
    }
}
