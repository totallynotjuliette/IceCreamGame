using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawIceCream : MonoBehaviour
{
    public Camera m_camera;
    public GameObject iceCreamPrefab;
    public LineRenderer currentLineRenderer;
    Vector2 lastPos;
    int positionIndex = 0;

    Vector2 initialBrushPos;
    Vector2 mousePos;
    



    
    private void Update()
    {   
        // if(m_camera.ScreenToWorldPoint(Input.mousePosition).y >= 0){
        //     Draw();
        // } 

        Draw();

    }

    void Draw() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateParticle();
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            PointToMousePos();  

            if(positionIndex >= 1){
                CreateParticle();
            }


        }
        else 
        {
            currentLineRenderer = null;
        }
    }

    void CreateParticle() 
    {
        GameObject brushInstance = Instantiate(iceCreamPrefab);
        currentLineRenderer = brushInstance.GetComponent<LineRenderer>();

        //because you gotta have 2 points to start a line renderer, 
        mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
 
        currentLineRenderer.SetPosition(0, mousePos);
        currentLineRenderer.SetPosition(1, mousePos);

        initialBrushPos = mousePos;
        //print("initial: " + initialBrushPos);


    }

    void AddAPoint(Vector2 pointPos) 
    {

        currentLineRenderer.positionCount++;
        positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);


    }

    void PointToMousePos() 
    {
        mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
        if (lastPos != mousePos) 
        {
            AddAPoint(mousePos);
            lastPos = mousePos;

        }
    }


}
