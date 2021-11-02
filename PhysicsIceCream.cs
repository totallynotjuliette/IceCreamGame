using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsIceCream : MonoBehaviour
{
    // Start is called before the first frame update
    LineRenderer lineRenderer;
    Vector2 currentPos;
    Rigidbody2D rb;

    int indexNum;

    // iceCreamCollider;
    void Start()
    {   
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        indexNum = lineRenderer.positionCount;
        
        gameObject.transform.position = lineRenderer.GetPosition(0);

        //iceCreamCollider = gameObject.GetComponent<CircleCollider2D>();

        // gameObject.GetComponent<LineRenderer>().po
        // gameObject.transform.position = 
        // Vector2 position = .5 * 9.81 * Mathf.Pow(Time.deltaTime, 2);
        
    }

    // Update is called once per frame
    void Update()
    {   
        

        for(int index = 0; index <= indexNum; index++){

            indexNum = lineRenderer.positionCount;
            print(indexNum);
            
            lineRenderer.SetPosition(index, new Vector2(lineRenderer.GetPosition(index).x, gameObject.transform.position.y));
        }   

        // if(currentPos.y >= 0 && numOfCollisions < 2){

        //     for(int index = 0; index <= indexNum; index++){

        //         currentPos = lineRenderer.GetPosition(0);
                
        //         currentPos.y = currentPos.y + (float)(.5 * -1000 * Mathf.Pow(Time.deltaTime, 2));

        //         lineRenderer.SetPosition(index, currentPos);

        //     }
        // }
    }


    // int numOfCollisions;

    // void OnTriggerEnter2D(Collider2D collider){

    //     //print(1);
    //     if(collider.gameObject.tag == "iceCreamParticle"){
    //      numOfCollisions++;
    //      //print(numOfCollisions);

    //    }
    //  }

    //  void OnTriggerExit2D(Collider2D collider){

    //     if(collider.gameObject.tag == "iceCreamParticle"){
    //      numOfCollisions--;
    //      //print(numOfCollisions);

    //    }
    //  }

     void OnBecameInvisible() {
         Destroy(gameObject);
     }


}
