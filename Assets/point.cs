using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    [SerializeField] NumberField scoreField;
    [SerializeField] int pointsToAdd;


    private void OnTriggerEnter2D(Collider2D collision)
    {
           if (collision.tag == "Wall") // Corrected the comparison
        {
            scoreField.AddNumber(-pointsToAdd);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
